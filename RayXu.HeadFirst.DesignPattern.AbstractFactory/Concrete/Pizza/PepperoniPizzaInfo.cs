/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 14:48:53
*  Description:  
*
*  Update History:
*  2016/5/8 14:48:53：Create.
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
    public class PepperoniPizzaInfo : PizzaInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public PepperoniPizzaInfo(IPizzaIngredientFactory factory) : base(factory)
        { }
        #endregion

        #region PizzaInfo Methods
        public override void Prepare()
        {
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
            Pepperoni = IngredientFactory.CreatePepporoni();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Preparing: " + Name );
            sb.AppendLine(Dough.Name);
            sb.AppendLine(Sauce.Name);
            sb.AppendLine(Cheese.Name);
            sb.AppendLine(Pepperoni.Name);

            Console.WriteLine(sb.ToString());
        }
        #endregion
    }
}
