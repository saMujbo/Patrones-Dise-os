using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.behaviorPatterns.Observer
{
    public interface IWeatherObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
    public interface IWeatherSubject
    {
        void RegisterObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
    }

}
