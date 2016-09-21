/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/7 15:27:16
*  Description:  
*
*  Update History:
*  2016/5/7 15:27:16：Create.
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
    public class NYCheesePizzaInfo : PizzaInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public NYCheesePizzaInfo()
        {
            base.Name = "NY Style Sauce and Cheese Pizza";
            base.Dough = "Thin Crust Dough";
            base.Sauce = "Martinara Sauce";

            base.Toppings.Add("Greated Reggiano Cheese");
        }
        #endregion

        #region PizzaInfo Methods
        public override void Cut()
        {
            //base.Cut();
            Console.WriteLine("Cutting the pizza into square slices");
        }
        #endregion
    }
}
