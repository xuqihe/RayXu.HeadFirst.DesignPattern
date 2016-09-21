using RayXu.HeadFirst.DesignPattern.Facade.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            AmplifierInfo amplifier = new AmplifierInfo("AmplifierInfo");
            TunerInfo tuner = new TunerInfo("TunerInfo");
            DVDPlayerInfo dvdPlayer = new DVDPlayerInfo("DVDPlayerInfo");
            CDPlayerInfo cdPlayer = new CDPlayerInfo("CDPlayerInfo");
            ProjectorInfo projector = new ProjectorInfo("ProjectorInfo");
            TheaterLightInfo light = new TheaterLightInfo("TheaterLightInfo");
            ScreenInfo screen = new ScreenInfo("ScreenInfo");
            PopcornPopperInfo popper = new PopcornPopperInfo("PopcornPopperInfo");

            HomeTheaterInfo homeTheater = new HomeTheaterInfo(amplifier, tuner, dvdPlayer, cdPlayer, projector, screen, light, popper);

            homeTheater.WatchMovie("Move 123");
            Console.WriteLine();

            homeTheater.EndMovie();
            Console.WriteLine();

            homeTheater.ListenToCD("CD 123");
            Console.WriteLine();

            homeTheater.EndCD();
            Console.WriteLine();

            homeTheater.ListenToRadio(12.34);
            Console.WriteLine();

            homeTheater.EndRadio();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
