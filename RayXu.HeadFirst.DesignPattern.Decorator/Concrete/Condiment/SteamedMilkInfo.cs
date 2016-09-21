using RayXu.HeadFirst.DesignPattern.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Concrete
{
    public class SteamedMilk : CondimentDecoratorInfo
    {
        BeverageInfo beverage;

        public SteamedMilk(BeverageInfo beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Steamed Milk";
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
