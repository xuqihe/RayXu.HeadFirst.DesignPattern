/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 8:02:35
*  Description:  
*
*  Update History:
*  2016/5/10 8:02:35：Create.
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
    public class CDPlayerInfo : BaseInfo
    {
        #region Members
        private int _currentTrack;
        private string _title;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public CDPlayerInfo(string desc) : base(desc)
        { }
        #endregion

        #region Methods
        public void On()
        {
            Console.WriteLine("CDPlayer: " + Description + " on");
        }

        public void Off()
        {
            Console.WriteLine("CDPlayer: " + Description + " off");
        }

        public void Enject()
        {
            _title = null;
            Console.WriteLine("CDPlayer: " + Description + "enject");
        }

        public void Play(string title)
        {
            _title = title;
            _currentTrack = 0;
            Console.WriteLine("CDPlayer: " + Description + " playing " + _title);
        }

        public void Play(int track)
        {
            if (string.IsNullOrEmpty(_title))
            {
                Console.WriteLine("CDPlayer: " + Description + " can't play track " + _currentTrack + ", no cd inserted");
            }
            else
            {
                _currentTrack = track;
                Console.WriteLine("CDPlayer: " + Description + " playing track " + _currentTrack);
            }
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine("CDPlayer: " + Description + " stopped");
        }

        public void Pause()
        {
            Console.WriteLine("CDPlayer: " + Description + " paused \"" + _title + "\"");
        }
        #endregion
    }
}
