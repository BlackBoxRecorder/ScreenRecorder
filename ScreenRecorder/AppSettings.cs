using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ScreenRecorder.Properties;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    public class AppSettings
    {
        public static readonly string SettingFile = Path.Combine(
            Environment.CurrentDirectory,
            "settings.json"
        );

        public static AppSettings LoadConfig()
        {
            if (File.Exists(AppSettings.SettingFile))
            {
                var jsonStr = File.ReadAllText(AppSettings.SettingFile);
                return JsonConvert.DeserializeObject<AppSettings>(jsonStr);
            }

            return new AppSettings();
        }

        public static void SaveConfig(AppSettings settings)
        {
            File.WriteAllText(
                AppSettings.SettingFile,
                JsonConvert.SerializeObject(settings, Formatting.Indented)
            );
        }

        /// <summary>
        /// 录制的视频源类型，Monitor=0，Window=1，Camera=2
        /// </summary>
        public int VideoSourceTypeIndex { get; set; }

        /// <summary>
        /// 录制的视频源
        /// </summary>
        public string VideoSourceName { get; set; }

        /// <summary>
        /// 录制的视频区域，left，top，width，height
        /// </summary>
        public Rect ScreenRect { get; set; } =
            new Rect()
            {
                Left = 0,
                Top = 0,
                Width = Screen.PrimaryScreen.Bounds.Width,
                Height = Screen.PrimaryScreen.Bounds.Height
            };

        /// <summary>
        /// 输出的视频的分辨率，width，height
        /// </summary>
        public Size OutputFrameSize { get; set; } =
            new Size()
            {
                Width = Screen.PrimaryScreen.Bounds.Width,
                Height = Screen.PrimaryScreen.Bounds.Height
            };

        /// <summary>
        /// 视频水印，摄像头水印
        /// </summary>
        public string VideoOverlaysDevice { get; set; }

        /// <summary>
        /// 水印的大小，width，height
        /// </summary>
        public Size VideoOverlaysSize { get; set; } = new Size { Width = 256, Height = 0 };

        /// <summary>
        /// 水印位置偏移，width，height
        /// </summary>
        public Size VideoOverlaysOffset { get; set; } = new Size { Width = 0, Height = 0 };

        /// <summary>
        /// 水印位置偏移，width，height
        /// </summary>
        public int VideoOverlaysPositionIndex { get; set; }

        /// <summary>
        /// 启用视频水印
        /// </summary>
        public bool EnableOverlay { get; set; } = false;

        /// <summary>
        /// 视频的比特率
        /// </summary>
        public int VideoBitrate { get; set; } = 2000;

        /// <summary>
        /// 视频帧率
        /// </summary>
        public int VideoFramerate { get; set; } = 15;

        /// <summary>
        /// 是否为固定帧率
        /// </summary>
        public bool IsFixedFramerate { get; set; }

        /// <summary>
        /// 输出视频的编码器，H264/H265
        /// </summary>
        public int VideoEncoderIndex { get; set; }

        /// <summary>
        /// 视频的保存路径
        /// </summary>
        public string SavePath { get; set; } =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                "ScreenRecorder"
            );

        /// <summary>
        /// 录制时是否隐藏本程序窗口
        /// </summary>
        public bool HiddenMainWindow { get; set; } = true;

        /// <summary>
        /// 录制的视频质量
        /// </summary>
        public int VideoQualityIndex { get; set; } = 4;

        /// <summary>
        /// 启用音频输入，录制麦克风
        /// </summary>
        public bool EnableAudioInput { get; set; } = false;

        /// <summary>
        /// 启用音频输出，录制扬声器
        /// </summary>
        public bool EnableAudioOutput { get; set; } = false;

        /// <summary>
        /// 输入设备的名称，麦克风
        /// </summary>
        public string AudioInputDevice { get; set; }

        /// <summary>
        /// 输出设备的名称，扬声器
        /// </summary>
        public string AudioOutputDevice { get; set; }

        public bool EnableMousePoint { get; set; }
    }

    public static class ConfigOptions
    {
        public static string[] VideoQualityArray { get; set; } =
            new string[] { "30", "40", "50", "60", "70", "80", "90", "100" };

        public static string[] VideoEncoderArray { get; set; } = new string[] { "H264", "H265" };

        public static string[] OverlaysPositionArray { get; set; } =
            new string[] { "左上", "右上", "中间", "左下", "右下" };
    }

    public enum RecordingSourceType
    {
        [Description("显示器")]
        Monitor = 0,

        [Description("窗体")]
        Window = 1,

        [Description("摄像头")]
        Camera = 2
    }

    public struct Rect
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public struct Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
