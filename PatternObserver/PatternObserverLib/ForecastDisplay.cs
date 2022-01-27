using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternObserverLib.Interfaces;

namespace PatternObserverLib
{
    class ForecastDisplay : IObserver, IDisplayElement
    {
        private double _weatherforecast;
        private double _humidity;
        private double _pressure;

        public string UpDate(double temperature, double humidity, double pressure)
        {
            this._weatherforecast = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            return Display();
        }

        public string Display()
        {
            return $"{_weatherforecast} - прогноз погоды, {_humidity} - влажность, {_pressure}";
        }
    }
}
