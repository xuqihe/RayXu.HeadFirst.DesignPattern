/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 14:52:36
*  Description:  
*
*  Update History:
*  2016/5/8 14:52:36：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.AbstractFactory.Concrete
{
    public class CHIPizzaStoreInfo : PizzaStoreInfo
    {
        #region Members
        private IPizzaIngredientFactory IngredientFactory = new CHIPizzaIngredientFactoryInfo();
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
                    pizza = new CheesePizzaInfo(IngredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizzaInfo(IngredientFactory);
                    pizza.Name = "Chicago Style Clam Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizzaInfo(IngredientFactory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
            }
            return pizza;
        }
        #endregion
    }
}
