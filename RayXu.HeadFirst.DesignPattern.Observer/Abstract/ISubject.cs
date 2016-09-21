using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Observer.Abstract
{
    public interface ISubject
    {
        void RegisterObserver(IObserver obs);
        void RemoveObserver(IObserver obs);
        void NotifyObserver();
    }
}
