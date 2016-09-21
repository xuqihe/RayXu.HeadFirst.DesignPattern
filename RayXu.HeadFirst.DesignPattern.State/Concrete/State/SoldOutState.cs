/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/14 10:15:13
*  Description:  
*
*  Update History:
*  2016/5/14 10:15:13：Create.
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
    public class SoldOutState : IState
    {
        #region Members
        private GumballMachineInfo _gumballMachine;
        #endregion

        #region  Properties
        public MarchineStatus StatusName
        {
            get
            {
                return MarchineStatus.SoldOutState;
            }
        }
        #endregion

        #region Constructors
        public SoldOutState(GumballMachineInfo marchine)
        {
            _gumballMachine = marchine;
            _gumballMachine.CurrentState = this;
        }
        #endregion

        #region IState Methods
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert the quarter since the marchine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject the quarter since the marchine is sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You can't turn the crank since the marchine is sold out");
        }

        public void Dispense()
        {
            Console.WriteLine("You can't dispense since the marchine is sold out");
        }

        public IState GetCurrentState()
        {
            return _gumballMachine.CurrentState ?? this;
        }
        #endregion
    }
}
