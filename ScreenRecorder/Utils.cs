using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    internal static class Utils
    {
        public static Bitmap TakeScreenshot()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
            }
            return screenshot;
        }

        public static Bitmap CloneBitmapRegion(Bitmap sourceBitmap, Rectangle sourceRegion)
        {
            // 确保指定的区域在Bitmap的边界内
            if (
                sourceRegion.Width <= 0
                || sourceRegion.Height <= 0
                || sourceRegion.X < 0
                || sourceRegion.Y < 0
                || sourceRegion.X + sourceRegion.Width > sourceBitmap.Width
                || sourceRegion.Y + sourceRegion.Height > sourceBitmap.Height
            )
            {
                throw new ArgumentException("指定的矩形区域无效或超出Bitmap边界。");
            }

            // 复制指定区域的Bitmap
            Bitmap clonedBitmap = sourceBitmap.Clone(sourceRegion, sourceBitmap.PixelFormat);

            return clonedBitmap;
        }

        public static List<RecordingSourceBase> GetVideoSourceByName(
            RecordingSourceType type,
            string name
        )
        {
            var src = new List<RecordingSourceBase>();

            switch (type)
            {
                case RecordingSourceType.Monitor:
                    foreach (var monitor in Recorder.GetDisplays())
                    {
                        if (monitor.FriendlyName == name)
                        {
                            src.Add(monitor);
                            break;
                        }
                    }
                    break;
                case RecordingSourceType.Window:
                    foreach (var window in Recorder.GetWindows())
                    {
                        if (
                            window.IsValidWindow()
                            && window.IsVideoCaptureEnabled
                            && window.Title == name
                        )
                        {
                            src.Add(window);
                            break;
                        }
                    }
                    break;
                case RecordingSourceType.Camera:
                    foreach (var device in Recorder.GetSystemVideoCaptureDevices())
                    {
                        if (device.FriendlyName == name)
                        {
                            src.Add(device);
                        }
                    }
                    break;
                default:
                    break;
            }

            return src;
        }

        public static string GetAppVersion()
        {
            string date = "";
            string hash = "";
            string branch = "";

            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var gitVersionInformationType = assembly.GetType("GitVersionInformation");
                var fields = gitVersionInformationType.GetFields();

                foreach (var field in fields)
                {
                    if (field.Name == "CommitDate")
                    {
                        date = field.GetValue(null).ToString();
                    }
                    if (field.Name == "ShortSha")
                    {
                        hash = field.GetValue(null).ToString();
                    }
                    if (field.Name == "SemVer")
                    {
                        branch = field.GetValue(null).ToString();
                    }
                }
                return $"{branch}-{hash} @{date}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "";
            }
        }
    }
}
