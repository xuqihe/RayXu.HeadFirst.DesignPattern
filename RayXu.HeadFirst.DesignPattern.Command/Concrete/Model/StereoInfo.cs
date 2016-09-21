/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/8 16:30:26
*  Description:  
*
*  Update History:
*  2016/5/8 16:30:26：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Command.Concrete
{
    public class StereoInfo
    {
        #region Members
        #endregion

        #region  Properties
        public string Location { get; set; }
        #endregion

        #region Constructors
        public StereoInfo(string location)
        {
            Location = location;
        }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine(Location + ": Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine(Location + ": Stereo is off");
        }

        public void SetCD()
        {
            Console.WriteLine(Location + ": Stereo is set for CD input");
        }

        public void SetDVD()
        {
            Console.WriteLine(Location + ": Stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.WriteLine(Location + ": Stereo is set for Radio");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine(Location + ": Stereo volume set to " + volume);
        }
        #endregion
    }
}
