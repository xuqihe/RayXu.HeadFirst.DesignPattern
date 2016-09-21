/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 21:07:27
*  Description:  
*
*  Update History:
*  2016/5/10 21:07:27：Create.
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
    public class DVDPlayerInfo : BaseInfo
    {
        #region Members
        private int _currentTrack;
        private string _movie;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public DVDPlayerInfo(string desc) : base(desc)
        { }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine("DVDPlayer: " + Description + " on");
        }

        public void Off()
        {
            Console.WriteLine("DVDPlayer: " + Description + " off");
        }

        public void Enject()
        {
            _movie = null;
            Console.WriteLine("DVDPlayer: " + Description + "enject");
        }

        public void Play(string movie)
        {
            _movie = movie;
            _currentTrack = 0;
            Console.WriteLine("DVDPlayer: " + Description + " playing " + _movie);
        }

        public void Play(int track)
        {
            if (string.IsNullOrEmpty(_movie))
            {
                Console.WriteLine("DVDPlayer: " + Description + " can't play track " + _currentTrack + ", no cd inserted");
            }
            else
            {
                _currentTrack = track;
                Console.WriteLine("DVDPlayer: " + Description + " playing track " + _currentTrack);
            }
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine("DVDPlayer: " + Description + " stopped");
        }

        public void Pause()
        {
            Console.WriteLine("DVDPlayer: " + Description + " paused \"" + _movie + "\"");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("DVDPlayer: " + Description + " set two channel audio");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("DVDPlayer: " + Description + " set surround audio");
        }
        #endregion
    }
}
