using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class StereoOffCommand:command
    {
        stereo stereo;
        public StereoOffCommand(stereo stereo)
        {
            this.stereo = stereo;
        }
        public void execute()
        {
            stereo.off();
        }
        public void undo()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
    }
}
