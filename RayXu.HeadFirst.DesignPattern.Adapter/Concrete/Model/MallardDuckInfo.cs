/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 21:17:16
*  Description:  
*
*  Update History:
*  2016/5/9 21:17:16：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Adapter.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Adapter.Concrete
{
    public class MallardDuckInfo : IDuck
    {
        #region Members
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        #endregion

        #region IDuck Methods
        public void Quack()
        {
            Console.WriteLine("Mallard Duck Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Mallard Duck Fly");
        }
        #endregion
    }
}
