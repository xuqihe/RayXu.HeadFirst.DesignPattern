/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 23:35:07
*  Description:  
*
*  Update History:
*  2016/5/11 23:35:07：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Iterator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Iterator.Concrete
{
    public class DinnerMenuIterator : IIterator
    {
        #region Members
        private MenuItemInfo[] _menuItems;
        private int _position = 0;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public DinnerMenuIterator(MenuItemInfo[] menuItems)
        {
            _menuItems = menuItems;
        }
        #endregion

        #region Methods
        public bool HasNext()
        {
            return _position < _menuItems.Length;
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
