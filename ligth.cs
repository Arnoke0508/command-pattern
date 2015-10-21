using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class ligth
    {
        string plaats;
        public ligth(string plaats)
        {
            this.plaats = plaats;
        }
        public void on() { Console.WriteLine("let there be light in the"+plaats); }
        public void off() { Console.WriteLine("Darkness in the"+plaats); }
    }
}
