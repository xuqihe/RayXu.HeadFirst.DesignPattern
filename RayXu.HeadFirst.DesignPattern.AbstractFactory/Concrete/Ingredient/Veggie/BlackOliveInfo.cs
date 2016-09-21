/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 12:27:41
*  Description:  
*
*  Update History:
*  2016/5/8 12:27:41：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.AbstractFactory.Concrete
{
    public class BlackOliveInfo : IVeggie
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region IVeggie Methods
        public string Name { get { return "Black Olive"; } }
        #endregion
    }
}
