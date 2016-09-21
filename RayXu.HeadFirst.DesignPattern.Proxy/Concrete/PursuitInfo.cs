/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/14 15:44:00
*  Description:  
*
*  Update History:
*  2016/5/14 15:44:00：Create.
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
    public class PursuitInfo : IGiveGift
    {
        #region Members
        #endregion

        #region  Properties
        public string Name { get; set; }
        public SchoolGirlInfo Girl { get; set; }
        #endregion

        #region Constructors
        public PursuitInfo(SchoolGirlInfo girl, string name)
        {
            Girl = girl;
            Name = name;
        }
        #endregion

        #region Methods
        public void GiveFlower()
        {
            Console.WriteLine(Name + " give flower to " + Girl.Name);
        }
        #endregion
    }
}
