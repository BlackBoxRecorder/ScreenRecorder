using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            audioInputList = Recorder.GetSystemAudioDevices(AudioDeviceSource.InputDevices);
            audioOutputList = Recorder.GetSystemAudioDevices(AudioDeviceSource.OutputDevices);
        }

        public AppSettings Settings { get; private set; }

        private readonly List<RecordableDisplay> monitorList;

        private readonly List<AudioDevice> audioInputList;
        private readonly List<AudioDevice> audioOutputList;

        private void SettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                Settings = AppSettings.LoadConfig();

                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateUI()
        {
            //显示器名称
            foreach (var item in monitorList)
            {
                CmbVideoSource.Items.Add(item.FriendlyName);
            }

            if (CmbVideoSource.Items.Count > 0)
            {
                CmbVideoSource.SelectedIndex = GetVideoSourceIndexByName(Settings.VideoSourceName);
            }

            TxtSavePath.Text = Settings.SavePath;

            #region 音频

            if (audioInputList.Count < 1)
            {
                CkbEnableAudioInput.Checked = false;
                CkbEnableAudioInput.Enabled = false;
                CmbAudioInputDevice.Enabled = false;
            }
            else
            {
                CkbEnableAudioInput.Checked = Settings.EnableAudioInput;

                CmbAudioInputDevice.Items.Clear();

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
            }

            if (audioOutputList.Count < 1)
            {
                CkbEnableAudioOutput.Checked = false;
                CkbEnableAudioOutput.Enabled = false;
                CmbAudioOutputDevice.Enabled = false;
            }
            else
            {
                CkbEnableAudioOutput.Checked = Settings.EnableAudioOutput;
                CmbAudioOutputDevice.Items.Clear();
                foreach (var outputDevice in audioOutputList)
                {
                    CmbAudioOutputDevice.Items.Add(outputDevice.FriendlyName);
                }

                if (CmbAudioOutputDevice.Items.Count > 0)
                {
                    CmbAudioOutputDevice.SelectedIndex = GetAudioSourceIndexByName(
                        Settings.AudioOutputDevice,
                        AudioDeviceSource.OutputDevices
                    );
                }
            }

            #endregion
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.AudioInputDevice = CmbAudioInputDevice.SelectedValue as string;
            Settings.AudioOutputDevice = CmbAudioOutputDevice.SelectedValue as string;

            Settings.EnableAudioInput = CkbEnableAudioInput.Checked;
            Settings.EnableAudioOutput = CkbEnableAudioOutput.Checked;

            Settings.VideoSourceName = CmbVideoSource.SelectedValue as string;

            Settings.SavePath = TxtSavePath.Text;

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

            return 0;
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

            return 0;
        }

        /// <summary>
        /// 选择视频保存目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectSavePath_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog
            {
                Description = "请选择一个文件夹",
                ShowNewFolderButton = true, // 是否显示新建文件夹按钮
            };

            var result = fbd.ShowDialog();
            var path = fbd.SelectedPath;

            if (
                result == DialogResult.OK
                && !string.IsNullOrWhiteSpace(path)
                && Directory.Exists(path)
            )
            {
                TxtSavePath.Text = path;
            }
        }

        private void CkbEnableAudioInput_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            CkbEnableAudioInput.Enabled = e.Value;
        }

        private void CkbEnableAudioOutput_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            CkbEnableAudioOutput.Enabled = e.Value;
        }

        private void CmbVideoSource_SelectedIndexChanged(object sender, AntdUI.IntEventArgs e)
        {
            //获取显示器的最大分辨率
            if (CmbVideoSource.SelectedValue is string monitorName)
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
                            Height = size.Height,
                        };
                    }
                }
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = $"https://github.com/BlackBoxRecorder/ScreenRecorder";
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }
    }
}
