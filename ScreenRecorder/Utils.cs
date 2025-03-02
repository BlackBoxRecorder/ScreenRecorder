using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    internal static class Utils
    {
        /// <summary>
        /// 截取指定显示器的截图
        /// </summary>
        /// <returns></returns>
        public static Bitmap TakeScreenshot(string monitorName)
        {
            try
            {
                var deviceName = GetDeviceNameByMonitorFirendlyName(monitorName);

                var screen = Array.Find(Screen.AllScreens, s => s.DeviceName == deviceName);
                if (screen == null)
                {
                    return null;
                }

                Rectangle bounds = screen.Bounds;
                Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);
                using (Graphics g = Graphics.FromImage(screenshot))
                {
                    g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
                }
                return screenshot;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        /// <summary>
        /// 根据显示器的友好名称，获取录制视频源
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<RecordingSourceBase> GetVideoSourceByName(string name)
        {
            var src = new List<RecordingSourceBase>();

            foreach (var monitor in Recorder.GetDisplays())
            {
                if (monitor.FriendlyName == name)
                {
                    src.Add(monitor);
                    break;
                }
            }

            return src;
        }

        public static string GetDeviceNameByMonitorFirendlyName(string name)
        {
            foreach (var monitor in Recorder.GetDisplays())
            {
                if (monitor.FriendlyName == name)
                {
                    return monitor.DeviceName;
                }
            }

            return "";
        }

        /// <summary>
        /// 获取指定显示器的分辨率
        /// </summary>
        /// <param name="deviceName"></param>
        /// <returns></returns>
        public static Size GetMonitorResolution(string deviceName)
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.DeviceName == deviceName)
                {
                    return new Size()
                    {
                        Height = screen.Bounds.Height,
                        Width = screen.Bounds.Width,
                    };
                }
            }

            return new Size();
        }
    }
}
