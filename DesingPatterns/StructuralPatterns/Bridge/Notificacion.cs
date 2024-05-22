using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.StructuralPatterns.Bridge
{
    public abstract class Notificacion // se crea una calse asbtracta que nos perminte utilizar la interace y hacer una variable de tipo _notificacion
    {
        protected IBridge _notificacion;

        protected Notificacion(IBridge notificacion) 
        {
            _notificacion = notificacion;
        }
        public abstract void Enviar(string mensaje); // se crea un metodo de tipo Enviar que nos permite utlizarlo de forma abstracta 
    }
}
