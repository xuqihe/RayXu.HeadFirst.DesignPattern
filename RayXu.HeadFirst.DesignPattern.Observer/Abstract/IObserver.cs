using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayXu.HeadFirst.DesignPattern.Observer.Abstract
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
