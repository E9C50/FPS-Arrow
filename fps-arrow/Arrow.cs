using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using fps_arrow.Properties;

namespace fps_arrow
{
    public partial class Arrow : Form
    {

        public Arrow()
        {
            InitializeComponent();
            this.ResetWindowPosition();
        }
        private void ResetWindowPosition()
        {
            int x = Settings.Default.OffsetX;
            int y = Settings.Default.OffsetY;
            Screen screen = Screen.AllScreens[Settings.Default.Screen];
            this.Left = (screen.Bounds.Width - this.Width) / 2 + x;
            this.Top = (screen.Bounds.Height - this.Height) / 2 + y;
            this.Size = new Size(screen.Bounds.Width, screen.Bounds.Height);
            this.Location = new Point(screen.Bounds.X-1, screen.Bounds.Y);
            Console.WriteLine(this.Left);
            Console.WriteLine(this.Top);
            Console.WriteLine(screen.Bounds.X);
            Console.WriteLine(screen.Bounds.Y);
        }

        private void Arrow_Load(object sender, EventArgs e)
        {
            // 在任务栏不显示      
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.SetWinTop();
            this.SetWindowMouseThrough();
            this.SetWindowTransparent();

        }

        private void SetWindowTransparent()
        {
            // 图片的背景色和窗口的透明色一致
            Color color = Color.Blue;
            this.pictureBox.BackColor = color;
            this.TransparencyKey = color;

            // 图片的大小和窗口大小一致
            this.pictureBox.Width = this.Width;
            this.pictureBox.Height = this.Height;
            this.pictureBox.Location = new Point(0, 0);
        }

        public void OnRefresh()
        {
            Console.WriteLine("OnRefresh");
            this.pictureBox.Invalidate();
        }

        private Color color = Color.Red;// 绘制的颜色

        private void DrawBoarder(Graphics graphics)
        {

            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            Pen pen = new Pen(color, Settings.Default.BorderLineWidth);

            int distance = Settings.Default.BorderLineDistance;
            int len = Settings.Default.BorderLineLen;
            Point[] points =  {
                new Point(-distance, -len / 2), new Point(-distance, len / 2),// left
                new Point(distance, -len / 2), new Point(distance, len / 2),//right
                new Point(-len / 2, distance), new Point(len / 2, distance),//top
                new Point(-len / 2, -distance), new Point(len / 2, -distance),//bottom
            };

            for (int i = 0; i < points.Length; i++)
            {
                Point point = points[i];
                point.X += centerX;
                point.Y += centerY;
                points[i] = point;
            }
            for (int i = 0; i < points.Length;)
            {
                graphics.DrawLine(pen, points[i++], points[i++]);
            }

        }

        // 注意调用时机
        private void DrawArrow(Graphics graphics)
        {
            Console.WriteLine("draw arrow");
            color = Color.FromName(Settings.Default.Color);

            this.Opacity = Settings.Default.Opacity / 100.0;
            this.ResetWindowPosition();

            graphics.Clear(this.TransparencyKey);
            int arrowLen = Settings.Default.LineLen;
            int lineWidth = Settings.Default.LineWidth;
            Pen pen = new Pen(color, lineWidth);

            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            // 准星的4条线
            int arrowCenterSpace = Settings.Default.LineSpace;// 准星中心空隙

            int left = centerX - arrowCenterSpace;
            graphics.DrawLine(pen, new Point(left, centerY), new Point(left - arrowLen, centerY));

            int right = centerX + arrowCenterSpace;
            graphics.DrawLine(pen, new Point(right, centerY), new Point(right + arrowLen, centerY));

            int top = centerY - arrowCenterSpace;
            graphics.DrawLine(pen, new Point(centerX, top), new Point(centerX, top - arrowLen));

            int bottom = centerY + arrowCenterSpace;
            graphics.DrawLine(pen, new Point(centerX, bottom), new Point(centerX, bottom + arrowLen));

            // 准星的边框
            this.DrawBoarder(graphics);

            // 中心点
            int radius = Settings.Default.PointRadius;
            Pen pointPen = new Pen(color, Settings.Default.PointWidth);
            graphics.DrawEllipse(pointPen, centerX - radius / 2, centerY - radius / 2, radius, radius);
            if (Settings.Default.PointFill)
            {
                Brush brush = new SolidBrush(color);
                graphics.FillEllipse(brush, centerX - radius / 2, centerY - radius / 2, radius, radius);
            }
        }
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);


        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);

        private const uint WS_EX_LAYERED = 0x80000;
        private const int GWL_EXSTYLE = -20; // 设置一个新的扩展风格
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int LWA_ALPHA = 0x2;

        // 设置窗体可以被鼠标穿透
        private void SetWindowMouseThrough()
        {
            GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
        }
        private void SetWinTop()
        {
            SetWindowPos(this.Handle, -1, 0, 0, 0, 0, 1 | 2);
        }

        private void OnTimer(object sender, EventArgs e)
        {

        }

        private void OnWindowPaint(object sender, PaintEventArgs e)
        {
            this.DrawArrow(e.Graphics);
        }
    }
}
