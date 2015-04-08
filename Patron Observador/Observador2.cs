using System;

namespace Patron_Observador
{
    public class Observador2 : IObservador
    {
        public void ActualizarEstado(ISujeto sender)
        {
            Console.WriteLine("Observador 2 notificado...");
        }
    }
}
