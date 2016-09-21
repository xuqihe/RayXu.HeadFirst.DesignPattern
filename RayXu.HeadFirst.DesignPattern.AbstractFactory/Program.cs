using RayXu.HeadFirst.DesignPattern.AbstractFactory.Abstract;
using RayXu.HeadFirst.DesignPattern.AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--==NYPizzaStore Order cheese ==--");
            PizzaStoreInfo nyPizzaStore = new NYPizzaStoreInfo();
            nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine();

            Console.WriteLine("--==ChicagoPizzaStore Order pepperoni ==--");
            PizzaStoreInfo chicagoPizzaStore = new CHIPizzaStoreInfo();
            chicagoPizzaStore.OrderPizza("pepperoni");

            Console.ReadLine();
        }
    }
}
