/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/12 7:12:34
*  Description:  
*
*  Update History:
*  2016/5/12 7:12:34：Create.
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
    public class WaitressInfo
    {
        #region Members
        private IMenu _pancakeHouseMenu;
        private IMenu _dinnerMenu;
        private IMenu _cafeMenu;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public WaitressInfo(IMenu pancake, IMenu dinner, IMenu cafe)
        {
            _pancakeHouseMenu = pancake;
            _dinnerMenu = dinner;
            _cafeMenu = cafe;
        }
        #endregion

        #region Methods
        public void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                var item = iterator.Next() as MenuItemInfo;
                if (item != null)
                {
                    Console.WriteLine(item.Name + ", " + item.Price + ", " + item.Description);
                }
            }
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinnerIterator = _dinnerMenu.CreateIterator();
            IIterator cafeIterator = _cafeMenu.CreateIterator();

            Console.WriteLine("--== Pancake House Menu ==--");
            PrintMenu(pancakeIterator);
            Console.WriteLine();

            Console.WriteLine("--== Dinner Menu ==--");
            PrintMenu(dinnerIterator);
            Console.WriteLine();

            Console.WriteLine("--== Cafe Menu ==--");
            PrintMenu(cafeIterator);
            Console.WriteLine();
        }
        #endregion
    }
}
