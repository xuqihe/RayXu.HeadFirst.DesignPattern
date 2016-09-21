/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/11 22:31:13
*  Description:  
*
*  Update History:
*  2016/5/11 22:31:13：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Iterator.Concrete
{
    public class MenuItemInfo
    {
        #region Members
        #endregion

        #region  Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegetarian { get; set; }
        public double Price { get; set; }
        #endregion

        #region Constructors
        public MenuItemInfo(string name, string desc, bool isVege, double price)
        {
            Name = name;
            Description = desc;
            IsVegetarian = isVege;
            Price = price;
        }
        #endregion

        #region Methods
        #endregion
    }
}
