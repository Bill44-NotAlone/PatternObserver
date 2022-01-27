using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternObserverLib.Interfaces;

namespace PatternObserverLib
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private double _pressure;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject subject)
        {
            this._weatherData = subject;
            _weatherData.RegisterObserver(this);
        }

        public string Display()
        {
            return "Погода сйчас: " + _temperature.ToString() + "C - температура;" + _humidity.ToString() + " - влажность.";
        }

        public string UpDate(double temperature, double humidity, double pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            return Display();
        }
    }
}
