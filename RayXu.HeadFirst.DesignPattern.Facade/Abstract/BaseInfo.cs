/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 7:43:36
*  Description:  
*
*  Update History:
*  2016/5/10 7:43:36：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Facade.Abstract
{
    public class BaseInfo
    {
        #region Members
        private string _description;
        #endregion

        #region  Properties
        public string Description { get { return _description; } }
        #endregion

        #region Constructors
        public BaseInfo(string desc)
        {
            _description = desc;
        }
        #endregion

        #region Methods
        #endregion
    }
}
