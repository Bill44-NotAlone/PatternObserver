using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternObserverLib.Interfaces;

namespace PatternObserverLib
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double mintemperature;
        private double middletemperature;
        private double maxtemperature;
        private double shumidity;
        private double spressure;


        public string Display()
        {
            return $"{maxtemperature}  - максимальная температура, {mintemperature} - миниамльная температура, " +
                $"{middletemperature} - средная температура, {shumidity} - влажность и {spressure} - давление.";
        }

        public void UpDate(Dictionary<string, int> pair)
        {
            mintemperature = pair["mintemperature"];
            middletemperature = pair["middletemperature"];
            maxtemperature = pair["maxtemperature"];
            shumidity = pair["shumidity"];
            spressure = pair["spressure"];
        }
    }
}
