using RayXu.HeadFirst.DesignPattern.Iterator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenuInfo pancakeHouseMenu = new PancakeHouseMenuInfo();
            DinnerMenuInfo dinnerMenu = new DinnerMenuInfo();
            CafeMenuInfo cafeMenu = new CafeMenuInfo();

            WaitressInfo waitress = new WaitressInfo(pancakeHouseMenu, dinnerMenu, cafeMenu);
            waitress.PrintMenu();

            Console.ReadLine();
        }
    }
}
