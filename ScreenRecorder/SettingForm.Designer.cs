namespace ScreenRecorder
{
    partial class SettingForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtBitrate = new System.Windows.Forms.TextBox();
            this.TxtFramerate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CmbVideoEncoder = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CmbVideoQuality = new System.Windows.Forms.ComboBox();
            this.CkbHiddenWindow = new System.Windows.Forms.CheckBox();
            this.BtnSelectSavePath = new System.Windows.Forms.Button();
            this.CmbVideoSource = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSavePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CkbEnableAudioOutput = new System.Windows.Forms.CheckBox();
            this.CkbEnableAudioInput = new System.Windows.Forms.CheckBox();
            this.CmbAudioOutputDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbAudioInputDevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CkbEnableMousePoint = new System.Windows.Forms.CheckBox();
            this.CkbEnableOverlay = new System.Windows.Forms.CheckBox();
            this.TxtOverlayHeightOffset = new System.Windows.Forms.TextBox();
            this.TxtOverlayHeight = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtOverlayWidthOffset = new System.Windows.Forms.TextBox();
            this.TxtOverlayWidth = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbOverlaysPosition = new System.Windows.Forms.ComboBox();
            this.CmbOverlaysCamera = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.TxtBitrate);
            this.groupBox2.Controls.Add(this.TxtFramerate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.CmbVideoEncoder);
            this.groupBox2.Controls.Add(this.CkbHiddenWindow);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.CmbVideoQuality);
            this.groupBox2.Controls.Add(this.BtnSelectSavePath);
            this.groupBox2.Controls.Add(this.CmbVideoSource);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtSavePath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 192);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "视频录制";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 17);
            this.label19.TabIndex = 10;
            this.label19.Text = "编码格式";
            // 
            // TxtBitrate
            // 
            this.TxtBitrate.Location = new System.Drawing.Point(255, 114);
            this.TxtBitrate.Name = "TxtBitrate";
            this.TxtBitrate.Size = new System.Drawing.Size(51, 23);
            this.TxtBitrate.TabIndex = 4;
            this.TxtBitrate.Text = "4096";
            // 
            // TxtFramerate
            // 
            this.TxtFramerate.Location = new System.Drawing.Point(81, 111);
            this.TxtFramerate.Name = "TxtFramerate";
            this.TxtFramerate.Size = new System.Drawing.Size(51, 23);
            this.TxtFramerate.TabIndex = 3;
            this.TxtFramerate.Text = "30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "视频质量";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(197, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "比特率";
            // 
            // CmbVideoEncoder
            // 
            this.CmbVideoEncoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVideoEncoder.FormattingEnabled = true;
            this.CmbVideoEncoder.Location = new System.Drawing.Point(80, 72);
            this.CmbVideoEncoder.Name = "CmbVideoEncoder";
            this.CmbVideoEncoder.Size = new System.Drawing.Size(74, 25);
            this.CmbVideoEncoder.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "帧率";
            // 
            // CmbVideoQuality
            // 
            this.CmbVideoQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVideoQuality.FormattingEnabled = true;
            this.CmbVideoQuality.Location = new System.Drawing.Point(255, 72);
            this.CmbVideoQuality.Name = "CmbVideoQuality";
            this.CmbVideoQuality.Size = new System.Drawing.Size(74, 25);
            this.CmbVideoQuality.TabIndex = 5;
            // 
            // CkbHiddenWindow
            // 
            this.CkbHiddenWindow.AutoSize = true;
            this.CkbHiddenWindow.Location = new System.Drawing.Point(255, 36);
            this.CkbHiddenWindow.Name = "CkbHiddenWindow";
            this.CkbHiddenWindow.Size = new System.Drawing.Size(135, 21);
            this.CkbHiddenWindow.TabIndex = 6;
            this.CkbHiddenWindow.Text = "录制时隐藏程序窗体";
            this.CkbHiddenWindow.UseVisualStyleBackColor = true;
            // 
            // BtnSelectSavePath
            // 
            this.BtnSelectSavePath.Location = new System.Drawing.Point(291, 156);
            this.BtnSelectSavePath.Name = "BtnSelectSavePath";
            this.BtnSelectSavePath.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectSavePath.TabIndex = 8;
            this.BtnSelectSavePath.Text = "浏览";
            this.BtnSelectSavePath.UseVisualStyleBackColor = true;
            this.BtnSelectSavePath.Click += new System.EventHandler(this.BtnSelectSavePath_Click);
            // 
            // CmbVideoSource
            // 
            this.CmbVideoSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVideoSource.FormattingEnabled = true;
            this.CmbVideoSource.Location = new System.Drawing.Point(80, 32);
            this.CmbVideoSource.Name = "CmbVideoSource";
            this.CmbVideoSource.Size = new System.Drawing.Size(169, 25);
            this.CmbVideoSource.TabIndex = 1;
            this.CmbVideoSource.SelectedIndexChanged += new System.EventHandler(this.CmbVideoSource_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "视频源";
            // 
            // TxtSavePath
            // 
            this.TxtSavePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtSavePath.Location = new System.Drawing.Point(81, 156);
            this.TxtSavePath.Name = "TxtSavePath";
            this.TxtSavePath.Size = new System.Drawing.Size(202, 23);
            this.TxtSavePath.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "保存目录";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CkbEnableAudioOutput);
            this.groupBox1.Controls.Add(this.CkbEnableAudioInput);
            this.groupBox1.Controls.Add(this.CmbAudioOutputDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbAudioInputDevice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音频录制";
            // 
            // CkbEnableAudioOutput
            // 
            this.CkbEnableAudioOutput.AutoSize = true;
            this.CkbEnableAudioOutput.Location = new System.Drawing.Point(144, 28);
            this.CkbEnableAudioOutput.Name = "CkbEnableAudioOutput";
            this.CkbEnableAudioOutput.Size = new System.Drawing.Size(99, 21);
            this.CkbEnableAudioOutput.TabIndex = 15;
            this.CkbEnableAudioOutput.Text = "录制音频输出";
            this.CkbEnableAudioOutput.UseVisualStyleBackColor = true;
            // 
            // CkbEnableAudioInput
            // 
            this.CkbEnableAudioInput.AutoSize = true;
            this.CkbEnableAudioInput.Location = new System.Drawing.Point(21, 28);
            this.CkbEnableAudioInput.Name = "CkbEnableAudioInput";
            this.CkbEnableAudioInput.Size = new System.Drawing.Size(99, 21);
            this.CkbEnableAudioInput.TabIndex = 14;
            this.CkbEnableAudioInput.Text = "录制音频输入";
            this.CkbEnableAudioInput.UseVisualStyleBackColor = true;
            // 
            // CmbAudioOutputDevice
            // 
            this.CmbAudioOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAudioOutputDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbAudioOutputDevice.FormattingEnabled = true;
            this.CmbAudioOutputDevice.Location = new System.Drawing.Point(117, 86);
            this.CmbAudioOutputDevice.Name = "CmbAudioOutputDevice";
            this.CmbAudioOutputDevice.Size = new System.Drawing.Size(247, 25);
            this.CmbAudioOutputDevice.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "音频输入设备";
            // 
            // CmbAudioInputDevice
            // 
            this.CmbAudioInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAudioInputDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbAudioInputDevice.FormattingEnabled = true;
            this.CmbAudioInputDevice.Location = new System.Drawing.Point(117, 55);
            this.CmbAudioInputDevice.Name = "CmbAudioInputDevice";
            this.CmbAudioInputDevice.Size = new System.Drawing.Size(247, 25);
            this.CmbAudioInputDevice.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "音频输出设备";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CkbEnableMousePoint);
            this.groupBox4.Controls.Add(this.CkbEnableOverlay);
            this.groupBox4.Controls.Add(this.TxtOverlayHeightOffset);
            this.groupBox4.Controls.Add(this.TxtOverlayHeight);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.TxtOverlayWidthOffset);
            this.groupBox4.Controls.Add(this.TxtOverlayWidth);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.CmbOverlaysPosition);
            this.groupBox4.Controls.Add(this.CmbOverlaysCamera);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(12, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 129);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "水印";
            // 
            // CkbEnableMousePoint
            // 
            this.CkbEnableMousePoint.AutoSize = true;
            this.CkbEnableMousePoint.Location = new System.Drawing.Point(269, 90);
            this.CkbEnableMousePoint.Name = "CkbEnableMousePoint";
            this.CkbEnableMousePoint.Size = new System.Drawing.Size(99, 21);
            this.CkbEnableMousePoint.TabIndex = 26;
            this.CkbEnableMousePoint.Text = "启用鼠标点击";
            this.CkbEnableMousePoint.UseVisualStyleBackColor = true;
            // 
            // CkbEnableOverlay
            // 
            this.CkbEnableOverlay.AutoSize = true;
            this.CkbEnableOverlay.Location = new System.Drawing.Point(269, 60);
            this.CkbEnableOverlay.Name = "CkbEnableOverlay";
            this.CkbEnableOverlay.Size = new System.Drawing.Size(111, 21);
            this.CkbEnableOverlay.TabIndex = 26;
            this.CkbEnableOverlay.Text = "启用摄像头水印";
            this.CkbEnableOverlay.UseVisualStyleBackColor = true;
            // 
            // TxtOverlayHeightOffset
            // 
            this.TxtOverlayHeightOffset.Location = new System.Drawing.Point(198, 88);
            this.TxtOverlayHeightOffset.Name = "TxtOverlayHeightOffset";
            this.TxtOverlayHeightOffset.Size = new System.Drawing.Size(51, 23);
            this.TxtOverlayHeightOffset.TabIndex = 25;
            this.TxtOverlayHeightOffset.Text = "0";
            // 
            // TxtOverlayHeight
            // 
            this.TxtOverlayHeight.Location = new System.Drawing.Point(198, 58);
            this.TxtOverlayHeight.Name = "TxtOverlayHeight";
            this.TxtOverlayHeight.Size = new System.Drawing.Size(51, 23);
            this.TxtOverlayHeight.TabIndex = 23;
            this.TxtOverlayHeight.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "高";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "高";
            // 
            // TxtOverlayWidthOffset
            // 
            this.TxtOverlayWidthOffset.Location = new System.Drawing.Point(115, 88);
            this.TxtOverlayWidthOffset.Name = "TxtOverlayWidthOffset";
            this.TxtOverlayWidthOffset.Size = new System.Drawing.Size(51, 23);
            this.TxtOverlayWidthOffset.TabIndex = 24;
            this.TxtOverlayWidthOffset.Text = "0";
            // 
            // TxtOverlayWidth
            // 
            this.TxtOverlayWidth.Location = new System.Drawing.Point(115, 58);
            this.TxtOverlayWidth.Name = "TxtOverlayWidth";
            this.TxtOverlayWidth.Size = new System.Drawing.Size(51, 23);
            this.TxtOverlayWidth.TabIndex = 22;
            this.TxtOverlayWidth.Text = "256";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(92, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "宽";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "视频偏移：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "宽";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "视频大小：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(230, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "水印位置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "摄像头";
            // 
            // CmbOverlaysPosition
            // 
            this.CmbOverlaysPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOverlaysPosition.FormattingEnabled = true;
            this.CmbOverlaysPosition.Location = new System.Drawing.Point(291, 24);
            this.CmbOverlaysPosition.Name = "CmbOverlaysPosition";
            this.CmbOverlaysPosition.Size = new System.Drawing.Size(73, 25);
            this.CmbOverlaysPosition.TabIndex = 21;
            // 
            // CmbOverlaysCamera
            // 
            this.CmbOverlaysCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOverlaysCamera.FormattingEnabled = true;
            this.CmbOverlaysCamera.Location = new System.Drawing.Point(73, 24);
            this.CmbOverlaysCamera.Name = "CmbOverlaysCamera";
            this.CmbOverlaysCamera.Size = new System.Drawing.Size(151, 25);
            this.CmbOverlaysCamera.TabIndex = 20;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 476);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtSavePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CkbEnableAudioOutput;
        private System.Windows.Forms.CheckBox CkbEnableAudioInput;
        private System.Windows.Forms.ComboBox CmbAudioOutputDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAudioInputDevice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbVideoSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbVideoQuality;
        private System.Windows.Forms.CheckBox CkbHiddenWindow;
        private System.Windows.Forms.Button BtnSelectSavePath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbOverlaysCamera;
        private System.Windows.Forms.TextBox TxtOverlayHeightOffset;
        private System.Windows.Forms.TextBox TxtOverlayHeight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtOverlayWidthOffset;
        private System.Windows.Forms.TextBox TxtOverlayWidth;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtFramerate;
        private System.Windows.Forms.ComboBox CmbVideoEncoder;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtBitrate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox CmbOverlaysPosition;
        private System.Windows.Forms.CheckBox CkbEnableOverlay;
        private System.Windows.Forms.CheckBox CkbEnableMousePoint;
    }
}