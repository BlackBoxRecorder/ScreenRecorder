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
            BackgroundImageLayout = ImageLayout.Center;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);

            MinimizeBox = false;
            MaximizeBox = false;
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
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Cursor = Cursors.Cross;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (!isSelecting)
                return;

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

            Invalidate();
        }

        private void ScreenPop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            isSelecting = false;

            if (selectionRectangle.Width < 128 || selectionRectangle.Height < 128)
            {
                DialogResult = DialogResult.Abort;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }

            Close();
        }

        /// <summary>
        /// 截图后按ESC退出
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                Close();
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
