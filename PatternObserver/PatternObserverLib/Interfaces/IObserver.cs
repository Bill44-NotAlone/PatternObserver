using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserverLib.Interfaces
{
    public interface IObserver
    {
        string UpDate(double temperature, double humidity, double pressure);
    }
}
