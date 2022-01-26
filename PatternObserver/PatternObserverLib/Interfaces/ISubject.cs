using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserverLib.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver();
        void RemoveObserver();
        void NotifyOdserver();
    }
}
