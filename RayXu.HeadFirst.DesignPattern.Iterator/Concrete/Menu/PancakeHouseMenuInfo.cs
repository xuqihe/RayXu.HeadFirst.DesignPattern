/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/12 7:06:46
*  Description:  
*
*  Update History:
*  2016/5/12 7:06:46：Create.
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
    public class PancakeHouseMenuInfo : IMenu
    {
        #region Members
        private ArrayList _menuItems;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public PancakeHouseMenuInfo()
        {
            _menuItems = new ArrayList();
            AddMenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddMenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, and sausage", false, 2.99);
            AddMenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddMenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }
        #endregion

        #region Methods
        public void AddMenuItem(string name, string desc, bool isVege, double price)
        {
            MenuItemInfo item = new MenuItemInfo(name, desc, isVege, price);
            _menuItems.Add(item);
        }
        #endregion

        #region IMenu Methods
        public IIterator CreateIterator()
        {
            return new PancakeHouseIterator(_menuItems);
        }
        #endregion
    }
}
