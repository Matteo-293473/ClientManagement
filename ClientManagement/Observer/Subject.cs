using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Models;

namespace ClientManagement.Observer
{
    class Subject
    {

        // lista di observers 
        private static readonly List<IObserver> Observers = new List<IObserver>();

        public void AggiungiObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RimuoviObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotificaObservers()
        {
            foreach (var observer in Observers)
                observer.Update();
        }
    }
}
