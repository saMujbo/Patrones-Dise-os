namespace AbstractFactory
{
    public abstract class OperatingSystemFactory // se crea una clase abstracta 
    {
        public abstract IOperatingSystem CreateOperatingSystem(); //crea un metodo abstracto por medio de una interface
                                                                  //que podrá ser utlizada por cualquier clase si lo necestia  
    }
}
