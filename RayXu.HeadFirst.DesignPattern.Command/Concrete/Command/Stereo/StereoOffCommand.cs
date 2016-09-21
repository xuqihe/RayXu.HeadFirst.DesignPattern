/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 7:22:36
*  Description:  
*
*  Update History:
*  2016/5/9 7:22:36：Create.
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
    public class StereoOffCommand : ICommand
    {
        #region Members
        private StereoInfo _stereo;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public StereoOffCommand(StereoInfo steteo)
        {
            _stereo = steteo;
        }
        #endregion

        #region ICommand Methods
        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
        #endregion
    }
}
