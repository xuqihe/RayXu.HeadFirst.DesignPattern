/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 7:12:22
*  Description:  
*
*  Update History:
*  2016/5/9 7:12:22：Create.
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
    public class GarageDoorDownCommand : ICommand
    {
        #region Members
        private GarageDoorInfo _garageDoor;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public GarageDoorDownCommand(GarageDoorInfo garageDoor)
        {
            _garageDoor = garageDoor;
        }
        #endregion

        #region Methods
        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }
        #endregion
    }
}
