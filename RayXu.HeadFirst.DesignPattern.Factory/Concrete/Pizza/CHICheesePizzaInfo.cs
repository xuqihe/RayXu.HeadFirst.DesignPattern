/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/7 15:22:36
*  Description:  
*
*  Update History:
*  2016/5/7 15:22:36：Create.
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
    public class CHICheesePizzaInfo : PizzaInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public CHICheesePizzaInfo()
        {
            base.Name = "Chicago Style Deep Dish Cheese Pizza";
            base.Dough = "Extra Thick Crust Dough";
            base.Sauce = "Plum Tomato Sauce";

            base.Toppings.Add("Shredded Mozzarella Cheese");
        }
        #endregion

        #region PizzaInfo Methods
        public override void Box()
        {
            //base.Box();
            Console.WriteLine("Place pizza in Chicago Style Pizza Store box");
        }
        #endregion
    }
}
