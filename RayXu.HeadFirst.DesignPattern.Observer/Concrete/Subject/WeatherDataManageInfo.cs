using RayXu.HeadFirst.DesignPattern.Observer.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Observer.Concrete
{
    public class WeatherDataManageInfo : ISubject
    {
        #region Properties
        public ArrayList Observers { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }
        #endregion

        #region Constructors
        public WeatherDataManageInfo()
        {
            Observers = new ArrayList();
        }
        #endregion

        #region ISubject Methods
        public void RegisterObserver(IObserver obs)
        {
            Observers.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            if (Observers.Contains(obs))
            {
                Observers.Remove(obs);
            }
        }

        public void NotifyObserver()
        {
            foreach (IObserver obs in Observers)
            {
                obs.Update(Temperature, Humidity, Pressure);
            }
        }
        #endregion

        #region Private Methods
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObserver();
        }
        #endregion
    }
}