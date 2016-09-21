using RayXu.HeadFirst.DesignPattern.Observer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherDataManageInfo weather = new WeatherDataManageInfo();
            CurrentConditionsDisplayInfo currentDisplay = new CurrentConditionsDisplayInfo(weather);
            ForecastDisplayInfo forecasetDispaly = new ForecastDisplayInfo(weather);
            HeatIndexDisplayInfo heatIndexDisplay = new HeatIndexDisplayInfo(weather);
            StatisticsDisplayInfo statisticsDisplay = new StatisticsDisplayInfo(weather);

            weather.SetMeasurements(80, 65, 30.4f);
            Console.WriteLine("--== Change 1: ==--");
            currentDisplay.Display();
            forecasetDispaly.Display();
            heatIndexDisplay.Display();
            statisticsDisplay.Display();

            weather.SetMeasurements(35, 35, 10.4f);
            Console.WriteLine("--== Change 2: ==--");
            currentDisplay.Display();
            forecasetDispaly.Display();
            heatIndexDisplay.Display();
            statisticsDisplay.Display();

            Console.ReadLine();
        }
    }
}
