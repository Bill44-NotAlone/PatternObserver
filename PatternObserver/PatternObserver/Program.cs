using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternObserverLib.Interfaces;
using PatternObserverLib;

namespace PatternObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ConcreteObserver> observers = new List<ConcreteObserver>() { new ConcreteObserver(), new ConcreteObserver()};
            ConcreteSubject subject = new ConcreteSubject();

            subject.RegisterObserver(observers[0]);
            subject.SetState("Александр");
            CounterInConsole(observers);
            subject.RegisterObserver(observers[1]);
            subject.SetState("Владимир");
            CounterInConsole(observers);
            subject.RemoveObserver(observers[1]);
            subject.SetState("Лев");
            CounterInConsole(observers);
            
            Console.ReadKey();
        }

        private static void CounterInConsole(List<ConcreteObserver> observers)
        {
            foreach (ConcreteObserver observer in observers) Console.Write(observer.GetCounter()+" ");
            Console.WriteLine();
        }
    }
}
