/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 23:38:17
*  Description:  
*
*  Update History:
*  2016/5/11 23:38:17：Create.
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
    public class DinnerMenuInfo : IMenu
    {
        #region Members
        private static int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private MenuItemInfo[] _menuItems;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public DinnerMenuInfo()
        {
            _menuItems = new MenuItemInfo[MAX_ITEMS];

            AddMenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddMenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddMenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddMenuItem("Hotdog", "A hot dog with saurkraut, relish, onions, topped with cheese", false, 3.05);
            AddMenuItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99);
            AddMenuItem("Pasta", "Spaghetti with Marina Sauce and a slice of sourdough bread", true, 3.89);
        }
        #endregion

        #region Methods
        public void AddMenuItem(string name, string desc, bool isVege, double price)
        {
            MenuItemInfo item = new MenuItemInfo(name, desc, isVege, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Can't add item to menu since the menu is full");
            }
            else
            {
                _menuItems[_numberOfItems] = item;
                _numberOfItems++;
            }
        }
        #endregion

        #region IMenu Methods
        public IIterator CreateIterator()
        {
            return new DinnerMenuIterator(_menuItems);
        }
        #endregion
    }
}
