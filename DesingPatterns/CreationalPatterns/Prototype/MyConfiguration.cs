using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class MyConfiguration : IConfiguration
    {
        public string Setting1 {  get; set; }   
        public int Setting2 { get; set; }
        public bool Setting3 { get; set; }

        public MyConfiguration(string setting1,int setting2,bool setting3) 
        { 
            Setting1 = setting1;
            Setting2 = setting2;
            Setting3 = setting3;
        }
        public IConfiguration Clone()
        {
            return new MyConfiguration(Setting1, Setting2, Setting3);
        }
        public void PrintToConsole()
        {
            Console.WriteLine($"Setting1 = {Setting1}, Setting2 = {Setting2},Setting3 = {Setting3}");
        }
    }
}
