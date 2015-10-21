using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommandPattern 
{
    class LightOnCommand : command
   {
       private ligth light;
        public LightOnCommand(ligth light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.on();
        }
        public void undo()
        {
            light.off();
        }
   }
}
