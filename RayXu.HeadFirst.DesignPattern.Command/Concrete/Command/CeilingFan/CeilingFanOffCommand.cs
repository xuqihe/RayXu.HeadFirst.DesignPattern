/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 7:11:07
*  Description:  
*
*  Update History:
*  2016/5/9 7:11:07：Create.
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
    public class CeilingFanOffCommand : ICommand
    {
        #region Members
        private CeilingFanInfo _ceilingFan;
        private CeilingFanLevel _preLevel;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public CeilingFanOffCommand(CeilingFanInfo ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        #endregion

        #region ICommand Methods
        public void Execute()
        {
            _preLevel = _ceilingFan.Speed;
            _ceilingFan.Speed = CeilingFanLevel.OFF;
        }

        public void Undo()
        {
            _ceilingFan.Speed = _preLevel;
        }
        #endregion
    }
}
