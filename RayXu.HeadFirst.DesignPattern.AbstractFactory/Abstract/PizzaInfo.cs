/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/7 16:49:20
*  Description:  
*
*  Update History:
*  2016/5/7 16:49:20：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.AbstractFactory.Abstract
{
    public abstract class PizzaInfo
    {
        #region Members
        private IPizzaIngredientFactory _ingredientFactory;
        #endregion

        #region  Properties
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public IVeggie[] Veggies { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IClam Clams { get; set; }

        public IPizzaIngredientFactory IngredientFactory { get { return _ingredientFactory; } }
        #endregion

        #region Constructors
        public PizzaInfo(IPizzaIngredientFactory factory)
        {
            _ingredientFactory = factory;
        }
        #endregion

        #region Methods
        public abstract void Prepare();

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
