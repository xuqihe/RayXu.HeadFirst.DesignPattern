using RayXu.HeadFirst.DesignPattern.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Strategy.Concrete
{
    public class MallardDuckInfo : DuckInfo
    {
        #region Constructors
        public MallardDuckInfo()
        {
            QuackBehavior = new SqueakQuack();
            FlyBehavior = new FlyWithWing();
        }
        #endregion

        #region DuckInfo Methods
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
        #endregion
    }
}
