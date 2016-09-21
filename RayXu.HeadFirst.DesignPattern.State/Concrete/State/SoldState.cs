/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/14 10:15:41
*  Description:  
*
*  Update History:
*  2016/5/14 10:15:41：Create.
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
    public class SoldState : IState
    {
        #region Members
        private GumballMachineInfo _gumballMachine;
        #endregion

        #region  Properties
        public MarchineStatus StatusName
        {
            get
            {
                return MarchineStatus.SoldState;
            }
        }
        #endregion

        #region Constructors
        public SoldState(GumballMachineInfo marchine)
        {
            _gumballMachine = marchine;
            _gumballMachine.CurrentState = this;
            Dispense();
        }
        #endregion

        #region IState Methods
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert the quarter since the marchine is selling");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject the quarter since you have turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You can't turn the crank twice");
        }

        public void Dispense()
        {
            int winner = new Random().Next(0, 10);
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.ReleaseBall();
                if (winner < 1)
                {
                    _gumballMachine.CurrentState = new WinnerState(_gumballMachine).GetCurrentState();
                }
                else
                {
                    _gumballMachine.CurrentState = new NoQuarterState(_gumballMachine).GetCurrentState();
                }
            }
            else
            {
                _gumballMachine.CurrentState = new HasQuarterState(_gumballMachine).GetCurrentState();
            }
        }

        public IState GetCurrentState()
        {
            return _gumballMachine.CurrentState ?? this;
        }
        #endregion
    }
}
