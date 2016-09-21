/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 22:57:14
*  Description:  
*
*  Update History:
*  2016/5/11 22:57:14：Create.
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
    public class CafeMenuIterator : IIterator
    {
        #region Members
        private Array _menuItems;
        private int _position = 0;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public CafeMenuIterator(Hashtable menuItems)
        {
            _menuItems = new object[menuItems.Count];
            menuItems.CopyTo(_menuItems, 0);
        }
        #endregion

        #region IIterator Methods
        public bool HasNext()
        {
            return _position < _menuItems.Length;
        }

        public object Next()
        {
            var menuItem = ((DictionaryEntry)_menuItems.GetValue(_position)).Value;
            _position++;
            return menuItem;
        }
        #endregion
    }
}
