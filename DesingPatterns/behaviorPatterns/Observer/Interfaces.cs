
namespace DesingPatterns.behaviorPatterns.Observer
{
    public interface IWeatherObserver //define que los observadores implementar para recibir las actualizaciones del subjeto
    {
        void Update(float temperature, float humidity, float pressure);
    }
    public interface IWeatherSubject // esta interfaces define tres metodos 
    {                                // que permite a los observadores registrar, eliminar y ser modificados cuando el subjeto implemente la interface
        void RegisterObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
    }

}
