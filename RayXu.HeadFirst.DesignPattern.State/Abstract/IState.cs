/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/14 10:08:33
*  Description:  
*
*  Update History:
*  2016/5/14 10:08:33：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.State.Abstract
{
    public enum MarchineStatus
    {
        NoQuarterState = 0,
        HasQuarterState = 1,
        SoldState = 2,
        SoldOutState = 3,
        WinnerState = 4
    }

    public interface IState
    {
        MarchineStatus StatusName { get; }
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
