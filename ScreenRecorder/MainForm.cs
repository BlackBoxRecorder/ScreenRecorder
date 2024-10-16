﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using ScreenRecorder.Properties;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    public partial class MainForm : Form
    {
        private bool isRecording = false;
        private readonly Stopwatch sw = new Stopwatch();

        private Recorder recorder;
        private AppSettings settings;

        public MainForm()
        {
            InitializeComponent();

            Width = 280;
            Height = 260;

            LblRecordDuration.Location = new Point(
                (this.Width - LblRecordDuration.Width - 12) / 2,
                10
            );

            BtnStartRecorder.Location = new Point(
                (this.Width - BtnStartRecorder.Width - 16) / 2,
                60
            );
            BtnPauseRecorder.Location = new Point(
                (this.Width - BtnPauseRecorder.Width - 16) / 2,
                105
            );

            tableLayoutPanel1.Location = new Point(
                (this.Width - tableLayoutPanel1.Width - 4) / 2,
                160
            );

            this.TopMost = true;
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
                return;
            }

            CreateRecording();

            isRecording = true;
            sw.Restart();
            UpdateRecordDuration();
        }

        private void CreateRecording()
        {
            if (settings.HiddenMainWindow)
            {
                IntPtr hwnd = this.Handle;
                Recorder.SetExcludeFromCapture(hwnd, true);
            }

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
            recorder.OnSnapshotSaved += Recorder_OnSnapshotSaved;

            recorder.Record(videoPath);
        }

        private void Recorder_OnSnapshotSaved(object sender, SnapshotSavedEventArgs e)
        {
            string filepath = e.SnapshotPath;
            Console.WriteLine(filepath);
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
                RecordingSources = Utils.GetVideoSourceByName(settings.VideoSourceName)
            };
            options.OutputOptions = new OutputOptions
            {
                RecorderMode = RecorderMode.Video,
                //This sets a custom size of the video output, in pixels.
                OutputFrameSize = new ScreenSize(
                    settings.ScreenRect.Width,
                    settings.ScreenRect.Height
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
                //Bitrate = AudioBitrate.bitrate_192kbps,
                //Channels = AudioChannels.Mono,
                IsAudioEnabled = true,
            };

            if (!string.IsNullOrEmpty(settings.AudioInputDevice) && settings.EnableAudioInput)
            {
                options.AudioOptions.AudioInputDevice = settings.AudioInputDevice;
                options.AudioOptions.IsInputDeviceEnabled = true;
            }
            if (!string.IsNullOrEmpty(settings.AudioOutputDevice) && settings.EnableAudioOutput)
            {
                options.AudioOptions.AudioOutputDevice = settings.AudioOutputDevice;
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
            if (settings.EnableMousePoint)
            {
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
            }

            var ovDevice = Utils.GetVideoSourceByName(settings.VideoOverlaysDevice);

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

        private void Recorder_OnStatusChanged(object sender, RecordingStatusEventArgs e)
        {
            BeginInvoke(
                new Action(() =>
                {
                    switch (e.Status)
                    {
                        case RecorderStatus.Recording:
                            if (!sw.IsRunning)
                            {
                                sw.Start();
                            }
                            BtnStartRecorder.Text = "停止录制";
                            BtnPauseRecorder.Visible = true;
                            BtnPauseRecorder.Text = "暂停录制";
                            break;
                        case RecorderStatus.Paused:
                            if (sw.IsRunning)
                            {
                                sw.Stop();
                            }
                            BtnPauseRecorder.Text = "继续录制";
                            break;
                        case RecorderStatus.Finishing:
                            BtnPauseRecorder.Visible = false;
                            BtnStartRecorder.Text = "开始录制";

                            isRecording = false;
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
                    CleanupResources();

                    var btnRes = MessageBox.Show("是否打开视频目录？", "录制完成", MessageBoxButtons.YesNo);
                    if (btnRes == DialogResult.Yes)
                    {
                        Process.Start(Path.GetDirectoryName(filePath));
                    }
                })
            );
        }

        private void CleanupResources()
        {
            sw.Reset();
            sw.Stop();
            LblRecordDuration.Text = "00:00:00";
            recorder?.Dispose();
            recorder = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            settings = AppSettings.LoadConfig();
        }

        private void UpdateRecordDuration()
        {
            Task.Run(async () =>
            {
                while (isRecording)
                {
                    this.Invoke(
                        new Action(() =>
                        {
                            LblRecordDuration.Text = sw.Elapsed.ToString(@"hh\:mm\:ss");
                        })
                    );
                    await Task.Delay(500);
                }
            });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            recorder?.Stop();
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
            this.TopMost = false;

            var settingForm = new SettingForm();
            settingForm.ShowDialog();
            settings = settingForm.Settings;
            this.TopMost = true;
        }

        private void BtnDrawRect_Click(object sender, EventArgs e)
        {
            TopMost = false;
            var bmp = Utils.TakeScreenshot();

            var pop = new ScreenPop { BackgroundImage = bmp };
            pop.ShowDialog();

            var region = pop.SelectRegion;
            settings.ScreenRect = new Rect
            {
                Top = region.Y,
                Left = region.X,
                Width = region.Width,
                Height = region.Height
            };

            bmp.Dispose();
            TopMost = true;

            //截取区域后开始录制
            StartRecording();
        }

        private void BtnSnapshot_Click(object sender, EventArgs e)
        {
            recorder?.TakeSnapshot();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            var aboutForm = new AboutForm();
            aboutForm.Version = Utils.GetAppVersion();
            aboutForm.ShowDialog();
            this.TopMost = true;
        }
    }
}
