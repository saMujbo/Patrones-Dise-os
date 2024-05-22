using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.StructuralPatterns.Bridge
{
    public class Correo : IBridge //clase correo utiliza la interface para enviar el corre 
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Enviando correo: " + mensaje);
        }
    }
    public class MensajeTexto : IBridge //clase correo utiliza la interface para enviar el mensaje
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Enviando mensaje de texto: " + mensaje);
        }
    }

    public class NotificacionUrgente : Notificacion // se llama a la clase abstracta Notificacion y se aplica la implementación necesaria en este caso urgente 
    {
        public NotificacionUrgente(IBridge notificacion) : base(notificacion)
        {
        }
        public override void Enviar(string mensaje)
        {
            _notificacion.Enviar("URGENTE: " + mensaje);
        }
    }

    public class NotificacionNormal : Notificacion // se llama a la clase abstracta Notificacion para envíar una notificacón pero de una implementación diferente 
    {
        public NotificacionNormal(IBridge notificacion) : base(notificacion)
        {
        }
        public override void Enviar(string mensaje)
        {
            _notificacion.Enviar(mensaje);
        }
    }


}




