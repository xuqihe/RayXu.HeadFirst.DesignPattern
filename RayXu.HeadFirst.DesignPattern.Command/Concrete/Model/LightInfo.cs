/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 16:28:51
*  Description:  
*
*  Update History:
*  2016/5/8 16:28:51：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command.Concrete
{
    public class LightInfo
    {
        #region Members
        #endregion

        #region  Properties
        public string Location { get; set; }
        #endregion

        #region Constructors
        public LightInfo(string location)
        {
            Location = location;
        }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine(Location + ": Light is on");
        }

        public void Off()
        {
            Console.WriteLine(Location + ": Light is off");
        }
        #endregion
    }
}
