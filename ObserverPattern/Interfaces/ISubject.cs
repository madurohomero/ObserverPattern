using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    public interface ISubject
    {
        void Anexar(IObserver observer);
        void Notificar();
    }
}
