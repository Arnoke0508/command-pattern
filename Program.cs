using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////SimpleRemoteControl remote = new SimpleRemoteControl();
            ////////ligth ligth = new ligth();
            ////////GarageDoor garageDoor = new GarageDoor();
            ////////LightOnCommand ligthon = new LightOnCommand(ligth);
            ////////GarageDoorOpenCommand garageOpen= new GarageDoorOpenCommand(garageDoor);
            ////////remote.setCommand(ligthon);
            ////////remote.buttonWasPressed();

            ////////remote.setCommand(garageOpen);
            ////////remote.buttonWasPressed();

            //////RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();
            //////ligth livingRoomLigth = new ligth("Living Room");
            //////ligth kitchenLight = new ligth("kitchen");
            //////GarageDoor garageDoor = new GarageDoor();
            //////stereo stereo = new stereo("Living Room");

            //////LightOnCommand livingRoomLigthOn = new LightOnCommand(livingRoomLigth);
            //////LightOffCommand livingRoomLigthOff = new LightOffCommand(livingRoomLigth);
            //////LightOnCommand KitchenLigthOn = new LightOnCommand(kitchenLight);
            //////LightOffCommand KitchenLigthOff = new LightOffCommand(kitchenLight);

            //////GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            //////GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            //////StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            //////StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            //////remoteControl.setCommand(0, livingRoomLigthOn, livingRoomLigthOff);
            //////remoteControl.setCommand(1, KitchenLigthOn, KitchenLigthOff);
            //////remoteControl.setCommand(2, stereoOnWithCD, stereoOff);

            //////Console.WriteLine(remoteControl.toString());

            //////remoteControl.onButtonWasPushed(0);
            //////remoteControl.offButtonWasPushed(0);
            //////remoteControl.onButtonWasPushed(1);
            //////remoteControl.offButtonWasPushed(1);
            //////remoteControl.onButtonWasPushed(2);
            //////remoteControl.offButtonWasPushed(2);
            //////Console.ReadLine();

            ////RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();
            ////ligth livingRoomLigth = new ligth("Living Room");

            ////LightOnCommand livingRoomLigthOn = new LightOnCommand(livingRoomLigth);
            ////LightOffCommand livingRoomLigthOff = new LightOffCommand(livingRoomLigth);

            ////remoteControl.setCommand(0, livingRoomLigthOn, livingRoomLigthOff);
            ////remoteControl.onButtonWasPushed(0);
            ////remoteControl.offButtonWasPushed(0);
            ////Console.WriteLine(remoteControl.toString());
            ////remoteControl.undoButtonWasPushed();
            ////remoteControl.offButtonWasPushed(0);
            ////remoteControl.onButtonWasPushed(0);
            ////Console.WriteLine(remoteControl.toString());
            ////remoteControl.undoButtonWasPushed();
            ////Console.ReadLine();
            //RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            //CeilingFan ceilingFan = new CeilingFan("Living Room");

            //CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            //CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            //CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            //remoteControl.setCommand(0, ceilingFanMedium, ceilingFanOff);
            //remoteControl.setCommand(1, ceilingFanHigh, ceilingFanOff);

            //remoteControl.onButtonWasPushed(0);
            //remoteControl.offButtonWasPushed(0);
            //Console.WriteLine(remoteControl.toString());
            //remoteControl.undoButtonWasPushed();

            //remoteControl.onButtonWasPushed(1);
            //Console.WriteLine(remoteControl.toString());
            //remoteControl.undoButtonWasPushed();
            //Console.ReadLine();

            ligth light = new ligth("Living Room");
            stereo stereo = new stereo("Living Room");
            CeilingFan ceilingfan = new CeilingFan("living room");

            LightOnCommand ligthOn = new LightOnCommand(light);
            StereoOnWithCDCommand stereoOn = new StereoOnWithCDCommand(stereo);
            CeilingFanHighCommand CeilingfanOn = new CeilingFanHighCommand(ceilingfan);
            LightOffCommand ligthOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            CeilingFanOffCommand CeilingfanOff = new CeilingFanOffCommand(ceilingfan);

            command[] partyOn ={ligthOn,stereoOn,CeilingfanOn};
            command[] partyOff = { ligthOff, stereoOff, CeilingfanOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand PartyOffMacro = new MacroCommand(partyOff);

            RemoteControlWithUndo remotecontrol = new RemoteControlWithUndo();

            remotecontrol.setCommand(0, partyOnMacro, PartyOffMacro);
            Console.WriteLine(remotecontrol.toString());
            Console.WriteLine("===Pushing Macro On ===");
            remotecontrol.onButtonWasPushed(0);
            Console.WriteLine("===Pushing Macro Off ===");
            remotecontrol.offButtonWasPushed(0);
            Console.WriteLine("===Pushing Macro undo ===");
            remotecontrol.undoButtonWasPushed();
            Console.ReadLine();


        }
    }
}
