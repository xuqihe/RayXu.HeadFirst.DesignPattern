/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/12 20:55:02
*  Description:  
*
*  Update History:
*  2016/5/12 20:55:02：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Composite.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Composite.Concrete
{
    public class MenuInfo : MenuComponentInfo
    {
        #region Members
        private ArrayList _menuComponent;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public MenuInfo(string name, string desc)
        {
            _menuComponent = new ArrayList();
            Name = name;
            Description = desc;
        }
        #endregion

        #region MenuComponentInfo Methods
        public override void Add(MenuComponentInfo menuComponent)
        {
            _menuComponent.Add(menuComponent);
        }

        public override void Remove(MenuComponentInfo menuComponent)
        {
            _menuComponent.Remove(menuComponent);
        }

        public override MenuComponentInfo GetChild(int i)
        {
            return _menuComponent[i] as MenuComponentInfo;
        }

        public override int Count()
        {
            return _menuComponent.Count;
        }

        public override void Print()
        {
            Console.WriteLine("--== Menu Info ==--");
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + Name);
            sb.Append(", Description: " + Description);
            Console.WriteLine(sb.ToString());

            if (_menuComponent.Count > 0)
                Console.WriteLine("--== Menu Item Info ==--");

            foreach (MenuComponentInfo item in _menuComponent)
            {
                item.Print();
            }
            Console.WriteLine();
        }
        #endregion
    }
}
