/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 7:17:12
*  Description:  
*
*  Update History:
*  2016/5/9 7:17:12：Create.
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
    public class GarageDoorUpCommand : ICommand
    {
        #region Members
        private GarageDoorInfo _garageDoor;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public GarageDoorUpCommand(GarageDoorInfo garageDoor)
        {
            _garageDoor = garageDoor;
        }
        #endregion

        #region ICommand Methods
        public void Execute()
        {
            _garageDoor.Up();
        }

        public void Undo()
        {
            _garageDoor.Down();
        }
        #endregion
    }
}
