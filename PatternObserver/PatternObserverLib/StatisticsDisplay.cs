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
        private double _mintemperature;
        private double _middletemperature;
        private double _maxtemperature;


        public string Display()
        {
            return $"{_maxtemperature}  - максимальная температура, {_mintemperature} - миниамльная температура, {_middletemperature} - средная температура";
        }

        public string UpDate(double temperature, double humidity, double pressure)
        {
            throw new NotImplementedException();
        }
    }
}
