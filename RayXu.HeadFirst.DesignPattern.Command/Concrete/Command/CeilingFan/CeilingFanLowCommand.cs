﻿/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 7:10:25
*  Description:  
*
*  Update History:
*  2016/5/9 7:10:25：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Command.Abstract;
using RayXu.HeadFirst.DesignPattern.Command.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command.Concrete
{
    public class CeilingFanLowCommand : ICommand
    {
        #region Members
        private CeilingFanInfo _ceilingFan;
        private CeilingFanLevel _preLevel;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public CeilingFanLowCommand(CeilingFanInfo ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        #endregion

        #region ICommand Methods
        public void Execute()
        {
            _preLevel = _ceilingFan.Speed;
            _ceilingFan.Speed = CeilingFanLevel.LOW;
        }

        public void Undo()
        {
            _ceilingFan.Speed = _preLevel;
        }
        #endregion
    }
}
