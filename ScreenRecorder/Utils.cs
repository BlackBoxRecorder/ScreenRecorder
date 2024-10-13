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

        public static Size GetMonitorResolution(string deviceName)
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.DeviceName == deviceName)
                {
                    return new Size()
                    {
                        Height = screen.Bounds.Height,
                        Width = screen.Bounds.Width
                    };
                }
            }

            return new Size();
        }
    }
}
