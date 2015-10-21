using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class LightOffCommand:command
    {
        private ligth light;
        public LightOffCommand(ligth ligth)
        {
            this.light = ligth;
        }

        public void execute()
        {
            light.off();
        }
        public void undo()
        {
            light.on();
        }
    }
}
