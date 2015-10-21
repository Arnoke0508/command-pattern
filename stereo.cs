using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class stereo
    {
        private string Plaats;

        public stereo(string Plaats)
        {
            
            this.Plaats = Plaats;
        }
        public void on() { Console.WriteLine("radio wordt opgezet maar komt nog geen geluid in de"+Plaats); }
        public void off() { Console.WriteLine("radio is uit in de"+ Plaats); }
        public void setCD() { Console.WriteLine("de stereo gaat de CD opzettenin de" + Plaats); }
        public void setDVD() { Console.WriteLine("de stereo gaat de DVD opzettenin de" + Plaats); }
        public void setRadio() { Console.WriteLine("De stereo gaat de Radio opzettenin de" + Plaats); }
        public void setVolume(int volume) { Console.WriteLine("er is eindelijk geluid met een volume van " + volume + "in de" + Plaats); }
    }
}
