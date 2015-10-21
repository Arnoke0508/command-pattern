using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CeilingFan
    {
        public  const  int HIGH = 3;
        public  const int MEDIUM = 2;
        public  const int LOW = 1;
        public  const int OFF = 0;
        string location;
        int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed= OFF;
        }
        public void high()
        {
            speed = HIGH;
            Console.WriteLine("High wind in " + location);
        }
        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine("medium wind in " + location);
        }
        public void low()
        {
            speed = LOW;
            Console.WriteLine("lage wind in " + location);
        }
        public void off()
        {
            speed = OFF;
            Console.WriteLine("geen wind in " + location);
        }
        public int getSpeed()
        {
            return speed;
        }
    }
}
