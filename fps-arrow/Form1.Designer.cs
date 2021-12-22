namespace fps_arrow
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.runButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UiPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lineSpace = new System.Windows.Forms.NumericUpDown();
            this.lineWidth = new System.Windows.Forms.NumericUpDown();
            this.lineLen = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.offsetY = new System.Windows.Forms.NumericUpDown();
            this.offsetX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.opacity = new System.Windows.Forms.HScrollBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pointFill = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pointWidth = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.pointRadius = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borderLineDistance = new System.Windows.Forms.NumericUpDown();
            this.borderLineLen = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.borderLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripTimer = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.screen1 = new System.Windows.Forms.RadioButton();
            this.screen2 = new System.Windows.Forms.RadioButton();
            this.UiPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLen)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointRadius)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderLineDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLineLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(358, 474);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(300, 34);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "生成准星";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.OnRunButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "理论支持任何FPS游戏, 程序没有对游戏本身做任何修改, 请放心使用!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UiPanel
            // 
            this.UiPanel.Controls.Add(this.screen2);
            this.UiPanel.Controls.Add(this.screen1);
            this.UiPanel.Controls.Add(this.label15);
            this.UiPanel.Controls.Add(this.groupBox3);
            this.UiPanel.Controls.Add(this.groupBox4);
            this.UiPanel.Controls.Add(this.groupBox2);
            this.UiPanel.Controls.Add(this.groupBox1);
            this.UiPanel.Controls.Add(this.runButton);
            this.UiPanel.Controls.Add(this.label1);
            this.UiPanel.Location = new System.Drawing.Point(18, 18);
            this.UiPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UiPanel.Name = "UiPanel";
            this.UiPanel.Size = new System.Drawing.Size(692, 535);
            this.UiPanel.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lineSpace);
            this.groupBox3.Controls.Add(this.lineWidth);
            this.groupBox3.Controls.Add(this.lineLen);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(358, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(300, 206);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "准星十字";
            // 
            // lineSpace
            // 
            this.lineSpace.Location = new System.Drawing.Point(106, 111);
            this.lineSpace.Margin = new System.Windows.Forms.Padding(4);
            this.lineSpace.Name = "lineSpace";
            this.lineSpace.Size = new System.Drawing.Size(180, 28);
            this.lineSpace.TabIndex = 15;
            this.lineSpace.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lineWidth
            // 
            this.lineWidth.Location = new System.Drawing.Point(106, 70);
            this.lineWidth.Margin = new System.Windows.Forms.Padding(4);
            this.lineWidth.Name = "lineWidth";
            this.lineWidth.Size = new System.Drawing.Size(180, 28);
            this.lineWidth.TabIndex = 13;
            this.lineWidth.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // lineLen
            // 
            this.lineLen.Location = new System.Drawing.Point(106, 30);
            this.lineLen.Margin = new System.Windows.Forms.Padding(4);
            this.lineLen.Name = "lineLen";
            this.lineLen.Size = new System.Drawing.Size(180, 28);
            this.lineLen.TabIndex = 12;
            this.lineLen.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "长度:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "粗细:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "中心间隙:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.colorButton);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.offsetY);
            this.groupBox4.Controls.Add(this.offsetX);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.opacity);
            this.groupBox4.Location = new System.Drawing.Point(36, 68);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(303, 206);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "全局设置";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.colorButton.ForeColor = System.Drawing.Color.Transparent;
            this.colorButton.Location = new System.Drawing.Point(70, 145);
            this.colorButton.Margin = new System.Windows.Forms.Padding(4);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(190, 36);
            this.colorButton.TabIndex = 20;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 154);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 19;
            this.label14.Text = "颜色:";
            // 
            // offsetY
            // 
            this.offsetY.Location = new System.Drawing.Point(80, 70);
            this.offsetY.Margin = new System.Windows.Forms.Padding(4);
            this.offsetY.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.offsetY.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.offsetY.Name = "offsetY";
            this.offsetY.Size = new System.Drawing.Size(180, 28);
            this.offsetY.TabIndex = 17;
            this.offsetY.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.offsetY.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // offsetX
            // 
            this.offsetX.Location = new System.Drawing.Point(80, 32);
            this.offsetX.Margin = new System.Windows.Forms.Padding(4);
            this.offsetX.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.offsetX.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.offsetX.Name = "offsetX";
            this.offsetX.Size = new System.Drawing.Size(180, 28);
            this.offsetX.TabIndex = 16;
            this.offsetX.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.offsetX.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "偏移X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "偏移Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "透明度:";
            // 
            // opacity
            // 
            this.opacity.Location = new System.Drawing.Point(80, 111);
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(180, 21);
            this.opacity.TabIndex = 18;
            this.opacity.Value = 100;
            this.opacity.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pointFill);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.pointWidth);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.pointRadius);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(358, 282);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(300, 171);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "准星中心圆环";
            // 
            // pointFill
            // 
            this.pointFill.AutoSize = true;
            this.pointFill.Location = new System.Drawing.Point(81, 130);
            this.pointFill.Margin = new System.Windows.Forms.Padding(4);
            this.pointFill.Name = "pointFill";
            this.pointFill.Size = new System.Drawing.Size(22, 21);
            this.pointFill.TabIndex = 27;
            this.pointFill.UseVisualStyleBackColor = true;
            this.pointFill.CheckedChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 129);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "填充:";
            // 
            // pointWidth
            // 
            this.pointWidth.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pointWidth.Location = new System.Drawing.Point(81, 78);
            this.pointWidth.Margin = new System.Windows.Forms.Padding(4);
            this.pointWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointWidth.Name = "pointWidth";
            this.pointWidth.Size = new System.Drawing.Size(190, 30);
            this.pointWidth.TabIndex = 25;
            this.pointWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointWidth.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "粗细:";
            // 
            // pointRadius
            // 
            this.pointRadius.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pointRadius.Location = new System.Drawing.Point(81, 33);
            this.pointRadius.Margin = new System.Windows.Forms.Padding(4);
            this.pointRadius.Name = "pointRadius";
            this.pointRadius.Size = new System.Drawing.Size(190, 30);
            this.pointRadius.TabIndex = 23;
            this.pointRadius.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 22;
            this.label13.Text = "半径:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borderLineDistance);
            this.groupBox1.Controls.Add(this.borderLineLen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.borderLineWidth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(36, 282);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(303, 171);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "准星边框";
            // 
            // borderLineDistance
            // 
            this.borderLineDistance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.borderLineDistance.Location = new System.Drawing.Point(81, 120);
            this.borderLineDistance.Margin = new System.Windows.Forms.Padding(4);
            this.borderLineDistance.Name = "borderLineDistance";
            this.borderLineDistance.Size = new System.Drawing.Size(190, 30);
            this.borderLineDistance.TabIndex = 25;
            this.borderLineDistance.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // borderLineLen
            // 
            this.borderLineLen.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.borderLineLen.Location = new System.Drawing.Point(81, 75);
            this.borderLineLen.Margin = new System.Windows.Forms.Padding(4);
            this.borderLineLen.Name = "borderLineLen";
            this.borderLineLen.Size = new System.Drawing.Size(190, 30);
            this.borderLineLen.TabIndex = 24;
            this.borderLineLen.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(15, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "长度:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderLineWidth
            // 
            this.borderLineWidth.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.borderLineWidth.Location = new System.Drawing.Point(81, 32);
            this.borderLineWidth.Margin = new System.Windows.Forms.Padding(4);
            this.borderLineWidth.Name = "borderLineWidth";
            this.borderLineWidth.Size = new System.Drawing.Size(190, 30);
            this.borderLineWidth.TabIndex = 23;
            this.borderLineWidth.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "距离:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "粗细:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.onAppTimer);
            // 
            // toolStripTimer
            // 
            this.toolStripTimer.Enabled = true;
            this.toolStripTimer.Interval = 2000;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 485);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 18);
            this.label15.TabIndex = 21;
            this.label15.Text = "显示器:";
            // 
            // screen1
            // 
            this.screen1.AutoSize = true;
            this.screen1.Location = new System.Drawing.Point(116, 483);
            this.screen1.Name = "screen1";
            this.screen1.Size = new System.Drawing.Size(96, 22);
            this.screen1.TabIndex = 27;
            this.screen1.TabStop = true;
            this.screen1.Text = "显示器1";
            this.screen1.UseVisualStyleBackColor = true;
            // 
            // screen2
            // 
            this.screen2.AutoSize = true;
            this.screen2.Location = new System.Drawing.Point(218, 483);
            this.screen2.Name = "screen2";
            this.screen2.Size = new System.Drawing.Size(96, 22);
            this.screen2.TabIndex = 28;
            this.screen2.TabStop = true;
            this.screen2.Text = "显示器2";
            this.screen2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 566);
            this.Controls.Add(this.UiPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPS游戏准星辅助工具";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UiPanel.ResumeLayout(false);
            this.UiPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineLen)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointRadius)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderLineDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLineLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel UiPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar opacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown borderLineDistance;
        private System.Windows.Forms.NumericUpDown borderLineLen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown borderLineWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown pointRadius;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown pointWidth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox pointFill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown lineLen;
        private System.Windows.Forms.NumericUpDown lineSpace;
        private System.Windows.Forms.NumericUpDown lineWidth;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown offsetY;
        private System.Windows.Forms.NumericUpDown offsetX;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Timer toolStripTimer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton screen1;
        private System.Windows.Forms.RadioButton screen2;
    }
}

