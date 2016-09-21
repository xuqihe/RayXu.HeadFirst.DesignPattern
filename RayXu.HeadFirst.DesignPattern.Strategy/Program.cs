using RayXu.HeadFirst.DesignPattern.Strategy.Abstract;
using RayXu.HeadFirst.DesignPattern.Strategy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            DuckInfo duck = new MallardDuckInfo();
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            Console.WriteLine("--== After Change... ==--");
            duck.SetFlyBehavior(new FlyWithRocketPower());
            duck.PerformFly();
            Console.ReadLine();
        }
    }
}
