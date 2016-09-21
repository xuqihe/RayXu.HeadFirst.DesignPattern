/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 7:20:40
*  Description:  
*
*  Update History:
*  2016/5/9 7:20:40：Create.
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
    public class LightOnCommand : ICommand
    {
        #region Members
        private LightInfo _light;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public LightOnCommand(LightInfo light)
        {
            _light = light;
        }
        #endregion

        #region ICommand Methods
        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
        #endregion
    }
}
