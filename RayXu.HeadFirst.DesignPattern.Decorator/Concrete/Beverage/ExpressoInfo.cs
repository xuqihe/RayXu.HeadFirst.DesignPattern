using RayXu.HeadFirst.DesignPattern.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace RayXu.HeadFirst.DesignPattern.Decorator.Concrete
{
    public class ExpressoInfo : BeverageInfo
    {
        public ExpressoInfo()
        { }

        #region BeverageInfo Methods
        public override double Cost()
        {
            return 1.5 + GetCostBySize(base.Size);
        }

        public override string GetDescription()
        {
            return "Expresso";
        }
        #endregion

        #region Private Methods
        private double GetCostBySize(BeverageSize size)
        {
            switch (size)
            {
                case BeverageSize.TALL:
                    return Convert.ToDouble(ConfigurationManager.AppSettings["ExpressoSizeTall"]);
                case BeverageSize.GRANDE:
                    return Convert.ToDouble(ConfigurationManager.AppSettings["ExpressoSizeGrande"]);
                case BeverageSize.VENTI:
                    return Convert.ToDouble(ConfigurationManager.AppSettings["ExpressoSizeVenti"]);
                default:
                    return 0.1;
            }
        }
        #endregion
    }
}