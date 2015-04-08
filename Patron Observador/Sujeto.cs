using System.Collections.Generic;

namespace Patron_Observador
{
    public class Sujeto : ISujeto
    {

        private List<IObservador> Observadores;

        public Sujeto()
        {
            Observadores = new List<IObservador>();
        }

        public void Notificar()
        {
            foreach (var observador in Observadores)
            {
                observador.ActualizarEstado(this);
            }
        }

        public void Suscribir(IObservador observador)
        {
            Observadores.Add(observador);
        }

        public void EliminarSuscribcion(IObservador observador)
        {
            Observadores.Remove(observador);
        }
    }
}
