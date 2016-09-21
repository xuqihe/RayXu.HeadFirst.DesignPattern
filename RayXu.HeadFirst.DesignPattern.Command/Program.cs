using RayXu.HeadFirst.DesignPattern.Command.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControlInfo remoteControl = new RemoteControlInfo();

            LightInfo livingRoomLight = new LightInfo("Living Room");
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            Console.WriteLine("--== Living Room Light ==--");
            remoteControl.OnButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(0);
            Console.WriteLine();

            CeilingFanInfo drawingRoomCeilingFan = new CeilingFanInfo("Drawing Room");
            CeilingFanHighCommand drawingRoomCeilingFanHigh = new CeilingFanHighCommand(drawingRoomCeilingFan);
            CeilingFanLowCommand drawingRoomCeilingFanLow = new CeilingFanLowCommand(drawingRoomCeilingFan);
            remoteControl.SetCommand(1, drawingRoomCeilingFanHigh, drawingRoomCeilingFanLow);
            Console.WriteLine("--== Drawing Room Ceiling Fan ==--");
            remoteControl.OnButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(1);


            Console.ReadLine();
        }
    }
}
