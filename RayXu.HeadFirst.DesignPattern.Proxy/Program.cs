using RayXu.HeadFirst.DesignPattern.Proxy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirlInfo girl = new SchoolGirlInfo();
            girl.Name = "SHERRY";
            string pursuitName = "RAY";
            ProxyInfo proxy = new ProxyInfo(girl, pursuitName);
            proxy.GiveFlower();
            Console.ReadLine();
        }
    }
}
