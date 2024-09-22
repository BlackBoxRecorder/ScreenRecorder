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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnStartRecorder = new System.Windows.Forms.Button();
            this.BtnPauseRecorder = new System.Windows.Forms.Button();
            this.LblRecordDuration = new System.Windows.Forms.Label();
            this.CkbTopMost = new System.Windows.Forms.CheckBox();
            this.BtnDrawRect = new System.Windows.Forms.Button();
            this.BtnSnapshot = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
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
            this.BtnPauseRecorder.Visible = false;
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
            // CkbTopMost
            // 
            this.CkbTopMost.AutoSize = true;
            this.CkbTopMost.Location = new System.Drawing.Point(49, 244);
            this.CkbTopMost.Name = "CkbTopMost";
            this.CkbTopMost.Size = new System.Drawing.Size(48, 16);
            this.CkbTopMost.TabIndex = 7;
            this.CkbTopMost.Text = "顶置";
            this.CkbTopMost.UseVisualStyleBackColor = true;
            this.CkbTopMost.CheckedChanged += new System.EventHandler(this.CkbTopMost_CheckedChanged);
            // 
            // BtnDrawRect
            // 
            this.BtnDrawRect.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDrawRect.BackgroundImage = global::ScreenRecorder.Properties.Resources.draw_rect;
            this.BtnDrawRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDrawRect.FlatAppearance.BorderSize = 0;
            this.BtnDrawRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDrawRect.Location = new System.Drawing.Point(46, 192);
            this.BtnDrawRect.Name = "BtnDrawRect";
            this.BtnDrawRect.Size = new System.Drawing.Size(32, 32);
            this.BtnDrawRect.TabIndex = 8;
            this.BtnDrawRect.UseVisualStyleBackColor = false;
            this.BtnDrawRect.Click += new System.EventHandler(this.BtnDrawRect_Click);
            // 
            // BtnSnapshot
            // 
            this.BtnSnapshot.BackgroundImage = global::ScreenRecorder.Properties.Resources.snapshot;
            this.BtnSnapshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSnapshot.FlatAppearance.BorderSize = 0;
            this.BtnSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSnapshot.Location = new System.Drawing.Point(107, 192);
            this.BtnSnapshot.Name = "BtnSnapshot";
            this.BtnSnapshot.Size = new System.Drawing.Size(32, 32);
            this.BtnSnapshot.TabIndex = 8;
            this.BtnSnapshot.UseVisualStyleBackColor = true;
            this.BtnSnapshot.Click += new System.EventHandler(this.BtnSnapshot_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImage = global::ScreenRecorder.Properties.Resources.setting;
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.FlatAppearance.BorderSize = 0;
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Location = new System.Drawing.Point(164, 192);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(32, 32);
            this.BtnSettings.TabIndex = 9;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.LinkSettingForm_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.BackgroundImage = global::ScreenRecorder.Properties.Resources.about;
            this.BtnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Location = new System.Drawing.Point(213, 192);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(32, 32);
            this.BtnAbout.TabIndex = 9;
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 281);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnSnapshot);
            this.Controls.Add(this.BtnDrawRect);
            this.Controls.Add(this.CkbTopMost);
            this.Controls.Add(this.LblRecordDuration);
            this.Controls.Add(this.BtnPauseRecorder);
            this.Controls.Add(this.BtnStartRecorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.CheckBox CkbTopMost;
        private System.Windows.Forms.Button BtnDrawRect;
        private System.Windows.Forms.Button BtnSnapshot;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnAbout;
    }
}

