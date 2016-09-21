using RayXu.HeadFirst.DesignPattern.State.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.State
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachineInfo marchine = new GumballMachineInfo(3);
            marchine.InsertQuarter();
            marchine.TurnCrank();
            marchine.InsertQuarter();
            marchine.EjectQuarter();

            marchine.Refill(5);
            Console.ReadLine();
        }
    }
}
