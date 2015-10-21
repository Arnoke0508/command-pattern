using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    
    class RemoteControl
    {
        command[] onCommands;
        command[] offCommands;
        
        public RemoteControl(){
        onCommands= new command[7];
        offCommands= new command[7];

        command noCommand=new NoCommand();
        for (int i = 0;i<7;i++){
        onCommands[i]=noCommand;
        offCommands[i] = noCommand;
        }
    }
        public void setCommand(int slot, command onCommand,command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void onButtonWasPushed(int slot)
        {
            if(onCommands[slot] !=null)
            onCommands[slot].execute();
        }
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
        }
        public String toString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot" + i + "] " + onCommands[i].ToString()
                    +"     "+offCommands[i].ToString()+"\n");
            }
                return stringBuff.ToString();
        }
    }
}
