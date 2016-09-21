using RayXu.HeadFirst.DesignPattern.Decorator.Abstract;
using RayXu.HeadFirst.DesignPattern.Decorator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageInfo beverage1 = new ExpressoInfo();
            Console.WriteLine("--== beverage1 ==--");
            //Console.WriteLine(beverage1.GetDescription() + ". $" + beverage1.Cost());
            beverage1.Dislpay();

            BeverageInfo beverage2 = new DarkRoastInfo();
            beverage2.Size = BeverageSize.GRANDE;
            beverage2 = new MochaInfo(beverage2);
            beverage2 = new MochaInfo(beverage2);
            beverage2 = new WhipInfo(beverage2);
            Console.WriteLine("--== beverage2 ==--");
            //Console.WriteLine(beverage2.GetDescription() + ". $" + beverage2.Cost());
            beverage2.Dislpay();

            BeverageInfo beverage3 = new DarkRoastInfo();
            beverage3 = new SoyInfo(beverage3);
            beverage3 = new MochaInfo(beverage3);
            beverage3 = new WhipInfo(beverage3);
            Console.WriteLine("--== beverage3 ==--");
            //Console.WriteLine(beverage3.GetDescription() + ". $" + beverage3.Cost());
            beverage3.Dislpay();

            Console.ReadLine();
        }
    }
}
