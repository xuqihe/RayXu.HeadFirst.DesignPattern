using RayXu.HeadFirst.DesignPattern.Strategy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Strategy.Abstract
{
    public abstract class DuckInfo
    {
        #region  Properties
        public IQuackBehavior QuackBehavior { get; set; }
        public IFlyBehavior FlyBehavior { get; set; }
        #endregion

        #region Constructors
        public DuckInfo()
        { }

        public DuckInfo(IQuackBehavior quack, IFlyBehavior fly)
        {
            QuackBehavior = quack;
            FlyBehavior = fly;
        }
        #endregion

        #region Methods
        public void SetFlyBehavior(IFlyBehavior fly)
        {
            FlyBehavior = fly;
        }

        public void SetQuackBehavior(IQuackBehavior quack)
        {
            QuackBehavior = quack;
        }

        public void PerformFly()
        {
           FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformSwim()
        {
            Console.WriteLine("All ducks float, even decoys.");
        }

        public abstract void Display();
        #endregion
    }
}
