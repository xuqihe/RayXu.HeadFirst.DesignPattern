/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/7 15:31:52
*  Description:  
*
*  Update History:
*  2016/5/7 15:31:52：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Factory.Concrete
{
    public class CHIPizzaStoreInfo : PizzaStoreInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region PizzaStoreInfo Methods
        protected override PizzaInfo CreatePizza(string type)
        {
            PizzaInfo pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CHICheesePizzaInfo();
                    break;
                default:
                    break;
            }
            return pizza;
        }
        #endregion
    }
}
