using RayXu.HeadFirst.DesignPattern.Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Observer.Concrete
{
    public class ForecastDisplayInfo : IObserver, IDisplay
    {
        #region Properties
        public float CurrentPressure { get; set; }
        public float LastPressure { get; set; }
        public ISubject WeatherData { get; set; }
        #endregion

        #region Constructors
        public ForecastDisplayInfo(ISubject sub)
        {
            WeatherData = sub;
            sub.RegisterObserver(this);
        }
        #endregion

        #region IObserver Methods
        public void Update(float temperature, float humidity, float pressure)
        {
            LastPressure = CurrentPressure;
            CurrentPressure = pressure;
        }
        #endregion

        #region IDisplayElement Methods
        public void Display()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Forecast: ");

            if (CurrentPressure > LastPressure)
            {
                sb.Append("Improving weather on the way!");
            }
            else if (CurrentPressure == LastPressure)
            {
                sb.Append("More of the same");
            }
            else if (CurrentPressure < LastPressure)
            {
                sb.Append("Watch out for cooler, rainy weather");
            }
            Console.WriteLine(sb.ToString());
        }
        #endregion
    }
}