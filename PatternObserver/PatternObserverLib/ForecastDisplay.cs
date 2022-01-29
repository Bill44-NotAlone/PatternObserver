using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternObserverLib.Interfaces;

namespace PatternObserverLib
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double fweatherforecast;
        private double fhumidity;
        private double fpressure;

        public string Display()
        {
            return $"{fweatherforecast} - прогноз погоды, {fhumidity} - влажность, {fpressure} - давление.";
        }

        public void UpDate(Dictionary<string, int> pair)
        {
            fweatherforecast = pair["fweatherforecast"];
            fhumidity = pair["fhumidity"];
            fpressure = pair["fpressure"];
        }
    }
}
