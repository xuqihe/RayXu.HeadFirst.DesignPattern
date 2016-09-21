/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 22:09:07
*  Description:  
*
*  Update History:
*  2016/5/10 22:09:07：Create.
*
**************************************************/

using RayXu.HeadFirst.DesignPattern.Facade.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Facade.Concrete
{
    public class ProjectorInfo : BaseInfo
    {
        #region Members
        private DVDPlayerInfo _dvdPlayer;
        #endregion

        #region  Properties

        #endregion
        #region Constructors
        public ProjectorInfo(string desc) : base(desc)
        { }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine("Projector: " + Description + " on");
        }

        public void Off()
        {
            Console.WriteLine("Projector: " + Description + " off");
        }

        public void SetDVDPlayer(DVDPlayerInfo dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
            Console.WriteLine("Projector: " + Description + " setting DVD player to " + _dvdPlayer.Description);
        }

        public void SetWideScreenMode()
        {
            Console.WriteLine("Projector: " + Description + " in widescreen mode (16x9 aspect ratio)");
        }

        public void SetTVMode()
        {
            Console.WriteLine("Projector: " + Description + " in tv mode (4x3 aspect ratio)");
        }
        #endregion
    }
}
