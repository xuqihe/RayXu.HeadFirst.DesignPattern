/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/9 21:23:01
*  Description:  
*
*  Update History:
*  2016/5/9 21:23:01：Create.
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
    public class DuckToTurkeyAdapter : ITurkey
    {
        #region Members
        private IDuck _duck;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public DuckToTurkeyAdapter(IDuck duck)
        {
            _duck = duck;
        }
        #endregion

        #region ITurkey Methods
        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly()
        {
            _duck.Fly();
        }
        #endregion
    }
}
