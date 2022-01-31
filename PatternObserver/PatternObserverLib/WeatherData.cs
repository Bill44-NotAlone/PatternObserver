using System;
using System.Collections.Generic;
using PatternObserverLib.Interfaces;

namespace PatternObserverLib
{
    public class WeatherData : ISubject
    {
        public WeatherData()
        {
            Random random = new Random();
            foreach (string key in variables) privatekey.Add(key, random.Next(1, 100));
        }

        private List<IObserver> observers = new List<IObserver>();
        private Dictionary<string, int> privatekey = new Dictionary<string, int>();

        private List<string> variables = new List<string>()
        {
            "temperature",
            "humidity",
            "pressure",
            "mintemperature",
            "middletemperature",
            "maxtemperature",
            "shumidity",
            "spressure",
            "fweatherforecast",
            "fhumidity",
            "fpressure",
            "ctemperature",
            "chumidity",
            "cpressure"
        };

        public void NotifyOdserver()
        {
            foreach (IObserver observer in observers) observer.UpDate(privatekey);
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.RemoveAt(observers.IndexOf(observer));
        }

        public int this[string variable]
        {
            set
            {
                privatekey[variable] = value;
                this.NotifyOdserver();
            }
        }
    }
}
