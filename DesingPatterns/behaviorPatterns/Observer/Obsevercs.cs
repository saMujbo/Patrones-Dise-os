

using DesingPatterns.behaviorPatterns.Observer;

public class WeatherData : IWeatherSubject // se implementa la interface 
{
    private List<IWeatherObserver> observers; // una lista privada de los observaores 
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        observers = new List<IWeatherObserver>();
    }

    public void RegisterObserver(IWeatherObserver observer)
    {
        observers.Add(observer); // se agrega un observador 
    }

    public void RemoveObserver(IWeatherObserver observer)
    {
        observers.Remove(observer); // remueve un observador
    }

    public void NotifyObservers() // modifica a los observadores 
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void SetMeasurements(float temperature, float humidity, float pressure) 
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        NotifyObservers();
    }
}

public class CurrentConditionsDisplay : IWeatherObserver // impleenta la interface 
{   // se crean las varibales 
    private float temperature; 
    private float humidity;

    public void Update(float temperature, float humidity, float pressure) // se le asignan valores 
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {temperature}°C and {humidity}% humidity.");
    }
}
