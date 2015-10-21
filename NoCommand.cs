using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class NoCommand:command
    {
        public void execute(){}
        public void undo() { }
    }
}
