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

            TrbAudioInputVolumn.Minimum = 1;
            TrbAudioOutputVolumn.Minimum = 1;
            TrbAudioInputVolumn.Maximum = 100;
            TrbAudioOutputVolumn.Maximum = 100;

            //打开设置窗口后，设备顺序就固定了
            windowList = Recorder.GetWindows();
            monitorList = Recorder.GetDisplays();
            cameraList = Recorder.GetSystemVideoCaptureDevices();

            audioInputList = Recorder.GetSystemAudioDevices(AudioDeviceSource.InputDevices);
            audioOutputList = Recorder.GetSystemAudioDevices(AudioDeviceSource.OutputDevices);
        }

        public AppSettings Settings { get; private set; }

        private readonly List<RecordableWindow> windowList;
        private readonly List<RecordableCamera> cameraList;
        private readonly List<RecordableDisplay> monitorList;

        private readonly List<AudioDevice> audioInputList;
        private readonly List<AudioDevice> audioOutputList;

        private void SettingForm_Load(object sender, EventArgs e)
        {
            Settings = AppSettings.LoadConfig();
            foreach (var item in ConfigOptions.VideoEncoderArray)
            {
                CmbVideoEncoder.Items.Add(item);
            }
            CmbVideoEncoder.SelectedIndex = Settings.VideoEncoderIndex;

            foreach (RecordingSourceType type in Enum.GetValues(typeof(RecordingSourceType)))
            {
                var fieldInfo = type.GetType().GetField(type.ToString());
                var descriptionAttributes =
                    fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    as DescriptionAttribute[];

                if (descriptionAttributes.Length > 0)
                {
                    CmbRecordingSourceType.Items.Add(
                        new { Text = descriptionAttributes[0].Description, Value = type }
                    );
                }
                else
                {
                    CmbRecordingSourceType.Items.Add(new { Text = type.ToString(), Value = type });
                }
            }

            // 设置DisplayMember和ValueMember
            CmbRecordingSourceType.DisplayMember = "Text";
            CmbRecordingSourceType.ValueMember = "Value";
            CmbRecordingSourceType.SelectedIndex = Settings.VideoSourceTypeIndex;

            CmbVideoSource.SelectedIndex = GetVideoSourceIndexByNameAndType(
                Settings.VideoSourceName,
                (RecordingSourceType)Settings.VideoSourceTypeIndex
            );

            foreach (var cam in cameraList)
            {
                CmbOverlaysCamera.Items.Add(cam.FriendlyName);
            }
            CmbOverlaysCamera.SelectedIndex = GetVideoSourceIndexByNameAndType(
                Settings.VideoOverlaysDevice,
                RecordingSourceType.Camera
            );

            foreach (var item in ConfigOptions.VideoQualityArray)
            {
                CmbVideoQuality.Items.Add(item);
            }
            CmbVideoQuality.SelectedIndex = Settings.VideoQualityIndex;

            foreach (var item in ConfigOptions.OverlaysPositionArray)
            {
                CmbOverlaysPosition.Items.Add(item);
            }
            CmbOverlaysPosition.SelectedIndex = Settings.VideoOverlaysPositionIndex;

            RefreshAudioComboBoxes();

            UpdateUI(Settings);
        }

        private void UpdateUI(AppSettings settings)
        {
            TxtScreenRectX.Text = settings.ScreenRect.Left.ToString();
            TxtScreenRectY.Text = settings.ScreenRect.Top.ToString();
            TxtScreenRectW.Text = settings.ScreenRect.Width.ToString();
            TxtScreenRectH.Text = settings.ScreenRect.Height.ToString();

            TxtSavePath.Text = settings.SavePath;
            CkbHiddenWindow.Checked = settings.HiddenMainWindow;

            CkbEnableAudioInput.Checked = settings.EnableAudioInput;
            CkbEnableAudioOutput.Checked = settings.EnableAudioOutput;

            TrbAudioInputVolumn.Value = settings.AudioInputVolume;
            TrbAudioOutputVolumn.Value = settings.AudioOutputVolume;

            TxtBitrate.Text = settings.VideoBitrate.ToString();
            TxtFramerate.Text = settings.VideoFramerate.ToString();

            TxtOverlayWidth.Text = settings.VideoOverlaysSize.Width.ToString();
            TxtOverlayHeight.Text = settings.VideoOverlaysSize.Height.ToString();

            TxtOverlayWidthOffset.Text = settings.VideoOverlaysOffset.Width.ToString();
            TxtOverlayHeightOffset.Text = settings.VideoOverlaysOffset.Height.ToString();

            CmbOverlaysCamera.SelectedIndex = 0;

            CkbEnableOverlay.Checked = settings.EnableOverlay;
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.VideoEncoderIndex = CmbVideoEncoder.SelectedIndex;
            Settings.AudioInputDevice = CmbAudioInputDevice.SelectedItem as string;
            Settings.AudioOutputDevice = CmbAudioOutputDevice.SelectedItem as string;

            Settings.EnableAudioInput = CkbEnableAudioInput.Checked;
            Settings.EnableAudioOutput = CkbEnableAudioOutput.Checked;

            Settings.AudioInputVolume = (int)TrbAudioInputVolumn.Value;
            Settings.AudioOutputVolume = (int)TrbAudioOutputVolumn.Value;

            Settings.VideoSourceName = CmbVideoSource.SelectedItem as string;

            Settings.VideoSourceTypeIndex = CmbRecordingSourceType.SelectedIndex;

            Settings.SavePath = TxtSavePath.Text;

            Settings.VideoFramerate = int.Parse(TxtFramerate.Text);
            Settings.VideoBitrate = int.Parse(TxtBitrate.Text);

            Settings.HiddenMainWindow = CkbHiddenWindow.Checked;

            var rectX = int.Parse(TxtScreenRectX.Text);
            var rectY = int.Parse(TxtScreenRectY.Text);
            var rectW = int.Parse(TxtScreenRectW.Text);
            var rectH = int.Parse(TxtScreenRectH.Text);

            Settings.ScreenRect = new Rect()
            {
                Left = rectX,
                Top = rectY,
                Width = rectW,
                Height = rectH
            };
            Settings.OutputFrameSize = new Size() { Width = rectW, Height = rectH };

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

            AppSettings.SaveConfig(Settings);
        }

        /// <summary>
        /// 刷新音频输入输出设备
        /// </summary>
        private void RefreshAudioComboBoxes()
        {
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
        }

        private void CmbRecordingSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbVideoSource.Items.Clear();

            var type = (RecordingSourceType)CmbRecordingSourceType.SelectedIndex;

            switch (type)
            {
                case RecordingSourceType.Monitor:
                    foreach (var item in monitorList)
                    {
                        CmbVideoSource.Items.Add(item.FriendlyName);
                    }
                    break;
                case RecordingSourceType.Window:
                    foreach (var item in windowList)
                    {
                        CmbVideoSource.Items.Add(item.Title);
                    }
                    break;
                case RecordingSourceType.Camera:
                    foreach (var item in cameraList)
                    {
                        CmbVideoSource.Items.Add(item.FriendlyName);
                    }
                    break;
                default:
                    break;
            }

            if (CmbVideoSource.Items.Count > 0)
            {
                CmbVideoSource.SelectedIndex = 0;
            }
        }

        //通过配置文件中的设备名称，获取到 Index

        private int GetVideoSourceIndexByNameAndType(string name, RecordingSourceType type)
        {
            switch (type)
            {
                case RecordingSourceType.Monitor:
                    for (int i = 0; i < monitorList.Count; i++)
                    {
                        if (name == monitorList[i].FriendlyName)
                        {
                            return i;
                        }
                    }
                    break;
                case RecordingSourceType.Window:
                    for (int i = 0; i < windowList.Count; i++)
                    {
                        if (name == windowList[i].Title)
                        {
                            return i;
                        }
                    }
                    break;
                case RecordingSourceType.Camera:
                    for (int i = 0; i < cameraList.Count; i++)
                    {
                        if (name == cameraList[i].FriendlyName)
                        {
                            return i;
                        }
                    }
                    break;
                default:
                    break;
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
    }
}
