using System;
using System.Drawing;
using System.Windows.Forms;
using fps_arrow.Properties;
using System.Configuration;

namespace fps_arrow
{
    public partial class Form1 : Form
    {
        private Arrow arrowWin = null;
        public Form1()
        {
            InitializeComponent();
            this.ReadConfig();
        }
        private void ReadConfig()
        {
            // 从配置中读取
            this.offsetX.Value = Settings.Default.OffsetX;
            this.offsetY.Value = Settings.Default.OffsetY;
            this.opacity.Value = Settings.Default.Opacity;
            this.colorButton.BackColor = Color.FromName(Settings.Default.Color);

            this.lineWidth.Value = Settings.Default.LineWidth;
            this.lineLen.Value = Settings.Default.LineLen;
            this.lineSpace.Value = Settings.Default.LineSpace;

            this.borderLineDistance.Value = Settings.Default.BorderLineDistance;
            this.borderLineWidth.Value = Settings.Default.BorderLineWidth;
            this.borderLineLen.Value = Settings.Default.BorderLineLen;

            this.pointRadius.Value = Settings.Default.PointRadius;
            this.pointFill.Checked = Settings.Default.PointFill;
            int pointWidth = Settings.Default.PointWidth;
            if (pointWidth <= 1)
            {
                pointWidth = 1;
            }
            this.pointWidth.Value = pointWidth;

            if (Settings.Default.Screen == 1)
            {
                this.screen2.Checked = true;
            }
            else
            {
                this.screen1.Checked = true;
            }
        }
        private void SaveConfig()
        {
            Settings.Default.OffsetX = (int)this.offsetX.Value;
            Settings.Default.OffsetY = (int)this.offsetY.Value;
            Settings.Default.Opacity = this.opacity.Value;
            Settings.Default.Color = this.colorButton.BackColor.Name;

            Settings.Default.LineLen = (int)this.lineLen.Value;
            Settings.Default.LineWidth = (int)this.lineWidth.Value;
            Settings.Default.LineSpace = (int)this.lineSpace.Value;

            Settings.Default.BorderLineLen = (int)this.borderLineLen.Value;
            Settings.Default.BorderLineWidth = (int)this.borderLineWidth.Value;
            Settings.Default.BorderLineDistance = (int)this.borderLineDistance.Value;

            Settings.Default.PointRadius = (int)this.pointRadius.Value;
            Settings.Default.PointWidth = (int)this.pointWidth.Value;
            Settings.Default.PointFill = this.pointFill.Checked;

            if (this.screen1.Checked)
            {
                Settings.Default.Screen = 0;
            }
            else if (this.screen2.Checked)
            {
                Settings.Default.Screen = 1;
            }

            Settings.Default.Save();
        }

        private void OnRunButtonClick(object sender, EventArgs e)
        {
            if (this.arrowWin != null)
            {
                this.CloseArrowWindow();
            }
            else
            {
                this.SaveConfig();
                this.CreateArrowWindow();
            }
        }

        private void CreateArrowWindow()
        {
            this.CloseArrowWindow();
            this.arrowWin = new Arrow();
            this.arrowWin.Show();
            this.runButton.Text = "关闭准星(ESC)";
        }
        private void CloseArrowWindow()
        {
            if (this.arrowWin != null)
            {
                this.arrowWin.Close();
                this.arrowWin = null;
                this.runButton.Text = "创建准星";
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.CloseArrowWindow();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void onAppTimer(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void OnCloseApp(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            Console.WriteLine(config.FilePath);
        }


        private void NotifyRefreshArrowWindow()
        {
            if (this.arrowWin != null)
            {
                this.SaveConfig();
                this.arrowWin.OnRefresh();
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            this.NotifyRefreshArrowWindow();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.colorButton.BackColor = this.colorDialog.Color;
                this.NotifyRefreshArrowWindow();
            }
        }

    }
}
