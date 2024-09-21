using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenRecorderLib;

namespace ScreenRecorder
{
    internal class RecordingSourceItem
    {
        public string Name { get; set; }

        public RecordingSourceType Type { get; set; }
        public RecordingSourceBase Source { get; set; }
    }

    public enum RecordingSourceType
    {
        [Description("显示器")]
        Monitor,

        [Description("窗体")]
        Window,

        [Description("摄像头")]
        Camera
    }
}
