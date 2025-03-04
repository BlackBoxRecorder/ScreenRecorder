using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    public partial class MainForm : BaseForm
    {
        private volatile bool isRecording = false;
        private readonly Stopwatch sw = new Stopwatch();

        private Recorder recorder;
        private AppSettings settings = AppSettings.LoadConfig();

        public MainForm()
        {
            InitializeComponent();
            BtnPauseRecorder.Visible = false;
        }

        private void BtnStartRecorder_Click(object sender, EventArgs e)
        {
            StartRecording();
        }

        private void StartRecording()
        {
            if (isRecording)
            {
                recorder?.Stop();
                return;
            }

            try
            {
                CreateRecording();

                isRecording = true;
                sw.Restart(); //每次开始时，重置录制时长
                UpdateRecordDuration();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateRecording()
        {
            IntPtr hwnd = this.Handle;
            Recorder.SetExcludeFromCapture(hwnd, true);

            var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");

            if (!Directory.Exists(settings.SavePath))
            {
                Directory.CreateDirectory(settings.SavePath);
            }

            Directory.GetFiles(settings.SavePath); // 尝试读取文件列表，如果失败则没有权限

            var videoPath = Path.Combine(settings.SavePath, timestamp + ".mp4");

            var options = BuildOptions();
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
            var options = new RecorderOptions();

            options.SourceOptions = new SourceOptions
            {
                //Populate and pass a list of recordingsources.
                RecordingSources = Utils.GetVideoSourceByName(settings.VideoSourceName),
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
                ///Bitrate = AudioBitrate.bitrate_192kbps,
                ///Channels = AudioChannels.Mono,
                IsAudioEnabled = settings.EnableAudioInput || settings.EnableAudioOutput,
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

            var encoder = new H265VideoEncoder
            {
                BitrateMode = H265BitrateControlMode.Quality,
                EncoderProfile = H265Profile.Main,
            };

            options.VideoEncoderOptions = new VideoEncoderOptions
            {
                Bitrate = settings.VideoBitrate * 1000,
                Framerate = settings.VideoFramerate,
                Quality = 90,
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
                IsMp4FastStartEnabled = false,
            };

            options.SnapshotOptions = new SnapshotOptions
            {
                //Take a snapshot of the video output at the given interval
                SnapshotsWithVideo = false,
                SnapshotsIntervalMillis = 1000,
                //SnapshotFormat = ImageFormat.PNG,
                //Optional path to the directory to store snapshots in
                //If not configured, snapshots are stored in the same folder as video output.
                SnapshotsDirectory = "",
            };
            options.LogOptions = new LogOptions
            {
                //This enabled logging in release builds.
                IsLogEnabled = true,
                //If this path is configured, logs are redirected to this file.
                LogFilePath = "recorder.log",
                LogSeverityLevel = ScreenRecorderLib.LogLevel.Warn,
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
                                sw.Start(); //暂停录制后，继续录制时再开始计时
                            }

                            BtnPauseRecorder.Visible = true;

                            BtnStartRecorder.Text = "停止录制";
                            BtnPauseRecorder.Text = "暂停录制";

                            BtnDrawRect.Enabled = false;
                            BtnSettings.Enabled = false;

                            break;
                        case RecorderStatus.Paused:
                            if (sw.IsRunning)
                            {
                                sw.Stop();
                            }

                            BtnPauseRecorder.Visible = true;
                            BtnPauseRecorder.Text = "继续录制";

                            BtnDrawRect.Enabled = false;
                            BtnSettings.Enabled = false;

                            break;
                        case RecorderStatus.Finishing:
                            BtnStartRecorder.Text = "开始录制";
                            BtnPauseRecorder.Text = "暂停录制";
                            BtnPauseRecorder.Visible = false;

                            BtnDrawRect.Enabled = true;
                            BtnSettings.Enabled = true;

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
                    BtnPauseRecorder.Enabled = false;
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
                    var filePath = e.FilePath;
                    CleanupResources();

                    var btnRes = MessageBox.Show(
                        "是否打开视频目录？",
                        "录制完成",
                        MessageBoxButtons.YesNo
                    );
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
                    await Task.Delay(300);
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

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            var settingForm = new SettingForm();
            settingForm.ShowDialog();

            settings = AppSettings.LoadConfig();
        }

        private void BtnDrawRect_Click(object sender, EventArgs e)
        {
            if (isRecording)
            {
                return;
            }

            var bmp = Utils.TakeScreenshot(settings.VideoSourceName);

            if (bmp == null)
            {
                MessageBox.Show("选择区域时截图失败");
                return;
            }

            var pop = new ScreenPop { BackgroundImage = bmp };
            pop.ShowDialog();

            if (pop.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (pop.DialogResult == DialogResult.Abort)
            {
                MessageBox.Show("选择的区域太小，最小128x128");
                return;
            }

            var region = pop.SelectRegion;
            settings.ScreenRect = new Rect
            {
                Top = region.Y,
                Left = region.X,
                Width = region.Width,
                Height = region.Height,
            };

            bmp.Dispose();

            //截取区域后开始录制
            StartRecording();
        }

        private void BtnSnapshot_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                MessageBox.Show("开始录制后才能截图");
                return;
            }
            recorder?.TakeSnapshot();
        }
    }
}
