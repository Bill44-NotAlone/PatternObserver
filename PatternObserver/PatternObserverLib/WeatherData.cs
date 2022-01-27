using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternObserverLib.Interfaces;

namespace PatternObserverLib
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public void NotifyOdserver()
        {
            foreach (IObserver observer in _observers) observer.UpDate(_temperature, _humidity, _pressure);
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.RemoveAt(_observers.IndexOf(observer));
        }

        public double GetTemperature()
        {
            return _temperature;
        }
        public double GetHumidity()
        {
            return _humidity;
        }

        public double GetPressure()
        {
            return _pressure;
        }

        public void MeasurementsChanged()
        {
            NotifyOdserver();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }

    }
}
