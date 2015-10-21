using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class GarageDoorDownCommand:command
    {
        GarageDoor GarageDoor;
        public GarageDoorDownCommand(GarageDoor GarageDoor)
        {
            this.GarageDoor = GarageDoor;
        }
        public void execute()
        {
            GarageDoor.down();
        }
        public void undo()
        {
            GarageDoor.up();
        }
        
    }
}
