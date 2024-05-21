using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.StructuralPatterns.Bridge
{
    public abstract class Notificacion
    {
        protected IBridge _notificacion;

        protected Notificacion(IBridge notificacion)
        {
            _notificacion = notificacion;
        }
        public abstract void Enviar(string mensaje);
    }
}
