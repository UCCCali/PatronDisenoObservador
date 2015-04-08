using System;

namespace Patron_Observador
{
    public class Observador1 : IObservador
    {
        public void ActualizarEstado(ISujeto sender)
        {
            Console.WriteLine("Observador 1 notificado...");
        }
    }
}
