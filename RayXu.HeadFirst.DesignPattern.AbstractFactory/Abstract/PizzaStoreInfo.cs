/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 14:53:13
*  Description:  
*
*  Update History:
*  2016/5/8 14:53:13：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.AbstractFactory.Abstract
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
        protected abstract PizzaInfo CreatePizza(string type);

        public PizzaInfo OrderPizza(string type)
        {
            PizzaInfo pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        #endregion
    }
}
