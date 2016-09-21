/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 14:57:32
*  Description:  
*
*  Update History:
*  2016/5/8 14:57:32：Create.
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
    public class NYPizzaStoreInfo : PizzaStoreInfo
    {
        #region Members
        private IPizzaIngredientFactory IngredientFactory = new NYPizzaIngredientFactoryInfo();
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region Methods
        protected override PizzaInfo CreatePizza(string type)
        {
            PizzaInfo pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizzaInfo(IngredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizzaInfo(IngredientFactory);
                    pizza.Name = "New York Style Clam Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizzaInfo(IngredientFactory);
                    pizza.Name = "New York Style Pepperoni Pizza";
                    break;
            }
            return pizza;
        }
        #endregion
    }
}
