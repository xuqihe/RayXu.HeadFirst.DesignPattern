/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 7:49:40
*  Description:  
*
*  Update History:
*  2016/5/10 7:49:40：Create.
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
    public class ScreenInfo : BaseInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public ScreenInfo(string desc) : base(desc)
        { }
        #endregion

        #region Methods
        public void Up()
        {
            Console.WriteLine("Screen: " + Description + " up");
        }

        public void Down()
        {
            Console.WriteLine("Screen: " + Description + " down");
        }
        #endregion
    }
}
