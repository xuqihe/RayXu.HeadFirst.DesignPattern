/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 14:42:13
*  Description:  
*
*  Update History:
*  2016/5/8 14:42:13：Create.
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
    public class ClamPizzaInfo : PizzaInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public ClamPizzaInfo(IPizzaIngredientFactory factory) : base(factory)
        { }
        #endregion

        #region PizzaInfo Methods
        public override void Prepare()
        {
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
            Clams = IngredientFactory.CreateClam();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Preparing: " + Name);
            sb.AppendLine(Dough.Name);
            sb.AppendLine(Sauce.Name);
            sb.AppendLine(Cheese.Name);
            sb.AppendLine(Clams.Name);

            Console.WriteLine(sb.ToString());
        }
        #endregion
    }
}
