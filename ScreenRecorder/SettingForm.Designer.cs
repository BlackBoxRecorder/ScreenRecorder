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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtSavePath = new AntdUI.Input();
            this.BtnSelectSavePath = new AntdUI.Button();
            this.CmbVideoSource = new AntdUI.Select();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CkbEnableAudioInput = new AntdUI.Checkbox();
            this.CmbAudioOutputDevice = new AntdUI.Select();
            this.CkbEnableAudioOutput = new AntdUI.Checkbox();
            this.CmbAudioInputDevice = new AntdUI.Select();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtSavePath);
            this.groupBox2.Controls.Add(this.BtnSelectSavePath);
            this.groupBox2.Controls.Add(this.CmbVideoSource);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 115);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "视频录制";
            // 
            // TxtSavePath
            // 
            this.TxtSavePath.Location = new System.Drawing.Point(94, 63);
            this.TxtSavePath.Name = "TxtSavePath";
            this.TxtSavePath.Size = new System.Drawing.Size(180, 35);
            this.TxtSavePath.TabIndex = 11;
            // 
            // BtnSelectSavePath
            // 
            this.BtnSelectSavePath.Location = new System.Drawing.Point(280, 63);
            this.BtnSelectSavePath.Name = "BtnSelectSavePath";
            this.BtnSelectSavePath.Size = new System.Drawing.Size(75, 35);
            this.BtnSelectSavePath.TabIndex = 10;
            this.BtnSelectSavePath.Text = "浏览";
            this.BtnSelectSavePath.Click += new System.EventHandler(this.BtnSelectSavePath_Click);
            // 
            // CmbVideoSource
            // 
            this.CmbVideoSource.List = true;
            this.CmbVideoSource.Location = new System.Drawing.Point(94, 22);
            this.CmbVideoSource.Name = "CmbVideoSource";
            this.CmbVideoSource.Size = new System.Drawing.Size(180, 35);
            this.CmbVideoSource.TabIndex = 9;
            this.CmbVideoSource.Text = "请选择显示器";
            this.CmbVideoSource.SelectedIndexChanged += new AntdUI.IntEventHandler(this.CmbVideoSource_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "视频源";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(15, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "保存目录";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CkbEnableAudioInput);
            this.groupBox1.Controls.Add(this.CmbAudioOutputDevice);
            this.groupBox1.Controls.Add(this.CkbEnableAudioOutput);
            this.groupBox1.Controls.Add(this.CmbAudioInputDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音频录制";
            // 
            // CkbEnableAudioInput
            // 
            this.CkbEnableAudioInput.Location = new System.Drawing.Point(12, 29);
            this.CkbEnableAudioInput.Name = "CkbEnableAudioInput";
            this.CkbEnableAudioInput.Size = new System.Drawing.Size(113, 23);
            this.CkbEnableAudioInput.TabIndex = 13;
            this.CkbEnableAudioInput.Text = "录制音频输入";
            this.CkbEnableAudioInput.CheckedChanged += new AntdUI.BoolEventHandler(this.CkbEnableAudioInput_CheckedChanged);
            // 
            // CmbAudioOutputDevice
            // 
            this.CmbAudioOutputDevice.List = true;
            this.CmbAudioOutputDevice.Location = new System.Drawing.Point(109, 99);
            this.CmbAudioOutputDevice.Name = "CmbAudioOutputDevice";
            this.CmbAudioOutputDevice.Size = new System.Drawing.Size(246, 35);
            this.CmbAudioOutputDevice.TabIndex = 19;
            this.CmbAudioOutputDevice.Text = "请选择音频输出设备";
            // 
            // CkbEnableAudioOutput
            // 
            this.CkbEnableAudioOutput.Location = new System.Drawing.Point(182, 29);
            this.CkbEnableAudioOutput.Name = "CkbEnableAudioOutput";
            this.CkbEnableAudioOutput.Size = new System.Drawing.Size(107, 23);
            this.CkbEnableAudioOutput.TabIndex = 12;
            this.CkbEnableAudioOutput.Text = "录制音频输出";
            this.CkbEnableAudioOutput.CheckedChanged += new AntdUI.BoolEventHandler(this.CkbEnableAudioOutput_CheckedChanged);
            // 
            // CmbAudioInputDevice
            // 
            this.CmbAudioInputDevice.List = true;
            this.CmbAudioInputDevice.Location = new System.Drawing.Point(109, 58);
            this.CmbAudioInputDevice.Name = "CmbAudioInputDevice";
            this.CmbAudioInputDevice.Size = new System.Drawing.Size(246, 35);
            this.CmbAudioInputDevice.TabIndex = 18;
            this.CmbAudioInputDevice.Text = "请选择音频输入设备";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "音频输入设备";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "音频输出设备";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(176, 306);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(390, 330);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AntdUI.Input TxtSavePath;
        private AntdUI.Button BtnSelectSavePath;
        private AntdUI.Select CmbVideoSource;
        private AntdUI.Select CmbAudioInputDevice;
        private AntdUI.Select CmbAudioOutputDevice;
        private AntdUI.Checkbox CkbEnableAudioOutput;
        private AntdUI.Checkbox CkbEnableAudioInput;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}