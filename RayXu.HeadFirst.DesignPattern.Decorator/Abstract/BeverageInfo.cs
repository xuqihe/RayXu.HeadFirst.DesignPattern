using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Abstract
{
    public enum BeverageSize
    {
        TALL,
        GRANDE,
        VENTI
    }

    public abstract class BeverageInfo
    {
        public BeverageSize Size { get; set; }

        public virtual string GetDescription()
        {
            return "Unknown Beverage";
        }

        public abstract double Cost();

        public virtual void Dislpay()
        {
            Console.WriteLine(GetDescription() + ". $" + Cost());
        }
    }
}
