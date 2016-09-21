using RayXu.HeadFirst.DesignPattern.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Concrete
{
    public class MochaInfo : CondimentDecoratorInfo
    {
        BeverageInfo beverage;

        public MochaInfo(BeverageInfo beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + GetCostBySize(base.Size);
        }

        private double GetCostBySize(BeverageSize size)
        {
            switch (size)
            {
                case BeverageSize.TALL:
                    return Convert.ToDouble(ConfigurationManager.AppSettings["MochaSizeTall"]);
                case BeverageSize.GRANDE:
                    return Convert.ToDouble(ConfigurationManager.AppSettings["MochaSizeGrande"]);
                case BeverageSize.VENTI:
                    return Convert.ToDouble(ConfigurationManager.AppSettings["MochaSizeVenti"]);
                default:
                    return .20;
            }
        }
    }
}
