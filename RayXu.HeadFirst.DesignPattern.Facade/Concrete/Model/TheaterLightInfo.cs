/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 7:42:52
*  Description:  
*
*  Update History:
*  2016/5/10 7:42:52：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Facade.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Facade.Concrete
{
    public class TheaterLightInfo : BaseInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public TheaterLightInfo(string desc) : base(desc)
        { }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine("Theater Light: " + Description + " on");
        }

        public void Off()
        {
            Console.WriteLine("Theater Light: " + Description + " off");
        }

        public void Dim(int level)
        {
            Console.WriteLine("Theater Light: " + Description + "dimming to " + level);
        }
        #endregion
    }
}
