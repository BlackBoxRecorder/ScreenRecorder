namespace ScreenRecorder
{
    partial class AboutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BbrLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ScreenLibLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "一个简单好用的开源录屏软件";
            // 
            // BbrLink
            // 
            this.BbrLink.AutoSize = true;
            this.BbrLink.Location = new System.Drawing.Point(49, 43);
            this.BbrLink.Name = "BbrLink";
            this.BbrLink.Size = new System.Drawing.Size(101, 12);
            this.BbrLink.TabIndex = 1;
            this.BbrLink.TabStop = true;
            this.BbrLink.Text = "BlackBoxRecorder";
            this.BbrLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BbrLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "by";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Location = new System.Drawing.Point(22, 99);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(29, 12);
            this.LblVersion.TabIndex = 2;
            this.LblVersion.Text = "版本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "鸣谢";
            // 
            // ScreenLibLink
            // 
            this.ScreenLibLink.AutoSize = true;
            this.ScreenLibLink.Location = new System.Drawing.Point(60, 69);
            this.ScreenLibLink.Name = "ScreenLibLink";
            this.ScreenLibLink.Size = new System.Drawing.Size(107, 12);
            this.ScreenLibLink.TabIndex = 3;
            this.ScreenLibLink.TabStop = true;
            this.ScreenLibLink.Text = "ScreenRecorderLib";
            this.ScreenLibLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ScreenLibLink_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 141);
            this.Controls.Add(this.ScreenLibLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblVersion);
            this.Controls.Add(this.BbrLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "关于";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel BbrLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel ScreenLibLink;
    }
}