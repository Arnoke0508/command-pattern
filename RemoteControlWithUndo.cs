using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{

    class RemoteControlWithUndo
    {
        command[] onCommands;
        command[] offCommands;
        command undoCommand;
        public RemoteControlWithUndo()
        {
            onCommands = new command[7];
            offCommands = new command[7];

            command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }
        public void setCommand(int slot, command onCommand, command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            undoCommand.undo();
        }
        public String toString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control With Undo -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot" + i + "] " + onCommands[i].ToString()
                    + "     " + offCommands[i].ToString() + "\n");
            }
            stringBuff.Append("[undo] " + undoCommand.ToString() + "\n");
            return stringBuff.ToString();
        }
    }
}
