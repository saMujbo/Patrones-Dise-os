using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacOSFactory : OperatingSystemFactory
    {
        public override IOperatingSystem CreateOperatingSystem()
        {
            return new MacOS();
        }
    }
}
