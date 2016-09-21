/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/7 15:16:37
*  Description:  
*
*  Update History:
*  2016/5/7 15:16:37：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Factory.Abstract
{
    public abstract class PizzaStoreInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region Methods
        public PizzaInfo OrderPizza(string type)
        {
            PizzaInfo pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract PizzaInfo CreatePizza(string type);
        #endregion
    }
}
