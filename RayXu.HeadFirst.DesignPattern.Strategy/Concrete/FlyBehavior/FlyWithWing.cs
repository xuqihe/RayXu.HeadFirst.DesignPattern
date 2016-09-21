using RayXu.HeadFirst.DesignPattern.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Strategy.Concrete
{
    public class FlyWithWing : IFlyBehavior
    {
        #region IFlyBehavior Methods
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings.");
        }
        #endregion
    }
}
