/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 22:05:54
*  Description:  
*
*  Update History:
*  2016/5/10 22:05:54：Create.
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
    public class PopcornPopperInfo : BaseInfo
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public PopcornPopperInfo(string desc) : base(desc)
        { }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine("Popcorn Popper: " + Description + " on");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn Popper: " + Description + " off");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn Popper: " + Description + " pop popcorn");
        }
        #endregion
    }
}
