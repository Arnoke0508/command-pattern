﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CeilingFanHighCommand:command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        
        public CeilingFanHighCommand(CeilingFan ceilingFan){
            this.ceilingFan = ceilingFan;
        }

        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.high();
        }

        public void undo()
        {
            if(prevSpeed == CeilingFan.HIGH)
            {
                ceilingFan.high();
            }
            else if(prevSpeed == CeilingFan.MEDIUM)
            {
                ceilingFan.medium();
            }
            else if (prevSpeed == CeilingFan.LOW)
            {
                ceilingFan.low();
            }
            else if (prevSpeed == CeilingFan.OFF)
            {
                ceilingFan.off();
            }
        }
    }
}
