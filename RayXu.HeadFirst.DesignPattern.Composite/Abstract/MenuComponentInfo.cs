/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/12 8:15:34
*  Description:  
*
*  Update History:
*  2016/5/12 8:15:34：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Composite.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Composite.Abstract
{
    public abstract class MenuComponentInfo
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
        #endregion

        #region Methods
        public virtual void Add(MenuComponentInfo menuComponent)
        {
            throw new UnsupportedOperationException();
        }

        public virtual void Remove(MenuComponentInfo menuComponent)
        {
            throw new UnsupportedOperationException();
        }

        public virtual MenuComponentInfo GetChild(int i)
        {
            throw new UnsupportedOperationException();
        }

        public virtual void Print()
        {
            throw new UnsupportedOperationException();
        }

        public virtual ArrayList GetMenu()
        {
            throw new UnsupportedOperationException();
        }

        public virtual int Count()
        {
            throw new UnsupportedOperationException();
        }
        #endregion
    }
}
