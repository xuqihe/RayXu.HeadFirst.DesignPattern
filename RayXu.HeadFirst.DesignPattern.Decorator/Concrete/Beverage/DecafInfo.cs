using RayXu.HeadFirst.DesignPattern.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Concrete
{
    public class DecafInfo : BeverageInfo
    {
        public DecafInfo()
        { }

        #region BeverageInfo Methods
        public override double Cost()
        {
            return 1.05;
        }

        public override string GetDescription()
        {
            return "Decaf";
        }
        #endregion
    }
}
