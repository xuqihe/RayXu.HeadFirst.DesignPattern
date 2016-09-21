/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/14 10:14:20
*  Description:  
*
*  Update History:
*  2016/5/14 10:14:20：Create.
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
    public class HasQuarterState : IState
    {
        #region Members
        private GumballMachineInfo _gumballMachine;
        #endregion

        #region  Properties
        public MarchineStatus StatusName
        {
            get
            {
                return MarchineStatus.HasQuarterState;
            }
        }
        #endregion

        #region Constructors
        public HasQuarterState(GumballMachineInfo marchine)
        {
            _gumballMachine = marchine;
            _gumballMachine.CurrentState = this;
        }
        #endregion

        #region IState Methods
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter since you have inserted a quarter ");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You ejected the quarter");
            _gumballMachine.CurrentState = new NoQuarterState(_gumballMachine).GetCurrentState();
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned the crank");
            _gumballMachine.CurrentState = new SoldState(_gumballMachine).GetCurrentState();
        }

        public void Dispense()
        {
            Console.WriteLine("You can't dispense since you haven't turned the crank");
        }

        public IState GetCurrentState()
        {
            return _gumballMachine.CurrentState ?? this;
        }
        #endregion
    }
}
