
namespace AbstractFactory
{
    public class MacOSFactory : OperatingSystemFactory // implementa el metodo de la clase abstracta 
    {                                                
        public override IOperatingSystem CreateOperatingSystem() 
        {
            return new MacOS(); // retorna un nuevo sistema operativo 
        }
    }
}
