/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/12 21:02:26
*  Description:  
*
*  Update History:
*  2016/5/12 21:02:26：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Composite.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Composite.Concrete
{
    public class WaitressInfo
    {
        #region Members
        private MenuComponentInfo _allMenus;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public WaitressInfo(MenuComponentInfo menu)
        {
            _allMenus = menu;
        }
        #endregion

        #region Methods
        public void PrintMenu()
        {
            _allMenus.Print();
        }
        #endregion
    }
}
