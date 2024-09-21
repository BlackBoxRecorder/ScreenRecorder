namespace ScreenRecorder
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStartRecorder = new System.Windows.Forms.Button();
            this.BtnPauseRecorder = new System.Windows.Forms.Button();
            this.LblRecordDuration = new System.Windows.Forms.Label();
            this.LinkSettingForm = new System.Windows.Forms.LinkLabel();
            this.CkbTopMost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnStartRecorder
            // 
            this.BtnStartRecorder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStartRecorder.Location = new System.Drawing.Point(47, 88);
            this.BtnStartRecorder.Name = "BtnStartRecorder";
            this.BtnStartRecorder.Size = new System.Drawing.Size(197, 37);
            this.BtnStartRecorder.TabIndex = 0;
            this.BtnStartRecorder.Text = "开始录制";
            this.BtnStartRecorder.UseVisualStyleBackColor = true;
            this.BtnStartRecorder.Click += new System.EventHandler(this.BtnStartRecorder_Click);
            // 
            // BtnPauseRecorder
            // 
            this.BtnPauseRecorder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPauseRecorder.Location = new System.Drawing.Point(49, 131);
            this.BtnPauseRecorder.Name = "BtnPauseRecorder";
            this.BtnPauseRecorder.Size = new System.Drawing.Size(195, 40);
            this.BtnPauseRecorder.TabIndex = 1;
            this.BtnPauseRecorder.Text = "暂停录制";
            this.BtnPauseRecorder.UseVisualStyleBackColor = true;
            this.BtnPauseRecorder.Click += new System.EventHandler(this.BtnPauseRecorder_Click);
            // 
            // LblRecordDuration
            // 
            this.LblRecordDuration.AutoSize = true;
            this.LblRecordDuration.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblRecordDuration.Location = new System.Drawing.Point(64, 22);
            this.LblRecordDuration.Name = "LblRecordDuration";
            this.LblRecordDuration.Size = new System.Drawing.Size(162, 46);
            this.LblRecordDuration.TabIndex = 2;
            this.LblRecordDuration.Text = "00:00:00";
            // 
            // LinkSettingForm
            // 
            this.LinkSettingForm.AutoSize = true;
            this.LinkSettingForm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LinkSettingForm.LinkColor = System.Drawing.Color.Black;
            this.LinkSettingForm.Location = new System.Drawing.Point(22, 201);
            this.LinkSettingForm.Name = "LinkSettingForm";
            this.LinkSettingForm.Size = new System.Drawing.Size(42, 21);
            this.LinkSettingForm.TabIndex = 6;
            this.LinkSettingForm.TabStop = true;
            this.LinkSettingForm.Text = "设置";
            this.LinkSettingForm.Click += new System.EventHandler(this.LinkSettingForm_Click);
            // 
            // CkbTopMost
            // 
            this.CkbTopMost.AutoSize = true;
            this.CkbTopMost.Location = new System.Drawing.Point(71, 205);
            this.CkbTopMost.Name = "CkbTopMost";
            this.CkbTopMost.Size = new System.Drawing.Size(48, 16);
            this.CkbTopMost.TabIndex = 7;
            this.CkbTopMost.Text = "顶置";
            this.CkbTopMost.UseVisualStyleBackColor = true;
            this.CkbTopMost.CheckedChanged += new System.EventHandler(this.CkbTopMost_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 249);
            this.Controls.Add(this.CkbTopMost);
            this.Controls.Add(this.LinkSettingForm);
            this.Controls.Add(this.LblRecordDuration);
            this.Controls.Add(this.BtnPauseRecorder);
            this.Controls.Add(this.BtnStartRecorder);
            this.Name = "MainForm";
            this.Text = "录屏";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartRecorder;
        private System.Windows.Forms.Button BtnPauseRecorder;
        private System.Windows.Forms.Label LblRecordDuration;
        private System.Windows.Forms.LinkLabel LinkSettingForm;
        private System.Windows.Forms.CheckBox CkbTopMost;
    }
}

