using RayXu.HeadFirst.DesignPattern.Observer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Observer.Concrete
{
    public class StatisticsDisplayInfo : IObserver, IDisplay
    {
        #region Members
        private float _temperatureSum = 0.0f;
        private int _numReadings = 0;
        #endregion

        #region Properties
        public float MaxTemp { get; set; } = 20f;
        public float MinTemp { get; set; } = 10f;
        public ISubject WeatherData { get; set; }
        public virtual float TemperatureSum { get { return _temperatureSum; } }
        public virtual int NumReadings { get { return _numReadings; } }
        #endregion

        #region Constructors
        public StatisticsDisplayInfo(ISubject sub)
        {
            WeatherData = sub;
            sub.RegisterObserver(this);
        }
        #endregion

        #region IObserver Methods
        public void Update(float temperature, float humidity, float pressure)
        {
            _temperatureSum += temperature;
            _numReadings++;
            if (temperature > MaxTemp)
            {
                MaxTemp = temperature;
            }

            if (temperature < MinTemp)
            {
                MinTemp = temperature;
            }
        }
        #endregion

        #region IDisplayElement Methods
        public void Display()
        {
            var disp = "Avg/Max/Min temperature = " + RoundFloatToString(TemperatureSum / NumReadings) + "F/" + MaxTemp + "F/" + MinTemp + "F";
            Console.WriteLine(disp);
        }
        #endregion

        #region Private Methods
        private string RoundFloatToString(float floatToRound)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            return floatToRound.ToString("F", cultureInfo);
        }
        #endregion
    }
}