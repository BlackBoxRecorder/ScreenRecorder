using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Newtonsoft.Json;
using ScreenRecorder.Properties;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            //打开设置窗口后，设备顺序就固定了
            monitorList = Recorder.GetDisplays();
            cameraList = Recorder.GetSystemVideoCaptureDevices();

            audioInputList = Recorder.GetSystemAudioDevices(AudioDeviceSource.InputDevices);
            audioOutputList = Recorder.GetSystemAudioDevices(AudioDeviceSource.OutputDevices);
        }

        public AppSettings Settings { get; private set; }

        private readonly List<RecordableCamera> cameraList;
        private readonly List<RecordableDisplay> monitorList;

        private readonly List<AudioDevice> audioInputList;
        private readonly List<AudioDevice> audioOutputList;

        private void SettingForm_Load(object sender, EventArgs e)
        {
            Settings = AppSettings.LoadConfig();

            UpdateUI();
        }

        private void UpdateUI()
        {
            //视频编码
            foreach (var item in ConfigOptions.VideoEncoderArray)
            {
                CmbVideoEncoder.Items.Add(item);
            }
            CmbVideoEncoder.SelectedIndex = Settings.VideoEncoderIndex;

            //显示器名称
            foreach (var item in monitorList)
            {
                CmbVideoSource.Items.Add(item.FriendlyName);
            }
            CmbVideoSource.SelectedIndex = GetVideoSourceIndexByName(Settings.VideoSourceName);

            //摄像头名称
            foreach (var cam in cameraList)
            {
                CmbOverlaysCamera.Items.Add(cam.FriendlyName);
            }
            CmbOverlaysCamera.SelectedIndex = GetVideoSourceIndexByName(
                Settings.VideoOverlaysDevice
            );

            //视频质量
            foreach (var item in ConfigOptions.VideoQualityArray)
            {
                CmbVideoQuality.Items.Add(item);
            }
            CmbVideoQuality.SelectedIndex = Settings.VideoQualityIndex;

            //摄像头水印位置
            foreach (var item in ConfigOptions.OverlaysPositionArray)
            {
                CmbOverlaysPosition.Items.Add(item);
            }
            CmbOverlaysPosition.SelectedIndex = Settings.VideoOverlaysPositionIndex;

            TxtSavePath.Text = Settings.SavePath;
            CkbHiddenWindow.Checked = Settings.HiddenMainWindow;

            TxtBitrate.Text = Settings.VideoBitrate.ToString();
            TxtFramerate.Text = Settings.VideoFramerate.ToString();

            TxtOverlayWidth.Text = Settings.VideoOverlaysSize.Width.ToString();
            TxtOverlayHeight.Text = Settings.VideoOverlaysSize.Height.ToString();

            TxtOverlayWidthOffset.Text = Settings.VideoOverlaysOffset.Width.ToString();
            TxtOverlayHeightOffset.Text = Settings.VideoOverlaysOffset.Height.ToString();

            CmbOverlaysCamera.SelectedIndex = 0;

            CkbEnableOverlay.Checked = Settings.EnableOverlay;

            #region 音频

            CkbEnableAudioInput.Checked = Settings.EnableAudioInput;
            CkbEnableAudioOutput.Checked = Settings.EnableAudioOutput;

            CmbAudioOutputDevice.Items.Clear();
            CmbAudioInputDevice.Items.Clear();

            foreach (var outputDevice in audioOutputList)
            {
                CmbAudioOutputDevice.Items.Add(outputDevice.FriendlyName);
            }
            foreach (var inputDevice in audioInputList)
            {
                CmbAudioInputDevice.Items.Add(inputDevice.FriendlyName);
            }

            if (CmbAudioInputDevice.Items.Count > 0)
            {
                CmbAudioInputDevice.SelectedIndex = GetAudioSourceIndexByName(
                    Settings.AudioInputDevice,
                    AudioDeviceSource.InputDevices
                );
            }
            if (CmbAudioOutputDevice.Items.Count > 0)
            {
                CmbAudioOutputDevice.SelectedIndex = GetAudioSourceIndexByName(
                    Settings.AudioOutputDevice,
                    AudioDeviceSource.OutputDevices
                );
            }
            #endregion
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.VideoEncoderIndex = CmbVideoEncoder.SelectedIndex;
            Settings.AudioInputDevice = CmbAudioInputDevice.SelectedItem as string;
            Settings.AudioOutputDevice = CmbAudioOutputDevice.SelectedItem as string;

            Settings.EnableAudioInput = CkbEnableAudioInput.Checked;
            Settings.EnableAudioOutput = CkbEnableAudioOutput.Checked;

            Settings.VideoSourceName = CmbVideoSource.SelectedItem as string;

            Settings.SavePath = TxtSavePath.Text;

            Settings.VideoFramerate = int.Parse(TxtFramerate.Text);
            Settings.VideoBitrate = int.Parse(TxtBitrate.Text);

            Settings.HiddenMainWindow = CkbHiddenWindow.Checked;

            if (CmbVideoQuality.SelectedIndex > 0)
            {
                Settings.VideoQualityIndex = CmbVideoQuality.SelectedIndex;
            }
            else
            {
                Settings.VideoQualityIndex = 0;
            }

            Settings.VideoOverlaysPositionIndex = CmbOverlaysPosition.SelectedIndex;
            Settings.VideoOverlaysDevice = CmbOverlaysCamera.SelectedItem as string;

            int ovOffsetW = int.Parse(TxtOverlayWidthOffset.Text);
            int ovOffsetH = int.Parse(TxtOverlayHeightOffset.Text);
            Settings.VideoOverlaysOffset = new Size() { Width = ovOffsetW, Height = ovOffsetH };

            int ovW = int.Parse(TxtOverlayWidth.Text);
            int ovH = int.Parse(TxtOverlayHeight.Text);
            Settings.VideoOverlaysSize = new Size() { Width = ovW, Height = ovH };

            Settings.EnableOverlay = CkbEnableOverlay.Checked;
            Settings.EnableMousePoint = CkbEnableMousePoint.Checked;

            AppSettings.SaveConfig(Settings);
        }

        private int GetVideoSourceIndexByName(string name)
        {
            for (int i = 0; i < monitorList.Count; i++)
            {
                if (name == monitorList[i].FriendlyName)
                {
                    return i;
                }
            }

            return -1;
        }

        private int GetAudioSourceIndexByName(string name, AudioDeviceSource type)
        {
            switch (type)
            {
                case AudioDeviceSource.InputDevices:
                    for (int i = 0; i < audioInputList.Count; i++)
                    {
                        if (name == audioInputList[i].FriendlyName)
                        {
                            return i;
                        }
                    }
                    break;
                case AudioDeviceSource.OutputDevices:
                    for (int i = 0; i < audioOutputList.Count; i++)
                    {
                        if (name == audioOutputList[i].FriendlyName)
                        {
                            return i;
                        }
                    }
                    break;
                case AudioDeviceSource.All:
                    break;
                default:
                    break;
            }

            return -1;
        }

        /// <summary>
        /// 选择视频保存目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "请选择一个文件夹",
                ShowNewFolderButton = true // 是否显示新建文件夹按钮
            };
            DialogResult result = folderBrowserDialog.ShowDialog();

            var path = folderBrowserDialog.SelectedPath;
            if (
                result == DialogResult.OK
                && !string.IsNullOrWhiteSpace(path)
                && Directory.Exists(path)
            )
            {
                TxtSavePath.Text = path;
            }
        }

        private void CmbVideoSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取显示器的最大分辨率
            if (CmbVideoSource.SelectedItem is string monitorName)
            {
                foreach (var item in monitorList)
                {
                    if (item.FriendlyName == monitorName)
                    {
                        var size = Utils.GetMonitorResolution(item.DeviceName);

                        Settings.ScreenRect = new Rect()
                        {
                            Left = 0,
                            Top = 0,
                            Width = size.Width,
                            Height = size.Height
                        };
                    }
                }
            }
        }
    }
}
