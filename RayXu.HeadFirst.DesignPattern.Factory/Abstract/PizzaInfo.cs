/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/7 15:07:27
*  Description:  
*  
*  Update History:
*  2016/5/7 15:07:27：Create.
*
**************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Factory.Abstract
{
    public class PizzaInfo
    {
        #region Members
        #endregion

        #region  Properties
        public virtual string Name { get; set; }
        public virtual string Dough { get; set; }
        public virtual string Sauce { get; set; }
        public virtual ArrayList Toppings { get; set; } = new ArrayList();
        #endregion

        #region Constructors
        #endregion

        #region Methods
        public virtual void Prepare()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Preparing name: " + Name);
            sb.AppendLine("Tossing dough: " + Dough);
            sb.AppendLine("Adding sauce: " + Sauce);
            sb.Append("Adding toppings: ");
            foreach (string topping in Toppings)
            {
                sb.Append(topping + ", ");
            }
            sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        #endregion
    }
}
