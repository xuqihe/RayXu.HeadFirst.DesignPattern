/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/12 8:33:30
*  Description:  
*
*  Update History:
*  2016/5/12 8:33:30：Create.
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
    public class MenuItemInfo : MenuComponentInfo
    {
        #region Members
        #endregion

        #region  Properties
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

        #region MenuComponentInfo Methods
        public override void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + Name);
            if (IsVegetarian)
            {
                sb.Append(" (v)");
            }
            sb.Append(", Price: " + Price);
            sb.Append(", Description: " + Description);
            Console.WriteLine(sb.ToString());
        }
        #endregion
    }
}
