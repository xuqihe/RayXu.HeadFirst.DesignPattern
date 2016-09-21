using RayXu.HeadFirst.DesignPattern.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Concrete
{
    public class HouseBlendInfo : BeverageInfo
    {
        public HouseBlendInfo()
        { }

        #region BeverageInfo Methods
        public override double Cost()
        {
            return .89;
        }

        public override string GetDescription()
        {
            return "House Blend";
        }
        #endregion
    }
}
