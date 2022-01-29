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
        private double ctemperature;
        private double chumidity;
        private double cpressure;

        public string Display()
        {
            return "Погода сйчас: " + ctemperature + "C - температура; " + chumidity + " - влажность.";
        }

        public void UpDate(Dictionary<string, int> pair)
        {
            ctemperature = pair["ctemperature"];
            chumidity = pair["chumidity"];
            cpressure = pair["cpressure"];
        }
    }
}
