using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
