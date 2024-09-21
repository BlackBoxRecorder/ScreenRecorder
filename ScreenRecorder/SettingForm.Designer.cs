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
            this.CmbRecordingSourceType = new System.Windows.Forms.ComboBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtScreenRectY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtScreenRectH = new System.Windows.Forms.TextBox();
            this.TxtScreenRectW = new System.Windows.Forms.TextBox();
            this.BtnDrawRect = new System.Windows.Forms.Button();
            this.TxtScreenRectX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbVideoSource = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSavePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrbAudioOutputVolumn = new System.Windows.Forms.NumericUpDown();
            this.TrbAudioInputVolumn = new System.Windows.Forms.NumericUpDown();
            this.CkbEnableAudioOutput = new System.Windows.Forms.CheckBox();
            this.CkbEnableAudioInput = new System.Windows.Forms.CheckBox();
            this.CmbAudioOutputDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbAudioInputDevice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.CkbEnableOverlay = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbAudioOutputVolumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbAudioInputVolumn)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbRecordingSourceType);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.TxtBitrate);
            this.groupBox2.Controls.Add(this.TxtFramerate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.CmbVideoEncoder);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.CmbVideoQuality);
            this.groupBox2.Controls.Add(this.CkbHiddenWindow);
            this.groupBox2.Controls.Add(this.BtnSelectSavePath);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.CmbVideoSource);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TxtSavePath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 316);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "视频录制";
            // 
            // CmbRecordingSourceType
            // 
            this.CmbRecordingSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRecordingSourceType.FormattingEnabled = true;
            this.CmbRecordingSourceType.Location = new System.Drawing.Point(81, 32);
            this.CmbRecordingSourceType.Name = "CmbRecordingSourceType";
            this.CmbRecordingSourceType.Size = new System.Drawing.Size(73, 25);
            this.CmbRecordingSourceType.TabIndex = 11;
            this.CmbRecordingSourceType.SelectedIndexChanged += new System.EventHandler(this.CmbRecordingSourceType_SelectedIndexChanged);
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
            this.TxtBitrate.Location = new System.Drawing.Point(315, 72);
            this.TxtBitrate.Name = "TxtBitrate";
            this.TxtBitrate.Size = new System.Drawing.Size(51, 23);
            this.TxtBitrate.TabIndex = 4;
            this.TxtBitrate.Text = "4096";
            // 
            // TxtFramerate
            // 
            this.TxtFramerate.Location = new System.Drawing.Point(206, 72);
            this.TxtFramerate.Name = "TxtFramerate";
            this.TxtFramerate.Size = new System.Drawing.Size(51, 23);
            this.TxtFramerate.TabIndex = 4;
            this.TxtFramerate.Text = "30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "视频质量";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(271, 76);
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
            this.CmbVideoEncoder.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(171, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "帧率";
            // 
            // CmbVideoQuality
            // 
            this.CmbVideoQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVideoQuality.FormattingEnabled = true;
            this.CmbVideoQuality.Location = new System.Drawing.Point(80, 115);
            this.CmbVideoQuality.Name = "CmbVideoQuality";
            this.CmbVideoQuality.Size = new System.Drawing.Size(74, 25);
            this.CmbVideoQuality.TabIndex = 9;
            // 
            // CkbHiddenWindow
            // 
            this.CkbHiddenWindow.AutoSize = true;
            this.CkbHiddenWindow.Location = new System.Drawing.Point(174, 118);
            this.CkbHiddenWindow.Name = "CkbHiddenWindow";
            this.CkbHiddenWindow.Size = new System.Drawing.Size(135, 21);
            this.CkbHiddenWindow.TabIndex = 8;
            this.CkbHiddenWindow.Text = "录制时隐藏程序窗体";
            this.CkbHiddenWindow.UseVisualStyleBackColor = true;
            // 
            // BtnSelectSavePath
            // 
            this.BtnSelectSavePath.Location = new System.Drawing.Point(291, 159);
            this.BtnSelectSavePath.Name = "BtnSelectSavePath";
            this.BtnSelectSavePath.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectSavePath.TabIndex = 7;
            this.BtnSelectSavePath.Text = "浏览";
            this.BtnSelectSavePath.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtScreenRectY);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtScreenRectH);
            this.groupBox3.Controls.Add(this.TxtScreenRectW);
            this.groupBox3.Controls.Add(this.BtnDrawRect);
            this.groupBox3.Controls.Add(this.TxtScreenRectX);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(19, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 104);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "录制范围";
            // 
            // TxtScreenRectY
            // 
            this.TxtScreenRectY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtScreenRectY.Location = new System.Drawing.Point(171, 29);
            this.TxtScreenRectY.Name = "TxtScreenRectY";
            this.TxtScreenRectY.Size = new System.Drawing.Size(46, 23);
            this.TxtScreenRectY.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(42, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(153, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Y";
            // 
            // TxtScreenRectH
            // 
            this.TxtScreenRectH.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtScreenRectH.Location = new System.Drawing.Point(171, 67);
            this.TxtScreenRectH.Name = "TxtScreenRectH";
            this.TxtScreenRectH.Size = new System.Drawing.Size(46, 23);
            this.TxtScreenRectH.TabIndex = 2;
            // 
            // TxtScreenRectW
            // 
            this.TxtScreenRectW.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtScreenRectW.Location = new System.Drawing.Point(62, 67);
            this.TxtScreenRectW.Name = "TxtScreenRectW";
            this.TxtScreenRectW.Size = new System.Drawing.Size(46, 23);
            this.TxtScreenRectW.TabIndex = 2;
            // 
            // BtnDrawRect
            // 
            this.BtnDrawRect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDrawRect.Location = new System.Drawing.Point(256, 32);
            this.BtnDrawRect.Name = "BtnDrawRect";
            this.BtnDrawRect.Size = new System.Drawing.Size(91, 58);
            this.BtnDrawRect.TabIndex = 0;
            this.BtnDrawRect.Text = "选择区域";
            this.BtnDrawRect.UseVisualStyleBackColor = true;
            // 
            // TxtScreenRectX
            // 
            this.TxtScreenRectX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtScreenRectX.Location = new System.Drawing.Point(62, 29);
            this.TxtScreenRectX.Name = "TxtScreenRectX";
            this.TxtScreenRectX.Size = new System.Drawing.Size(46, 23);
            this.TxtScreenRectX.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(124, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Width";
            // 
            // CmbVideoSource
            // 
            this.CmbVideoSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbVideoSource.FormattingEnabled = true;
            this.CmbVideoSource.Location = new System.Drawing.Point(174, 32);
            this.CmbVideoSource.Name = "CmbVideoSource";
            this.CmbVideoSource.Size = new System.Drawing.Size(190, 25);
            this.CmbVideoSource.TabIndex = 5;
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
            this.TxtSavePath.Location = new System.Drawing.Point(79, 159);
            this.TxtSavePath.Name = "TxtSavePath";
            this.TxtSavePath.Size = new System.Drawing.Size(202, 23);
            this.TxtSavePath.TabIndex = 2;
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
            this.groupBox1.Controls.Add(this.TrbAudioOutputVolumn);
            this.groupBox1.Controls.Add(this.TrbAudioInputVolumn);
            this.groupBox1.Controls.Add(this.CkbEnableAudioOutput);
            this.groupBox1.Controls.Add(this.CkbEnableAudioInput);
            this.groupBox1.Controls.Add(this.CmbAudioOutputDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbAudioInputDevice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音频录制";
            // 
            // TrbAudioOutputVolumn
            // 
            this.TrbAudioOutputVolumn.Location = new System.Drawing.Point(340, 86);
            this.TrbAudioOutputVolumn.Name = "TrbAudioOutputVolumn";
            this.TrbAudioOutputVolumn.Size = new System.Drawing.Size(46, 23);
            this.TrbAudioOutputVolumn.TabIndex = 7;
            // 
            // TrbAudioInputVolumn
            // 
            this.TrbAudioInputVolumn.Location = new System.Drawing.Point(340, 57);
            this.TrbAudioInputVolumn.Name = "TrbAudioInputVolumn";
            this.TrbAudioInputVolumn.Size = new System.Drawing.Size(46, 23);
            this.TrbAudioInputVolumn.TabIndex = 7;
            // 
            // CkbEnableAudioOutput
            // 
            this.CkbEnableAudioOutput.AutoSize = true;
            this.CkbEnableAudioOutput.Location = new System.Drawing.Point(144, 28);
            this.CkbEnableAudioOutput.Name = "CkbEnableAudioOutput";
            this.CkbEnableAudioOutput.Size = new System.Drawing.Size(99, 21);
            this.CkbEnableAudioOutput.TabIndex = 6;
            this.CkbEnableAudioOutput.Text = "录制音频输出";
            this.CkbEnableAudioOutput.UseVisualStyleBackColor = true;
            // 
            // CkbEnableAudioInput
            // 
            this.CkbEnableAudioInput.AutoSize = true;
            this.CkbEnableAudioInput.Location = new System.Drawing.Point(21, 28);
            this.CkbEnableAudioInput.Name = "CkbEnableAudioInput";
            this.CkbEnableAudioInput.Size = new System.Drawing.Size(99, 21);
            this.CkbEnableAudioInput.TabIndex = 6;
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
            this.CmbAudioOutputDevice.Size = new System.Drawing.Size(164, 25);
            this.CmbAudioOutputDevice.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(300, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "音量";
            // 
            // CmbAudioInputDevice
            // 
            this.CmbAudioInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAudioInputDevice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbAudioInputDevice.FormattingEnabled = true;
            this.CmbAudioInputDevice.Location = new System.Drawing.Point(117, 55);
            this.CmbAudioInputDevice.Name = "CmbAudioInputDevice";
            this.CmbAudioInputDevice.Size = new System.Drawing.Size(164, 25);
            this.CmbAudioInputDevice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(300, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "音量";
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
            this.groupBox4.Location = new System.Drawing.Point(12, 478);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 129);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "摄像头水印";
            // 
            // TxtOverlayHeightOffset
            // 
            this.TxtOverlayHeightOffset.Location = new System.Drawing.Point(198, 88);
            this.TxtOverlayHeightOffset.Name = "TxtOverlayHeightOffset";
            this.TxtOverlayHeightOffset.Size = new System.Drawing.Size(51, 23);
            this.TxtOverlayHeightOffset.TabIndex = 4;
            this.TxtOverlayHeightOffset.Text = "0";
            // 
            // TxtOverlayHeight
            // 
            this.TxtOverlayHeight.Location = new System.Drawing.Point(198, 58);
            this.TxtOverlayHeight.Name = "TxtOverlayHeight";
            this.TxtOverlayHeight.Size = new System.Drawing.Size(51, 23);
            this.TxtOverlayHeight.TabIndex = 4;
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
            this.TxtOverlayWidthOffset.TabIndex = 4;
            this.TxtOverlayWidthOffset.Text = "0";
            // 
            // TxtOverlayWidth
            // 
            this.TxtOverlayWidth.Location = new System.Drawing.Point(115, 58);
            this.TxtOverlayWidth.Name = "TxtOverlayWidth";
            this.TxtOverlayWidth.Size = new System.Drawing.Size(51, 23);
            this.TxtOverlayWidth.TabIndex = 4;
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
            this.label22.Location = new System.Drawing.Point(195, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "水印位置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "摄像头";
            // 
            // CmbOverlaysPosition
            // 
            this.CmbOverlaysPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOverlaysPosition.FormattingEnabled = true;
            this.CmbOverlaysPosition.Location = new System.Drawing.Point(257, 27);
            this.CmbOverlaysPosition.Name = "CmbOverlaysPosition";
            this.CmbOverlaysPosition.Size = new System.Drawing.Size(93, 25);
            this.CmbOverlaysPosition.TabIndex = 0;
            // 
            // CmbOverlaysCamera
            // 
            this.CmbOverlaysCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOverlaysCamera.FormattingEnabled = true;
            this.CmbOverlaysCamera.Location = new System.Drawing.Point(73, 27);
            this.CmbOverlaysCamera.Name = "CmbOverlaysCamera";
            this.CmbOverlaysCamera.Size = new System.Drawing.Size(93, 25);
            this.CmbOverlaysCamera.TabIndex = 0;
            // 
            // CkbEnableOverlay
            // 
            this.CkbEnableOverlay.AutoSize = true;
            this.CkbEnableOverlay.Location = new System.Drawing.Point(274, 64);
            this.CkbEnableOverlay.Name = "CkbEnableOverlay";
            this.CkbEnableOverlay.Size = new System.Drawing.Size(51, 21);
            this.CkbEnableOverlay.TabIndex = 5;
            this.CkbEnableOverlay.Text = "启用";
            this.CkbEnableOverlay.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 622);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbAudioOutputVolumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbAudioInputVolumn)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtScreenRectW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSavePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnDrawRect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CkbEnableAudioOutput;
        private System.Windows.Forms.CheckBox CkbEnableAudioInput;
        private System.Windows.Forms.ComboBox CmbAudioOutputDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbAudioInputDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbVideoSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtScreenRectY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtScreenRectH;
        private System.Windows.Forms.TextBox TxtScreenRectX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbVideoQuality;
        private System.Windows.Forms.CheckBox CkbHiddenWindow;
        private System.Windows.Forms.Button BtnSelectSavePath;
        private System.Windows.Forms.NumericUpDown TrbAudioOutputVolumn;
        private System.Windows.Forms.NumericUpDown TrbAudioInputVolumn;
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
        private System.Windows.Forms.ComboBox CmbRecordingSourceType;
        private System.Windows.Forms.CheckBox CkbEnableOverlay;
    }
}