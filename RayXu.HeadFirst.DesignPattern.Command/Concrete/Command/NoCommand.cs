/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 16:41:09
*  Description:  
*
*  Update History:
*  2016/5/8 16:41:09：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Command.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command.Concrete
{
    public class NoCommand : ICommand
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region ICommand Methods
        public void Execute()
        { }

        public void Undo()
        { }
        #endregion
    }
}
