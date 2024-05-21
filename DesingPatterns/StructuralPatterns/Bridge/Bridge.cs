using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.StructuralPatterns.Bridge
{
    public class Correo : IBridge
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Enviando correo: " + mensaje);
        }
    }
    public class MensajeTexto : IBridge
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine("Enviando mensaje de texto: " + mensaje);
        }
    }

    public class NotificacionUrgente : Notificacion
    {
        public NotificacionUrgente(IBridge notificacion) : base(notificacion)
        {
        }
        public override void Enviar(string mensaje)
        {
            _notificacion.Enviar("URGENTE: " + mensaje);
        }
    }

    public class NotificacionNormal : Notificacion
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




