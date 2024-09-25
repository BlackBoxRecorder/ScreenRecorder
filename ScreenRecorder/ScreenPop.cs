using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenRecorder
{
    public partial class ScreenPop : Form
    {
        public ScreenPop()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MinimizeBox = false;
            MaximizeBox = false;
            Text = "预览";
        }

        private Point startPoint; // 矩形的起始点
        private Rectangle selectionRectangle; // 用户绘制的矩形区域
        private bool isSelecting; // 是否正在绘制矩形

        public Rectangle SelectRegion
        {
            get { return selectionRectangle; }
        }

        private void ScreenPop_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Center;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.Cursor = Cursors.Cross;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Red, 4))
            {
                e.Graphics.DrawRectangle(pen, selectionRectangle);
            }
        }

        private void ScreenPop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isSelecting = true;
            }
        }

        private void ScreenPop_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isSelecting)
                return;

            int width = Math.Abs(e.X - startPoint.X);
            int height = Math.Abs(e.Y - startPoint.Y);
            int x = Math.Min(e.X, startPoint.X);
            int y = Math.Min(e.Y, startPoint.Y);

            selectionRectangle = new Rectangle(x, y, width, height);
            this.Invalidate();
        }

        private void ScreenPop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            isSelecting = false;
            var bmp = this.BackgroundImage as Bitmap;
            var rect = Utils.CloneBitmapRegion(bmp, selectionRectangle);
            this.BackgroundImage = rect;
            bmp.Dispose();

            this.Width = rect.Width;
            this.Height = rect.Height;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = $"预览 分辨率：{Width}x{Height}";
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
