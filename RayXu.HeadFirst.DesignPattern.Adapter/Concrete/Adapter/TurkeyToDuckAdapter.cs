/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 21:20:19
*  Description:  
*
*  Update History:
*  2016/5/9 21:20:19：Create.
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
    public class TurkeyToDuckAdapter : IDuck
    {
        #region Members
        private ITurkey _turkey;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public TurkeyToDuckAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        #endregion

        #region IDuck Methods
        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
        #endregion
    }
}
