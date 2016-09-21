using RayXu.HeadFirst.DesignPattern.Factory.Abstract;
using RayXu.HeadFirst.DesignPattern.Factory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--== NYPizzaStore Order cheese ==--");
            PizzaStoreInfo nyPizzaStore = new NYPizzaStoreInfo();
            nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine();

            Console.WriteLine("--== ChicagoPizzaStore Order cheese ==--");
            PizzaStoreInfo chicagoPizzaStore = new CHIPizzaStoreInfo();
            chicagoPizzaStore.OrderPizza("cheese");

            Console.ReadLine();
        }
    }
}
