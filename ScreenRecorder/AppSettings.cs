using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            if (File.Exists(SettingFile))
            {
                var jsonStr = File.ReadAllText(SettingFile);
                return JsonConvert.DeserializeObject<AppSettings>(jsonStr);
            }

            return new AppSettings();
        }

        public static void SaveConfig(AppSettings settings)
        {
            File.WriteAllText(
                SettingFile,
                JsonConvert.SerializeObject(settings, Formatting.Indented)
            );
        }

        /// <summary>
        /// 录制的视频源
        /// </summary>
        public string VideoSourceName { get; set; }

        /// <summary>
        /// 录制的视频区域，left，top，width，height
        /// 默认主显示器全屏
        /// </summary>
        public Rect ScreenRect { get; set; } =
            new Rect()
            {
                Left = 0,
                Top = 0,
                Width = Screen.PrimaryScreen.Bounds.Width,
                Height = Screen.PrimaryScreen.Bounds.Height,
            };

        /// <summary>
        /// 视频的比特率
        /// </summary>
        public int VideoBitrate { get; private set; } = 2000;

        /// <summary>
        /// 视频帧率
        /// </summary>
        public int VideoFramerate { get; private set; } = 25;

        /// <summary>
        /// 视频的保存路径
        /// </summary>
        public string SavePath { get; set; } =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
                "ScreenRecorder"
            );

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
