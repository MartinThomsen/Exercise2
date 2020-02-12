using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
   public abstract class DoorStatusSubject
    {
        private readonly List<IDoorStatusObserver> _observers = new List<IDoorStatusObserver>();

        public void Attach(IDoorStatusObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IDoorStatusObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
