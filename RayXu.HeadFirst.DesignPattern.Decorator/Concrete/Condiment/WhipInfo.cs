using RayXu.HeadFirst.DesignPattern.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Concrete
{
    public class WhipInfo : CondimentDecoratorInfo
    {
        BeverageInfo beverage;

        public WhipInfo(BeverageInfo beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
