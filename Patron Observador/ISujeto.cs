
namespace Patron_Observador
{
    public interface ISujeto
    {

        /// <summary>
        /// Notifica a los observadores 
        /// </summary>
        void Notificar();

        /// <summary>
        /// Permite suscribir los observadores
        /// </summary>
        void Suscribir(IObservador observador);

        /// <summary>
        /// Permite eliminar la suscribción de los observadores
        /// </summary>
        void EliminarSuscribcion(IObservador observador);

    }
}
