﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ScreenRecorder.Properties;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    public partial class MainForm : Form
    {
        private bool isRecording = false;
        private System.Timers.Timer timer = new System.Timers.Timer();
        private DateTime startTime;

        private Recorder recorder;
        private AppSettings settings = new AppSettings();

        public MainForm()
        {
            InitializeComponent();
            BtnPauseRecorder.Visible = false;
            BtnPauseRecorder.Text = "暂停录制";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnStartRecorder_Click(object sender, EventArgs e)
        {
            StartRecording();
        }

        private void StartRecording()
        {
            if (isRecording)
            {
                recorder.Stop();
                timer.Stop();
                return;
            }

            CreateRecording();

            isRecording = true;
            startTime = DateTime.Now;
            timer.Start();
        }

        private void CreateRecording()
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            if (!Directory.Exists(settings.SavePath))
            {
                throw new DirectoryNotFoundException(settings.SavePath);
            }
            string videoPath = Path.Combine(settings.SavePath, timestamp + ".mp4");

            RecorderOptions options = BuildOptions();

            recorder = Recorder.CreateRecorder(options);
            recorder.OnRecordingComplete += Recorder_OnRecordingComplete;
            recorder.OnRecordingFailed += Recorder_OnRecordingFailed;
            recorder.OnStatusChanged += Recorder_OnStatusChanged;

            recorder.Record(videoPath);
        }

        /// <summary>
        /// 构建录屏参数
        /// </summary>
        /// <returns></returns>
        private RecorderOptions BuildOptions()
        {
            //These options must be set before starting the recording, and cannot be modified while recording.
            RecorderOptions options = new RecorderOptions();

            options.SourceOptions = new SourceOptions
            {
                //Populate and pass a list of recordingsources.
                RecordingSources = GetVideoSourceByName(
                    (RecordingSourceType)settings.VideoSourceTypeIndex,
                    settings.VideoSourceName
                )
            };
            options.OutputOptions = new OutputOptions
            {
                RecorderMode = RecorderMode.Video,
                //This sets a custom size of the video output, in pixels.
                OutputFrameSize = new ScreenSize(
                    settings.OutputFrameSize.Width,
                    settings.OutputFrameSize.Height
                ),
                //Stretch controls how the resizing is done, if the new aspect ratio differs.
                Stretch = StretchMode.Uniform,
                //SourceRect allows you to crop the output.
                SourceRect = new ScreenRect(
                    settings.ScreenRect.Left,
                    settings.ScreenRect.Top,
                    settings.ScreenRect.Width,
                    settings.ScreenRect.Height
                ),
            };
            options.AudioOptions = new AudioOptions
            {
                Bitrate = AudioBitrate.bitrate_128kbps,
                Channels = AudioChannels.Stereo,
                IsAudioEnabled = true,
            };

            if (!string.IsNullOrEmpty(settings.AudioInputDevice) && settings.EnableAudioInput)
            {
                options.AudioOptions.AudioInputDevice = settings.AudioInputDevice;
                options.AudioOptions.InputVolume = settings.AudioInputVolume;
                options.AudioOptions.IsInputDeviceEnabled = true;
            }
            if (!string.IsNullOrEmpty(settings.AudioOutputDevice) && settings.EnableAudioOutput)
            {
                options.AudioOptions.AudioOutputDevice = settings.AudioOutputDevice;
                options.AudioOptions.OutputVolume = settings.AudioOutputVolume;
                options.AudioOptions.IsOutputDeviceEnabled = true;
            }

            IVideoEncoder encoder;
            if (ConfigOptions.VideoEncoderArray[settings.VideoEncoderIndex] == "H264")
            {
                encoder = new H264VideoEncoder
                {
                    BitrateMode = H264BitrateControlMode.Quality,
                    EncoderProfile = H264Profile.Main,
                };
            }
            else
            {
                encoder = new H265VideoEncoder
                {
                    BitrateMode = H265BitrateControlMode.Quality,
                    EncoderProfile = H265Profile.Main,
                };
            }

            options.VideoEncoderOptions = new VideoEncoderOptions
            {
                Bitrate = settings.VideoBitrate * 1000,
                Framerate = settings.VideoFramerate,
                Quality = int.Parse(ConfigOptions.VideoQualityArray[settings.VideoQualityIndex]),
                IsFixedFramerate = true,
                //Currently supported are H264VideoEncoder and H265VideoEncoder
                Encoder = encoder,
                //Fragmented Mp4 allows playback to start at arbitrary positions inside a video stream,
                //instead of requiring to read the headers at the start of the stream.
                IsFragmentedMp4Enabled = false, //H265 需要为false
                //If throttling is disabled, out of memory exceptions may eventually crash the program,
                //depending on encoder settings and system specifications.
                IsThrottlingDisabled = false,
                //Hardware encoding is enabled by default.
                IsHardwareEncodingEnabled = true,
                //Low latency mode provides faster encoding, but can reduce quality.
                IsLowLatencyEnabled = false,
                //Fast start writes the mp4 header at the beginning of the file, to facilitate streaming.
                IsMp4FastStartEnabled = false
            };
            options.MouseOptions = new MouseOptions
            {
                //Displays a colored dot under the mouse cursor when the left mouse button is pressed.
                IsMouseClicksDetected = true,
                MouseLeftClickDetectionColor = "#FFFF00",
                MouseRightClickDetectionColor = "#FFFF00",
                MouseClickDetectionRadius = 30,
                MouseClickDetectionDuration = 100,
                IsMousePointerEnabled = true,
                /* Polling checks every millisecond if a mouse button is pressed.
                   Hook is more accurate, but may affect mouse performance as every mouse update must be processed.*/
                MouseClickDetectionMode = MouseDetectionMode.Hook
            };
            var ovDevice = GetVideoSourceByName(
                RecordingSourceType.Camera,
                settings.VideoOverlaysDevice
            );

            if (settings.EnableOverlay && ovDevice != null && ovDevice.Count > 0)
            {
                var dev = ovDevice[0] as RecordableCamera;
                options.OverlayOptions = new OverLayOptions
                {
                    //Populate and pass a list of recording overlays.
                    Overlays = new List<RecordingOverlayBase>
                    {
                        new VideoCaptureOverlay
                        {
                            AnchorPoint = (ScreenRecorderLib.Anchor)
                                settings.VideoOverlaysPositionIndex,
                            Offset = new ScreenSize(
                                settings.VideoOverlaysOffset.Width,
                                settings.VideoOverlaysOffset.Height
                            ),
                            Size = new ScreenSize(
                                settings.VideoOverlaysSize.Width,
                                settings.VideoOverlaysSize.Height
                            ),
                            DeviceName = dev.DeviceName,
                        }
                    },
                };
            }

            options.SnapshotOptions = new SnapshotOptions
            {
                //Take a snapshot of the video output at the given interval
                SnapshotsWithVideo = false,
                SnapshotsIntervalMillis = 1000,
                //SnapshotFormat = ImageFormat.PNG,
                //Optional path to the directory to store snapshots in
                //If not configured, snapshots are stored in the same folder as video output.
                SnapshotsDirectory = ""
            };
            options.LogOptions = new LogOptions
            {
                //This enabled logging in release builds.
                IsLogEnabled = true,
                //If this path is configured, logs are redirected to this file.
                LogFilePath = "recorder.log",
                LogSeverityLevel = ScreenRecorderLib.LogLevel.Debug
            };

            return options;
        }

        private static List<RecordingSourceBase> GetVideoSourceByName(
            RecordingSourceType type,
            string name
        )
        {
            var src = new List<RecordingSourceBase>();

            switch (type)
            {
                case RecordingSourceType.Monitor:
                    foreach (var monitor in Recorder.GetDisplays())
                    {
                        if (monitor.FriendlyName == name)
                        {
                            src.Add(monitor);
                            break;
                        }
                    }
                    break;
                case RecordingSourceType.Window:
                    foreach (var window in Recorder.GetWindows())
                    {
                        if (
                            window.IsValidWindow()
                            && window.IsVideoCaptureEnabled
                            && window.Title == name
                        )
                        {
                            src.Add(window);
                            break;
                        }
                    }
                    break;
                case RecordingSourceType.Camera:
                    foreach (var device in Recorder.GetSystemVideoCaptureDevices())
                    {
                        if (device.FriendlyName == name)
                        {
                            src.Add(device);
                        }
                    }
                    break;
                default:
                    break;
            }

            return src;
        }

        private void Recorder_OnStatusChanged(object sender, RecordingStatusEventArgs e)
        {
            BeginInvoke(
                new Action(() =>
                {
                    switch (e.Status)
                    {
                        case RecorderStatus.Recording:
                            if (timer != null)
                                timer.Enabled = true;
                            BtnStartRecorder.Text = "停止录制";
                            BtnPauseRecorder.Visible = true;
                            BtnPauseRecorder.Text = "暂停录制";
                            break;
                        case RecorderStatus.Paused:
                            if (timer != null)
                                timer.Enabled = false;
                            BtnPauseRecorder.Text = "继续录制";
                            break;
                        case RecorderStatus.Finishing:
                            BtnPauseRecorder.Visible = false;
                            break;
                        default:
                            break;
                    }
                })
            );
        }

        private void Recorder_OnRecordingFailed(object sender, RecordingFailedEventArgs e)
        {
            BeginInvoke(
                new Action(() =>
                {
                    BtnPauseRecorder.Visible = false;
                    BtnStartRecorder.Text = "开始录制";
                    isRecording = false;
                    CleanupResources();
                    MessageBox.Show(e.Error, "错误");
                })
            );
        }

        private void Recorder_OnRecordingComplete(object sender, RecordingCompleteEventArgs e)
        {
            BeginInvoke(
                new Action(() =>
                {
                    string filePath = e.FilePath;
                    Console.WriteLine(filePath);
                    BtnPauseRecorder.Visible = false;
                    BtnStartRecorder.Text = "开始录制";
                    isRecording = false;
                    CleanupResources();
                })
            );
        }

        private void CleanupResources()
        {
            timer.Stop();
            LblRecordDuration.Text = "00:00:00";
            recorder?.Dispose();
            recorder = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var now = DateTime.Now;
            TimeSpan duration = now - startTime;
            this.Invoke(
                new Action(() =>
                {
                    LblRecordDuration.Text = duration.ToString(@"hh\:mm\:ss");
                })
            );
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            recorder?.Stop();
            timer.Close();
            recorder?.Dispose();
        }

        private void BtnPauseRecorder_Click(object sender, EventArgs e)
        {
            if (recorder == null)
            {
                return;
            }
            switch (recorder.Status)
            {
                case RecorderStatus.Recording:
                    recorder.Pause();
                    break;
                case RecorderStatus.Paused:
                    recorder.Resume();
                    break;
                case RecorderStatus.Idle:
                case RecorderStatus.Finishing:
                    break;
                default:
                    break;
            }
        }

        private void LinkSettingForm_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm();
            settingForm.ShowDialog();

            settings = settingForm.Settings;
        }
    }
}
