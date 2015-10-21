using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class SimpleRemoteControl
    {
        command slot;
        public SimpleRemoteControl() { }

        public void setCommand(command command)
        {
            slot = command;
        }
        public void buttonWasPressed()
        {
            slot.execute();
        }
      
        
    }
}
