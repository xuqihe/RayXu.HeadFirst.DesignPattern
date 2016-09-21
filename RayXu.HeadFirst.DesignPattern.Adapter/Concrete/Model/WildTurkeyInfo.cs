/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 21:18:43
*  Description:  
*
*  Update History:
*  2016/5/9 21:18:43：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Adapter.Concrete
{
    public class WildTurkeyInfo: ITurkey
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region ITurkey Methods
        public void Gobble()
        {
            Console.WriteLine("Wild Turkey Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Wild Turkey Fly");
        }
        #endregion
    }
}
