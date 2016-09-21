using RayXu.HeadFirst.DesignPattern.Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Observer.Concrete
{
    public class CurrentConditionsDisplayInfo : IObserver, IDisplay
    {
        #region Properties
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        public ISubject WeatherData { get; set; }
        #endregion

        #region Constructors
        public CurrentConditionsDisplayInfo(ISubject sub)
        {
            WeatherData = sub;
            sub.RegisterObserver(this);
        }
        #endregion

        #region IObserver Methods
        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
        #endregion

        #region IDisplayElement Methods
        public void Display()
        {
            Console.WriteLine("Current conditions: " + Temperature + "F degrees and " + Humidity + "% humidity");
        }
        #endregion
    }
}