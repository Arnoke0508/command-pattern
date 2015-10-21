using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class GarageDoor
    {
        private ligth ligthGarage = new ligth("Garage");
        public void up()
        {
            Console.WriteLine("up you go");
        }
        public void down()
        {
            Console.WriteLine("down you go");
        }
        public void stop()
        {
            Console.WriteLine("stop hammertime");
        }
        public void ligthOn()
        {
            ligthGarage.on();  
        }
        public void lightoff()
        {
            ligthGarage.off();
        }
    }
}
