using RayXu.HeadFirst.DesignPattern.TemplateMethod.Abstract;
using RayXu.HeadFirst.DesignPattern.TemplateMethod.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverageInfo coffee = new CoffeeInfo();
            CaffeineBeverageInfo tea = new TeaInfo();

            Console.WriteLine("--== Making coffee ==--");
            coffee.PrepareRecipe();
            Console.WriteLine();

            Console.WriteLine("--== Making tea ==--");
            tea.PrepareRecipe();

            Console.ReadLine();
        }
    }
}
