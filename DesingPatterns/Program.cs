using DesingPatterns.StructuralPatterns.Bridge;
using DesingPatterns.StructuralPatterns.Proxy;

Console.WriteLine("\t\t PATRONES ESTRUCTURALES\n");

 
// Uso del Proxy
Console.WriteLine("#1: Uso del Proxy\n");
Console.WriteLine("Client: Trying to access the safe with Mr. Link directly:");
MrLink mrLink = new MrLink();
mrLink.OpenSafe();

Console.WriteLine("\nClient: Trying to access the safe with Mr. Proxy:");
MrProxy mrProxy = new MrProxy();
mrProxy.OpenSafe();
// Final Proxy

// uso del Bridge
IBridge correo = new Correo();
IBridge mensajeTexto = new MensajeTexto();

Notificacion notificacionUrgenteCorreo = new NotificacionUrgente(correo);
Notificacion notificacionNormalMensajeTexto = new NotificacionNormal(mensajeTexto);

Console.WriteLine("\n\n#2: Uso del Bridge\n");
notificacionUrgenteCorreo.Enviar("Esto es una prueba urgente por correo.");
notificacionNormalMensajeTexto.Enviar("Esto es una prueba normal por mensaje de texto.");
//Final del Bridge

Console.WriteLine("\t\t PATRONES DE COMPORTAMIENTO");

//uso del OBSERVER
Console.WriteLine("\n\n#1: Uso del observer\n");
WeatherData weatherData = new WeatherData();

CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();

weatherData.RegisterObserver(currentDisplay);

weatherData.SetMeasurements(28.3f, 65.0f, 1013.1f);
weatherData.SetMeasurements(22.1f, 70.0f, 1012.5f);
//final del OBSERVER