using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ScreenRecorder
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private const string bbrLink = "https://" + "github.com/BlackBoxRecorder/ScreenRecorder";
        private const string screenLibUrl = "https://" + "github.com/sskodje/ScreenRecorderLib";

        public string Version { get; set; }

        private void BbrLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(bbrLink);
        }

        private void ScreenLibLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(screenLibUrl);
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            LblVersion.Text = $"版本：{Version}";
        }
    }
}
