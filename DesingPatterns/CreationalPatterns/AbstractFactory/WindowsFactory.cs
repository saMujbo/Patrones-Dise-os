
namespace AbstractFactory
{
    public class WindowsFactory:OperatingSystemFactory // implementa el metodo de la clase abstracta 
    {
        public override IOperatingSystem CreateOperatingSystem()
        {
            return new Windows();
        }
    }
}
