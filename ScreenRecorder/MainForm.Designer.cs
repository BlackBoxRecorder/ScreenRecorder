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
            this.gridPanel2 = new AntdUI.GridPanel();
            this.BtnSettings = new AntdUI.Button();
            this.BtnSnapshot = new AntdUI.Button();
            this.BtnDrawRect = new AntdUI.Button();
            this.BtnPauseRecorder = new AntdUI.Button();
            this.BtnStartRecorder = new AntdUI.Button();
            this.LblRecordDuration = new AntdUI.Label();
            this.gridPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel2
            // 
            this.gridPanel2.Controls.Add(this.BtnSettings);
            this.gridPanel2.Controls.Add(this.BtnSnapshot);
            this.gridPanel2.Controls.Add(this.BtnDrawRect);
            this.gridPanel2.Location = new System.Drawing.Point(13, 207);
            this.gridPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.gridPanel2.Name = "gridPanel2";
            this.gridPanel2.Size = new System.Drawing.Size(228, 53);
            this.gridPanel2.Span = "33% 34% 33%;";
            this.gridPanel2.TabIndex = 2;
            this.gridPanel2.Text = "gridPanel2";
            // 
            // BtnSettings
            // 
            this.BtnSettings.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.BtnSettings.Icon = ((System.Drawing.Image)(resources.GetObject("BtnSettings.Icon")));
            this.BtnSettings.Location = new System.Drawing.Point(157, 4);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(67, 45);
            this.BtnSettings.TabIndex = 2;
            this.BtnSettings.Text = "设置";
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnSnapshot
            // 
            this.BtnSnapshot.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.BtnSnapshot.Icon = ((System.Drawing.Image)(resources.GetObject("BtnSnapshot.Icon")));
            this.BtnSnapshot.Location = new System.Drawing.Point(79, 4);
            this.BtnSnapshot.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSnapshot.Name = "BtnSnapshot";
            this.BtnSnapshot.Size = new System.Drawing.Size(70, 45);
            this.BtnSnapshot.TabIndex = 1;
            this.BtnSnapshot.Text = "截图";
            this.BtnSnapshot.Click += new System.EventHandler(this.BtnSnapshot_Click);
            // 
            // BtnDrawRect
            // 
            this.BtnDrawRect.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.BtnDrawRect.Icon = ((System.Drawing.Image)(resources.GetObject("BtnDrawRect.Icon")));
            this.BtnDrawRect.Location = new System.Drawing.Point(4, 4);
            this.BtnDrawRect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDrawRect.Name = "BtnDrawRect";
            this.BtnDrawRect.Size = new System.Drawing.Size(67, 45);
            this.BtnDrawRect.TabIndex = 0;
            this.BtnDrawRect.Text = "选区";
            this.BtnDrawRect.Click += new System.EventHandler(this.BtnDrawRect_Click);
            // 
            // BtnPauseRecorder
            // 
            this.BtnPauseRecorder.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.BtnPauseRecorder.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPauseRecorder.Location = new System.Drawing.Point(13, 145);
            this.BtnPauseRecorder.Name = "BtnPauseRecorder";
            this.BtnPauseRecorder.Size = new System.Drawing.Size(228, 55);
            this.BtnPauseRecorder.TabIndex = 2;
            this.BtnPauseRecorder.Text = "暂停录制";
            this.BtnPauseRecorder.Click += new System.EventHandler(this.BtnPauseRecorder_Click);
            // 
            // BtnStartRecorder
            // 
            this.BtnStartRecorder.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(57)))));
            this.BtnStartRecorder.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStartRecorder.Location = new System.Drawing.Point(13, 85);
            this.BtnStartRecorder.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStartRecorder.Name = "BtnStartRecorder";
            this.BtnStartRecorder.Size = new System.Drawing.Size(228, 53);
            this.BtnStartRecorder.TabIndex = 1;
            this.BtnStartRecorder.Text = "开始录屏";
            this.BtnStartRecorder.Click += new System.EventHandler(this.BtnStartRecorder_Click);
            // 
            // LblRecordDuration
            // 
            this.LblRecordDuration.BackColor = System.Drawing.Color.Moccasin;
            this.LblRecordDuration.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblRecordDuration.Location = new System.Drawing.Point(13, 22);
            this.LblRecordDuration.Margin = new System.Windows.Forms.Padding(4);
            this.LblRecordDuration.Name = "LblRecordDuration";
            this.LblRecordDuration.Size = new System.Drawing.Size(224, 53);
            this.LblRecordDuration.TabIndex = 0;
            this.LblRecordDuration.Text = "00:00:00";
            this.LblRecordDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.LblRecordDuration);
            this.Controls.Add(this.BtnStartRecorder);
            this.Controls.Add(this.gridPanel2);
            this.Controls.Add(this.BtnPauseRecorder);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 560);
            this.MinimumSize = new System.Drawing.Size(220, 280);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录屏";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

            this.gridPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.Label LblRecordDuration;
        private AntdUI.GridPanel gridPanel2;
        private AntdUI.Button BtnSettings;
        private AntdUI.Button BtnSnapshot;
        private AntdUI.Button BtnDrawRect;
        private AntdUI.Button BtnStartRecorder;
        private AntdUI.Button BtnPauseRecorder;
    }
}

