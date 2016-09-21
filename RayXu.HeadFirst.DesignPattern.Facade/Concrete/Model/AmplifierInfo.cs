/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 22:14:30
*  Description:  
*
*  Update History:
*  2016/5/10 22:14:30：Create.
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
    public class AmplifierInfo : BaseInfo
    {
        #region Members
        private TunerInfo _tuner;
        private DVDPlayerInfo _dvdPlayer;
        private CDPlayerInfo _cdPlayer;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public AmplifierInfo(string desc) : base(desc)
        { }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine("Amplifier: " + Description + " on");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier: " + Description + " off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier: " + Description + " stereo mode on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier: " + Description + " surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine("Amplifier: " + Description + " setting volume to " + level);
        }

        public void SetTuner(TunerInfo tuner)
        {
            _tuner = tuner;
            Console.WriteLine("Amplifier: " + Description + " setting tuner to " + tuner.Description);
        }

        public void SetDVDPlayer(DVDPlayerInfo dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
            Console.WriteLine("Amplifier: " + Description + " setting DVD player to " + dvdPlayer.Description);
        }

        public void SetCDPlayer(CDPlayerInfo cdPlayer)
        {
            _cdPlayer = cdPlayer;
            Console.WriteLine("Amplifier: " + Description + " setting CD Player to " + cdPlayer.Description);
        }
        #endregion
    }
}
