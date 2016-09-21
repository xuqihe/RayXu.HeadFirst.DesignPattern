/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/14 10:10:17
*  Description:  
*
*  Update History:
*  2016/5/14 10:10:17：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.State.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.State.Concrete
{
    public class NoQuarterState : IState
    {
        #region Members
        private GumballMachineInfo _gumballMachine;
        #endregion

        #region  Properties
        public MarchineStatus StatusName
        {
            get
            {
                return MarchineStatus.NoQuarterState;
            }
        }
        #endregion

        #region Constructors
        public NoQuarterState(GumballMachineInfo marchine)
        {
            _gumballMachine = marchine;
            _gumballMachine.CurrentState = this;
        }
        #endregion

        #region IState Methods
        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.CurrentState = new HasQuarterState(_gumballMachine).GetCurrentState();
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject the quarter since you haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You can't turne the crank since you haven't inserted a quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You can't dispense since you haven't inserted a quarter");
        }

        public IState GetCurrentState()
        {
            return _gumballMachine.CurrentState ?? this;
        }
        #endregion
    }
}
