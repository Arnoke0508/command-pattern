using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class StereoOnWithCDCommand:command
    {
        stereo stereo;
        public StereoOnWithCDCommand(stereo stereo)
        {
            this.stereo = stereo;
        }
        public void execute()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
        public void undo()
        {
            stereo.off();
        }
    }
}
