namespace CaptureScreen
{
    partial class CaptureSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureSetting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSourceLeft = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownSourceTop = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxSourceFullScreen = new System.Windows.Forms.CheckBox();
            this.numericUpDownSourceHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSourceWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSourceScreenIndex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownWebPort = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxShowWEB = new System.Windows.Forms.CheckBox();
            this.checkBoxShowForm = new System.Windows.Forms.CheckBox();
            this.checkBoxDestFullScreen = new System.Windows.Forms.CheckBox();
            this.numericUpDownDestHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDestWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDestScreenIndex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRefreshPreview = new System.Windows.Forms.Button();
            this.timerDisplayForm = new System.Windows.Forms.Timer(this.components);
            this.buttonGetRunningProblems = new System.Windows.Forms.Button();
            this.panelImg = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxWindowName = new System.Windows.Forms.TextBox();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.checkBoxWindowCaption = new System.Windows.Forms.CheckBox();
            this.numericUpDownDestLeft = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownDestTop = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxDestMostTop = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourceLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourceTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourceHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourceWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWebPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestTop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownSourceLeft);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericUpDownSourceTop);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checkBoxSourceFullScreen);
            this.groupBox1.Controls.Add(this.numericUpDownSourceHeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownSourceWidth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxSourceScreenIndex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像源";
            // 
            // numericUpDownSourceLeft
            // 
            this.numericUpDownSourceLeft.Location = new System.Drawing.Point(305, 22);
            this.numericUpDownSourceLeft.Maximum = new decimal(new int[] {
            10800,
            0,
            0,
            0});
            this.numericUpDownSourceLeft.Minimum = new decimal(new int[] {
            10800,
            0,
            0,
            -2147483648});
            this.numericUpDownSourceLeft.Name = "numericUpDownSourceLeft";
            this.numericUpDownSourceLeft.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSourceLeft.TabIndex = 17;
            this.numericUpDownSourceLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y :";
            // 
            // numericUpDownSourceTop
            // 
            this.numericUpDownSourceTop.Location = new System.Drawing.Point(218, 22);
            this.numericUpDownSourceTop.Maximum = new decimal(new int[] {
            19200,
            0,
            0,
            0});
            this.numericUpDownSourceTop.Minimum = new decimal(new int[] {
            19200,
            0,
            0,
            -2147483648});
            this.numericUpDownSourceTop.Name = "numericUpDownSourceTop";
            this.numericUpDownSourceTop.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSourceTop.TabIndex = 15;
            this.numericUpDownSourceTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "X :";
            // 
            // checkBoxSourceFullScreen
            // 
            this.checkBoxSourceFullScreen.AutoSize = true;
            this.checkBoxSourceFullScreen.Location = new System.Drawing.Point(137, 25);
            this.checkBoxSourceFullScreen.Name = "checkBoxSourceFullScreen";
            this.checkBoxSourceFullScreen.Size = new System.Drawing.Size(50, 17);
            this.checkBoxSourceFullScreen.TabIndex = 13;
            this.checkBoxSourceFullScreen.Text = "全屏";
            this.checkBoxSourceFullScreen.UseVisualStyleBackColor = true;
            this.checkBoxSourceFullScreen.CheckedChanged += new System.EventHandler(this.checkBoxSourceFullScreen_CheckedChanged);
            // 
            // numericUpDownSourceHeight
            // 
            this.numericUpDownSourceHeight.Location = new System.Drawing.Point(305, 56);
            this.numericUpDownSourceHeight.Maximum = new decimal(new int[] {
            10800,
            0,
            0,
            0});
            this.numericUpDownSourceHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSourceHeight.Name = "numericUpDownSourceHeight";
            this.numericUpDownSourceHeight.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSourceHeight.TabIndex = 12;
            this.numericUpDownSourceHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSourceHeight.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "高:";
            // 
            // numericUpDownSourceWidth
            // 
            this.numericUpDownSourceWidth.Location = new System.Drawing.Point(218, 56);
            this.numericUpDownSourceWidth.Maximum = new decimal(new int[] {
            19200,
            0,
            0,
            0});
            this.numericUpDownSourceWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSourceWidth.Name = "numericUpDownSourceWidth";
            this.numericUpDownSourceWidth.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSourceWidth.TabIndex = 10;
            this.numericUpDownSourceWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSourceWidth.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "宽:";
            // 
            // comboBoxSourceScreenIndex
            // 
            this.comboBoxSourceScreenIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSourceScreenIndex.FormattingEnabled = true;
            this.comboBoxSourceScreenIndex.Location = new System.Drawing.Point(50, 23);
            this.comboBoxSourceScreenIndex.Name = "comboBoxSourceScreenIndex";
            this.comboBoxSourceScreenIndex.Size = new System.Drawing.Size(69, 21);
            this.comboBoxSourceScreenIndex.TabIndex = 8;
            this.comboBoxSourceScreenIndex.SelectedIndexChanged += new System.EventHandler(this.comboBoxSourceScreenIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "屏幕:";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPreview.Location = new System.Drawing.Point(472, 186);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(400, 300);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 8;
            this.pictureBoxPreview.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxDestMostTop);
            this.groupBox2.Controls.Add(this.numericUpDownDestLeft);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericUpDownDestTop);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericUpDownWebPort);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.checkBoxShowWEB);
            this.groupBox2.Controls.Add(this.checkBoxShowForm);
            this.groupBox2.Controls.Add(this.checkBoxDestFullScreen);
            this.groupBox2.Controls.Add(this.numericUpDownDestHeight);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDownDestWidth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxDestScreenIndex);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(472, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 125);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示方式";
            // 
            // numericUpDownWebPort
            // 
            this.numericUpDownWebPort.Location = new System.Drawing.Point(245, 27);
            this.numericUpDownWebPort.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numericUpDownWebPort.Name = "numericUpDownWebPort";
            this.numericUpDownWebPort.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownWebPort.TabIndex = 17;
            this.numericUpDownWebPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownWebPort.Value = new decimal(new int[] {
            8090,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "端口号:";
            // 
            // checkBoxShowWEB
            // 
            this.checkBoxShowWEB.AutoSize = true;
            this.checkBoxShowWEB.Location = new System.Drawing.Point(137, 30);
            this.checkBoxShowWEB.Name = "checkBoxShowWEB";
            this.checkBoxShowWEB.Size = new System.Drawing.Size(49, 17);
            this.checkBoxShowWEB.TabIndex = 15;
            this.checkBoxShowWEB.Text = "Web";
            this.checkBoxShowWEB.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowForm
            // 
            this.checkBoxShowForm.AutoSize = true;
            this.checkBoxShowForm.Location = new System.Drawing.Point(16, 30);
            this.checkBoxShowForm.Name = "checkBoxShowForm";
            this.checkBoxShowForm.Size = new System.Drawing.Size(74, 17);
            this.checkBoxShowForm.TabIndex = 14;
            this.checkBoxShowForm.Text = "显示窗口";
            this.checkBoxShowForm.UseVisualStyleBackColor = true;
            // 
            // checkBoxDestFullScreen
            // 
            this.checkBoxDestFullScreen.AutoSize = true;
            this.checkBoxDestFullScreen.Location = new System.Drawing.Point(137, 67);
            this.checkBoxDestFullScreen.Name = "checkBoxDestFullScreen";
            this.checkBoxDestFullScreen.Size = new System.Drawing.Size(50, 17);
            this.checkBoxDestFullScreen.TabIndex = 13;
            this.checkBoxDestFullScreen.Text = "全屏";
            this.checkBoxDestFullScreen.UseVisualStyleBackColor = true;
            this.checkBoxDestFullScreen.CheckedChanged += new System.EventHandler(this.checkBoxDestFullScreen_CheckedChanged);
            // 
            // numericUpDownDestHeight
            // 
            this.numericUpDownDestHeight.Location = new System.Drawing.Point(305, 91);
            this.numericUpDownDestHeight.Maximum = new decimal(new int[] {
            10800,
            0,
            0,
            0});
            this.numericUpDownDestHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDestHeight.Name = "numericUpDownDestHeight";
            this.numericUpDownDestHeight.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDestHeight.TabIndex = 12;
            this.numericUpDownDestHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDestHeight.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "高:";
            // 
            // numericUpDownDestWidth
            // 
            this.numericUpDownDestWidth.Location = new System.Drawing.Point(218, 91);
            this.numericUpDownDestWidth.Maximum = new decimal(new int[] {
            19200,
            0,
            0,
            0});
            this.numericUpDownDestWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDestWidth.Name = "numericUpDownDestWidth";
            this.numericUpDownDestWidth.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDestWidth.TabIndex = 10;
            this.numericUpDownDestWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDestWidth.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "宽:";
            // 
            // comboBoxDestScreenIndex
            // 
            this.comboBoxDestScreenIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestScreenIndex.FormattingEnabled = true;
            this.comboBoxDestScreenIndex.Location = new System.Drawing.Point(50, 65);
            this.comboBoxDestScreenIndex.Name = "comboBoxDestScreenIndex";
            this.comboBoxDestScreenIndex.Size = new System.Drawing.Size(69, 21);
            this.comboBoxDestScreenIndex.TabIndex = 8;
            this.comboBoxDestScreenIndex.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestScreenIndex_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "屏幕:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(694, 147);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(162, 26);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRefreshPreview
            // 
            this.buttonRefreshPreview.Location = new System.Drawing.Point(495, 147);
            this.buttonRefreshPreview.Name = "buttonRefreshPreview";
            this.buttonRefreshPreview.Size = new System.Drawing.Size(162, 26);
            this.buttonRefreshPreview.TabIndex = 11;
            this.buttonRefreshPreview.Text = "刷新预览";
            this.buttonRefreshPreview.UseVisualStyleBackColor = true;
            this.buttonRefreshPreview.Click += new System.EventHandler(this.buttonRefreshPreview_Click);
            // 
            // timerDisplayForm
            // 
            this.timerDisplayForm.Tick += new System.EventHandler(this.timerDisplayForm_Tick);
            // 
            // buttonGetRunningProblems
            // 
            this.buttonGetRunningProblems.Location = new System.Drawing.Point(124, 115);
            this.buttonGetRunningProblems.Name = "buttonGetRunningProblems";
            this.buttonGetRunningProblems.Size = new System.Drawing.Size(75, 26);
            this.buttonGetRunningProblems.TabIndex = 14;
            this.buttonGetRunningProblems.Text = "刷新";
            this.buttonGetRunningProblems.UseVisualStyleBackColor = true;
            this.buttonGetRunningProblems.Click += new System.EventHandler(this.buttonGetRunningProblems_Click);
            // 
            // panelImg
            // 
            this.panelImg.AutoScroll = true;
            this.panelImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelImg.Location = new System.Drawing.Point(13, 147);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(453, 391);
            this.panelImg.TabIndex = 16;
            // 
            // textBoxWindowName
            // 
            this.textBoxWindowName.Location = new System.Drawing.Point(472, 492);
            this.textBoxWindowName.Name = "textBoxWindowName";
            this.textBoxWindowName.ReadOnly = true;
            this.textBoxWindowName.Size = new System.Drawing.Size(399, 20);
            this.textBoxWindowName.TabIndex = 17;
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(472, 518);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.ReadOnly = true;
            this.textBoxClassName.Size = new System.Drawing.Size(399, 20);
            this.textBoxClassName.TabIndex = 18;
            // 
            // checkBoxWindowCaption
            // 
            this.checkBoxWindowCaption.AutoSize = true;
            this.checkBoxWindowCaption.Location = new System.Drawing.Point(28, 120);
            this.checkBoxWindowCaption.Name = "checkBoxWindowCaption";
            this.checkBoxWindowCaption.Size = new System.Drawing.Size(89, 17);
            this.checkBoxWindowCaption.TabIndex = 19;
            this.checkBoxWindowCaption.Text = "运行中程序:";
            this.checkBoxWindowCaption.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDestLeft
            // 
            this.numericUpDownDestLeft.Location = new System.Drawing.Point(305, 64);
            this.numericUpDownDestLeft.Maximum = new decimal(new int[] {
            10800,
            0,
            0,
            0});
            this.numericUpDownDestLeft.Minimum = new decimal(new int[] {
            10800,
            0,
            0,
            -2147483648});
            this.numericUpDownDestLeft.Name = "numericUpDownDestLeft";
            this.numericUpDownDestLeft.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDestLeft.TabIndex = 21;
            this.numericUpDownDestLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Y :";
            // 
            // numericUpDownDestTop
            // 
            this.numericUpDownDestTop.Location = new System.Drawing.Point(218, 64);
            this.numericUpDownDestTop.Maximum = new decimal(new int[] {
            19200,
            0,
            0,
            0});
            this.numericUpDownDestTop.Minimum = new decimal(new int[] {
            19200,
            0,
            0,
            -2147483648});
            this.numericUpDownDestTop.Name = "numericUpDownDestTop";
            this.numericUpDownDestTop.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDestTop.TabIndex = 19;
            this.numericUpDownDestTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "X :";
            // 
            // checkBoxDestMostTop
            // 
            this.checkBoxDestMostTop.AutoSize = true;
            this.checkBoxDestMostTop.Location = new System.Drawing.Point(101, 94);
            this.checkBoxDestMostTop.Name = "checkBoxDestMostTop";
            this.checkBoxDestMostTop.Size = new System.Drawing.Size(86, 17);
            this.checkBoxDestMostTop.TabIndex = 22;
            this.checkBoxDestMostTop.Text = "锁定最上层";
            this.checkBoxDestMostTop.UseVisualStyleBackColor = true;
            // 
            // CaptureSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.checkBoxWindowCaption);
            this.Controls.Add(this.textBoxClassName);
            this.Controls.Add(this.textBoxWindowName);
            this.Controls.Add(this.panelImg);
            this.Controls.Add(this.buttonGetRunningProblems);
            this.Controls.Add(this.buttonRefreshPreview);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaptureSetting";
            this.Text = "Capture Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartSetting_FormClosing);
            this.Load += new System.EventHandler(this.StartSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourceLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourceTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourceHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSourceWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWebPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSourceFullScreen;
        private System.Windows.Forms.NumericUpDown numericUpDownSourceHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSourceWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSourceScreenIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxShowWEB;
        private System.Windows.Forms.CheckBox checkBoxShowForm;
        private System.Windows.Forms.CheckBox checkBoxDestFullScreen;
        private System.Windows.Forms.NumericUpDown numericUpDownDestHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownDestWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDestScreenIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRefreshPreview;
        private System.Windows.Forms.NumericUpDown numericUpDownWebPort;
        private System.Windows.Forms.NumericUpDown numericUpDownSourceLeft;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownSourceTop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerDisplayForm;
        private System.Windows.Forms.Button buttonGetRunningProblems;
        private System.Windows.Forms.FlowLayoutPanel panelImg;
        private System.Windows.Forms.TextBox textBoxWindowName;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.CheckBox checkBoxWindowCaption;
        private System.Windows.Forms.NumericUpDown numericUpDownDestLeft;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownDestTop;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxDestMostTop;
    }
}