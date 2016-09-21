using RayXu.HeadFirst.DesignPattern.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Strategy.Concrete
{
    public class MuteQuack : IQuackBehavior
    {
        #region IQuackBehavior Methods
        public void Quack()
        {
            Console.WriteLine("<slience.>");
        }
        #endregion
    }
}
