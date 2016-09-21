using RayXu.HeadFirst.DesignPattern.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Strategy.Concrete
{
    public class ModelDuckInfo : DuckInfo
    {
        #region Constructors
        public ModelDuckInfo()
        {
            QuackBehavior = new SqueakQuack();
            FlyBehavior = new FlyNoWay();
        }
        #endregion

        #region DuckInfo Methods
        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
        #endregion
    }
}
