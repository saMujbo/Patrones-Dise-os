using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.StructuralPatterns.Proxy
{
    // El objeto real que el proxy representa
    public class MrLink : IBoxSafe
    {
        public void OpenSafe()
        {
            Console.WriteLine("Mr. Link: Opening the safe.");
        }
    }

    // El proxy que controla el acceso al Mr. Link
    public class MrProxy : IBoxSafe
    {
        private MrLink _mrLink;

        private bool VerifyAccess()
        {
            // Verifica el acceso antes de proceder
            Console.WriteLine("Mr. Proxy: Verifying access to the safe.");
            return true;
        }

        private void LogAccess()
        {
            // Registro del acceso
            Console.WriteLine("Mr. Proxy: Logging the access time and reason.");
        }

        public void OpenSafe()
        {
            if (VerifyAccess())
            {
                if (_mrLink == null)
                {
                    _mrLink = new MrLink();
                }
                _mrLink.OpenSafe();
                LogAccess();
            }
        }
    }
}