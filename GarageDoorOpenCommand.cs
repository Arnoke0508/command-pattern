using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class GarageDoorOpenCommand: command
    {

        GarageDoor GarageDoor;
        public GarageDoorOpenCommand(GarageDoor GarageDoor)
        {
            this.GarageDoor = GarageDoor;
        }
        public void execute()
        {
            GarageDoor.up();
        }
        public void undo()
        {
            GarageDoor.down();
        }
         
    }
}
