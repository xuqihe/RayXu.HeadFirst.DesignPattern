/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/14 15:49:14
*  Description:  
*
*  Update History:
*  2016/5/14 15:49:14：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Proxy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Proxy.Concrete
{
    public class ProxyInfo : IGiveGift
    {
        #region Members
        #endregion

        #region  Properties
        public PursuitInfo Pursuit { get; set; }
        #endregion

        #region Constructors
        public ProxyInfo(SchoolGirlInfo girl, string pursuitName)
        {
            Pursuit = new PursuitInfo(girl, pursuitName);
        }
        #endregion

        #region Methods
        public void GiveFlower()
        {
            Pursuit.GiveFlower();
        }
        #endregion
    }
}
