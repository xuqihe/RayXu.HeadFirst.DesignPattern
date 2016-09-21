using RayXu.HeadFirst.DesignPattern.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Concrete
{
    public class DarkRoastInfo : BeverageInfo
    {
        public DarkRoastInfo()
        { }

        #region BeverageInfo Methods
        public override double Cost()
        {
            return .99;
        }

        public override string GetDescription()
        {
            return "Dark Roast";
        }
        #endregion
    }
}
