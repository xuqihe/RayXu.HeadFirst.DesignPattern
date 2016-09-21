using RayXu.HeadFirst.DesignPattern.Adapter.Abstract;
using RayXu.HeadFirst.DesignPattern.Adapter.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuckInfo duck = new MallardDuckInfo();
            WildTurkeyInfo turkey = new WildTurkeyInfo();

            IDuck turkeyAdapter = new TurkeyToDuckAdapter(turkey);
            Console.WriteLine("--== Turkey To Duck Adapter ==--");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
            Console.WriteLine();

            ITurkey duckAdapter = new DuckToTurkeyAdapter(duck);
            Console.WriteLine("--== Duck To Turkey Adapter ==--");
            duckAdapter.Gobble();
            duckAdapter.Fly();

            Console.ReadLine();
        }
    }
}
