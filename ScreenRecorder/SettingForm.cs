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
        }

        private readonly string settingFile = Path.Combine(
            Environment.CurrentDirectory,
            "settings.json"
        );

        private readonly string[] VideoQualityArray = new string[]
        {
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"
        };

        public AppSettings Settings { get; private set; }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            //读取配置文件，填入界面控件
            if (!File.Exists(settingFile))
            {
                File.WriteAllText(settingFile, JsonConvert.SerializeObject(new AppSettings()));
                return;
            }

            var jsonStr = File.ReadAllText(settingFile);
            Settings = JsonConvert.DeserializeObject<AppSettings>(jsonStr);

            CmbVideoEncoder.Items.Add("H264");
            CmbVideoEncoder.Items.Add("H265");
            CmbVideoEncoder.SelectedIndex = 0;

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
            CmbRecordingSourceType.SelectedIndex = 0;

            var camera = Recorder.GetSystemVideoCaptureDevices();
            foreach (var cam in camera)
            {
                CmbOverlaysCamera.Items.Add(cam.DeviceName);
            }
            CmbOverlaysCamera.SelectedIndex = 0;

            foreach (var item in VideoQualityArray)
            {
                CmbVideoQuality.Items.Add(item);
            }
            CmbVideoQuality.SelectedIndex = 4;

            CmbOverlaysPosition.Items.Add("左上");
            CmbOverlaysPosition.Items.Add("左下");
            CmbOverlaysPosition.Items.Add("右上");
            CmbOverlaysPosition.Items.Add("右下");
            CmbOverlaysPosition.SelectedIndex = 0;

            RefreshAudioComboBoxes();

            UpdateUI(Settings);
        }

        private void UpdateUI(AppSettings settings)
        {
            TxtScreenRectX.Text = settings.ScreenRect.Item1.ToString();
            TxtScreenRectY.Text = settings.ScreenRect.Item2.ToString();
            TxtScreenRectW.Text = settings.ScreenRect.Item3.ToString();
            TxtScreenRectH.Text = settings.ScreenRect.Item4.ToString();

            TxtSavePath.Text = settings.SavePath;
            CkbHiddenWindow.Checked = settings.HiddenMainWindow;

            CkbEnableAudioInput.Checked = settings.EnableAudioInput;
            CkbEnableAudioOutput.Checked = settings.EnableAudioOutput;

            TrbAudioInputVolumn.Value = settings.AudioInputVolume;
            TrbAudioOutputVolumn.Value = settings.AudioOutputVolume;
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.VideoEncoder = CmbVideoEncoder.SelectedItem as string;
            Settings.AudioInputDevice = CmbAudioInputDevice.SelectedItem as string;
            Settings.AudioOutputDevice = CmbAudioOutputDevice.SelectedItem as string;

            Settings.EnableAudioInput = CkbEnableAudioInput.Checked;
            Settings.EnableAudioOutput = CkbEnableAudioOutput.Checked;

            Settings.VideoSourceName = CmbVideoSource.SelectedItem as string;

            Settings.VideoSourceType = (RecordingSourceType)CmbRecordingSourceType.SelectedIndex;

            Settings.SavePath = TxtSavePath.Text;

            Settings.VideoFramerate = int.Parse(TxtFramerate.Text);
            Settings.VideoBitrate = int.Parse(TxtBitrate.Text);

            Settings.HiddenMainWindow = CkbHiddenWindow.Checked;

            var rectX = int.Parse(TxtScreenRectX.Text);
            var rectY = int.Parse(TxtScreenRectY.Text);
            var rectW = int.Parse(TxtScreenRectW.Text);
            var rectH = int.Parse(TxtScreenRectH.Text);

            Settings.ScreenRect = (rectX, rectY, rectW, rectH);
            Settings.OutputFrameSize = (rectW, rectH);

            if (CmbVideoQuality.SelectedIndex > 0)
            {
                Settings.VideoQuality = int.Parse(CmbVideoQuality.SelectedItem as string);
            }
            else
            {
                Settings.VideoQuality = 0;
            }

            Settings.VideoOverlaysPosition = ScreenRecorderLib.Anchor.TopLeft;
            Settings.VideoOverlaysDevice = CmbOverlaysCamera.SelectedItem as string;
            Settings.VideoOverlaysOffset = (
                Settings.VideoOverlaysOffset.Item1,
                Settings.VideoOverlaysOffset.Item2
            );
            Settings.VideoOverlaysSize = (
                Settings.VideoOverlaysSize.Item1,
                Settings.VideoOverlaysSize.Item2
            );
        }

        /// <summary>
        /// 刷新音频输入输出设备
        /// </summary>
        private void RefreshAudioComboBoxes()
        {
            CmbAudioOutputDevice.Items.Clear();
            CmbAudioInputDevice.Items.Clear();
            var outDevices = Recorder.GetSystemAudioDevices(AudioDeviceSource.OutputDevices);
            var inDevice = Recorder.GetSystemAudioDevices(AudioDeviceSource.InputDevices);

            foreach (var outputDevice in outDevices)
            {
                CmbAudioOutputDevice.Items.Add(outputDevice.FriendlyName);
            }
            foreach (var inputDevice in inDevice)
            {
                CmbAudioInputDevice.Items.Add(inputDevice.FriendlyName);
            }

            if (CmbAudioInputDevice.Items.Count > 0)
            {
                CmbAudioInputDevice.SelectedIndex = 0;
            }
            if (CmbAudioOutputDevice.Items.Count > 0)
            {
                CmbAudioOutputDevice.SelectedIndex = 0;
            }
        }

        private void CmbRecordingSourceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbVideoSource.Items.Clear();

            var type = (RecordingSourceType)CmbRecordingSourceType.SelectedIndex;

            switch (type)
            {
                case RecordingSourceType.Monitor:
                    foreach (var item in Recorder.GetDisplays())
                    {
                        CmbVideoSource.Items.Add(item.FriendlyName);
                    }
                    break;
                case RecordingSourceType.Window:
                    foreach (var item in Recorder.GetWindows())
                    {
                        CmbVideoSource.Items.Add(item.Title);
                    }
                    break;
                case RecordingSourceType.Camera:
                    foreach (var item in Recorder.GetSystemVideoCaptureDevices())
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
    }
}
