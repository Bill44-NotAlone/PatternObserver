using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternObserverLib.Interfaces;

namespace PatternObserverLib
{
    public class ConcreteSubject : ISubject
    {
        private string name;

        public void NotifyOdserver()
        {
            //
        }

        public void RegisterObserver()
        {
            //
        }

        public void RemoveObserver()
        {
            //
        }

        public string GetState()
        {
            return name;
        }

        public void SetState(string Name)
        {
            name = Name;
        }
    }
}
