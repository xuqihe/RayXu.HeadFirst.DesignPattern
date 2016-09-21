/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/14 10:11:43
*  Description:  
*
*  Update History:
*  2016/5/14 10:11:43：Create.
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
    public class GumballMachineInfo
    {
        #region Members
        private int _count;
        #endregion

        #region  Properties
        public IState CurrentState { get; set; }
        public int Count { get { return _count; } }
        #endregion

        #region Constructors
        public GumballMachineInfo(int num)
        {
            _count = num > 0 ? num : 0;
            if (_count > 0)
            {
                CurrentState = new NoQuarterState(this).GetCurrentState();
            }
            else
            {
                CurrentState = new SoldOutState(this).GetCurrentState();
            }
        }
        #endregion

        #region Methods
        public void InsertQuarter()
        {
            CurrentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            CurrentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            CurrentState.TurnCrank();
        }

        public void ReleaseBall()
        {
            if (Count > 0)
            {
                _count -= 1;
            }
            Console.WriteLine("The marchine is selling the gumball");
        }

        public void Refill(int num)
        {
            if (CurrentState.StatusName == MarchineStatus.NoQuarterState
                || CurrentState.StatusName == MarchineStatus.SoldOutState)
            {
                _count += num;
                CurrentState = new NoQuarterState(this).GetCurrentState();
                Console.WriteLine("The marchine refill " + num + " gumball");
            }
            else
            {
                Console.WriteLine("You can't refill the marchine since the marchine is running");
            }
        }
        #endregion
    }
}
