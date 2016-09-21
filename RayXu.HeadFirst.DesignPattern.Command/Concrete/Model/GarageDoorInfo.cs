/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 16:23:46
*  Description:  
*
*  Update History:
*  2016/5/8 16:23:46：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command.Concrete
{
    public class GarageDoorInfo
    {
        #region Members
        #endregion

        #region  Properties
        public string Location { get; set; }
        #endregion

        #region Constructors
        public GarageDoorInfo(string location)
        {
            Location = location;
        }
        #endregion

        #region Methods
        public void Up()
        {
            Console.WriteLine(Location + ": Garage door is up");
        }

        public void Down()
        {
            Console.WriteLine(Location + ": Garage door is down");
        }

        public void LightOn()
        {
            Console.WriteLine(Location + ": Garage door light is on");
        }

        public void LightOff()
        {
            Console.WriteLine(Location + ": Garage door light is off");
        }
        #endregion
    }
}
