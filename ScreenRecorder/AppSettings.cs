using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    public class AppSettings
    {
        /// <summary>
        /// 录制的视频源类型，Window，Monitor，Camera
        /// </summary>
        public int VideoSourceTypeIndex { get; set; }

        /// <summary>
        /// 录制的视频源，ID
        /// </summary>
        public string VideoSourceName { get; set; }

        /// <summary>
        /// 录制的视频区域，left，top，width，height
        /// </summary>
        public (int, int, int, int) ScreenRect { get; set; } =
            (0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        /// <summary>
        /// 输出的视频的分辨率，width，height
        /// </summary>
        public (int, int) OutputFrameSize { get; set; } =
            (Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        /// <summary>
        /// 视频水印，摄像头水印
        /// </summary>
        public string VideoOverlaysDevice { get; set; }

        /// <summary>
        /// 水印的大小，width，height
        /// </summary>
        public (int, int) VideoOverlaysSize { get; set; } = (256, 0);

        /// <summary>
        /// 水印位置偏移，width，height
        /// </summary>
        public (int, int) VideoOverlaysOffset { get; set; } = (0, 0);

        /// <summary>
        /// 水印位置偏移，width，height
        /// </summary>
        public int VideoOverlaysPositionIndex { get; set; }

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

        /// <summary>
        /// 麦克风音量
        /// </summary>
        public int AudioInputVolume { get; set; } = 50;

        /// <summary>
        /// 扬声器音量
        /// </summary>
        public int AudioOutputVolume { get; set; } = 50;
    }

    public static class ConfigOptions
    {
        public static string[] VideoQualityArray { get; set; } =
            new string[] { "30", "40", "50", "60", "70", "80", "90", "100" };

        public static string[] VideoEncoderArray { get; set; } = new string[] { "H264", "H265" };

        public static string[] OverlaysPositionArray { get; set; } =
            new string[] { "左上", "右上", "中间", "左下", "右下" };
    }
}
