using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class MyConfiguration : IConfiguration // se llama la interface 
    {
        public string Setting1 {  get; set; }   
        public int Setting2 { get; set; }
        public bool Setting3 { get; set; }

        public MyConfiguration(string setting1,int setting2,bool setting3) // se asginan valores a las varibales por medio de constructores 
        { 
            Setting1 = setting1;
            Setting2 = setting2;
            Setting3 = setting3;
        }
        public IConfiguration Clone() // se hace uso del metodo de la interface y se clonan las tres configuraciones 
        {
            return new MyConfiguration(Setting1, Setting2, Setting3);
        }
        public void PrintToConsole() // un metodo que nos imprime por consola los valores 
        {
            Console.WriteLine($"Setting1 = {Setting1}, Setting2 = {Setting2},Setting3 = {Setting3}");
        }
    }
}
