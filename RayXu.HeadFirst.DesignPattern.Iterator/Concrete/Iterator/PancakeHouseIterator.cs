/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/12 7:03:43
*  Description:  
*
*  Update History:
*  2016/5/12 7:03:43：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Iterator.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Iterator.Concrete
{
    public class PancakeHouseIterator: IIterator
    {
        #region Members
        private ArrayList _menuItems;
        private int _position = 0;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public PancakeHouseIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }
        #endregion

        #region IIterator Methods
        public bool HasNext()
        {
            return _position < _menuItems.Count;
        }

        public object Next()
        {
            var menuItem = _menuItems[_position];
            _position++;
            return menuItem;
        }
        #endregion
    }
}
