/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 7:18:37
*  Description:  
*
*  Update History:
*  2016/5/9 7:18:37：Create.
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
    public class LightOffCommand : ICommand
    {
        #region Members
        private LightInfo _light;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public LightOffCommand(LightInfo light)
        {
            _light = light;
        }
        #endregion

        #region ICommand Methods
        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
        #endregion
    }
}
