using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternObserverLib.Interfaces;

namespace PatternObserverLib
{
    public class ConcreteObserver : IObserver
    {
        private int counter = 0;
        public void UpDate()
        {
            counter = counter + 1;
        }

        public int GetCounter()
        {
            return counter;
        }
    }
}
