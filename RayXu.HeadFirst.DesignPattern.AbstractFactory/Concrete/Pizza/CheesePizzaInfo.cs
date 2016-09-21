/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 14:13:40
*  Description:  
*
*  Update History:
*  2016/5/8 14:13:40：Create.
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
    public class CheesePizzaInfo : PizzaInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public CheesePizzaInfo(IPizzaIngredientFactory factory) : base(factory)
        { }
        #endregion

        #region PizzaInfo Methods
        public override void Prepare()
        {
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Preparing: " + Name);
            sb.AppendLine(Dough.Name);
            sb.AppendLine(Sauce.Name);
            sb.AppendLine(Cheese.Name);

            Console.WriteLine(sb.ToString());
        }
        #endregion
    }
}
