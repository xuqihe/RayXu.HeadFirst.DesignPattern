/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 22:39:38
*  Description:  
*
*  Update History:
*  2016/5/11 22:39:38：Create.
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
    public class CafeMenuInfo : IMenu
    {
        #region Members
        private Hashtable _menuItems;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public CafeMenuInfo()
        {
            _menuItems = new Hashtable();
            AddMenuItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99, 1);
            AddMenuItem("Soup of the Day", "A cup of the soup of the day, with a side salad", false, 3.69, 2);
            AddMenuItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29, 3);
        }
        #endregion

        #region Methods
        public void AddMenuItem(string name, string desc, bool isVege, double price, int index)
        {
            MenuItemInfo item = new MenuItemInfo(name, desc, isVege, price);
            _menuItems.Add(index, item);
        }
        #endregion

        #region IMenu Methods
        public IIterator CreateIterator()
        {
            return new CafeMenuIterator(_menuItems);
        }
        #endregion
    }
}
