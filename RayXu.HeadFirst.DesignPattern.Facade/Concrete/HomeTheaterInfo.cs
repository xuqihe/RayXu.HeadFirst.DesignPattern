/**************************************************
*  Author:  Ray Xu
*  CLR Version:  4.0.30319.42000
*  Create Time:  2016/5/10 22:28:12
*  Description:  
*
*  Update History:
*  2016/5/10 22:28:12：Create.
*
**************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Facade.Concrete
{
    public class HomeTheaterInfo
    {
        #region Members
        private AmplifierInfo _amplifier;
        private TunerInfo _tuner;
        private DVDPlayerInfo _dvdPlayer;
        private CDPlayerInfo _cdPlayer;
        private ProjectorInfo _projector;
        private TheaterLightInfo _light;
        private ScreenInfo _screen;
        private PopcornPopperInfo _popper;
        #endregion

        #region  Properties
        #endregion

        #region Constructors
        public HomeTheaterInfo(AmplifierInfo amp,
            TunerInfo tuner,
            DVDPlayerInfo dvd,
            CDPlayerInfo cd,
            ProjectorInfo projector,
            ScreenInfo screen,
            TheaterLightInfo lights,
            PopcornPopperInfo popper)
        {
            _amplifier = amp;
            _tuner = tuner;
            _dvdPlayer = dvd;
            _cdPlayer = cd;
            _projector = projector;
            _screen = screen;
            _light = lights;
            _popper = popper;
        }
        #endregion

        #region Methods
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _popper.On();
            _popper.Pop();
            _light.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.SetWideScreenMode();
            _amplifier.On();
            _amplifier.SetDVDPlayer(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popper.Off();
            _light.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Enject();
            _dvdPlayer.Off();
        }

        public void ListenToCD(string cdTitle)
        {
            Console.WriteLine("Get ready for an audio experence...");
            _light.On();
            _amplifier.On();
            _amplifier.SetCDPlayer(_cdPlayer);
            _amplifier.SetVolume(5);
            _amplifier.SetSurroundSound();
            _cdPlayer.On();
            _cdPlayer.Play(cdTitle);
        }

        public void EndCD()
        {
            Console.WriteLine("Shutting down CD...");
            _amplifier.Off();
            _cdPlayer.Stop();
            _cdPlayer.Enject();
            _cdPlayer.Off();
        }

        public void ListenToRadio(double frequency)
        {
            Console.WriteLine("Tuning in the airwaves...");
            _tuner.On();
            _tuner.SetFrequency(frequency);
            _amplifier.On();
            _amplifier.SetTuner(_tuner);
            _amplifier.SetVolume(5);
        }

        public void EndRadio()
        {
            Console.WriteLine("Shutting down the tuner...");
            _tuner.Off();
            _amplifier.Off();
        }
        #endregion
    }
}
