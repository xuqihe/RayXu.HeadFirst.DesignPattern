using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoilerInfo boiler1 = ChocolateBoilerInfo.GetInstance();
            Console.WriteLine("--== boiler1 ==--");
            boiler1.Fill();
            boiler1.Boil();
            boiler1.Drain();
            Console.WriteLine();

            ChocolateBoilerInfo boiler2 = ChocolateBoilerInfo.GetInstance();
            Console.WriteLine("--== boiler2 ==--");
            boiler2.Fill();
            boiler2.Boil();
            boiler2.Drain();

            Console.ReadLine();
        }
    }
}
