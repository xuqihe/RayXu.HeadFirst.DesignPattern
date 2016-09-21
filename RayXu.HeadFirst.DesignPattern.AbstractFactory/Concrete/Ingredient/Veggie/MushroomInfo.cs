/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 13:39:37
*  Description:  
*
*  Update History:
*  2016/5/8 13:39:37：Create.
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
    public class MushroomInfo: IVeggie
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region IVeggie Methods
        public string Name { get { return "Mushroom"; } }
        #endregion
    }
}
