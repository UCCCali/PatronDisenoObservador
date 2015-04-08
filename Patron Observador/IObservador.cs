
namespace Patron_Observador
{
    public interface IObservador
    {

        /// <summary>
        /// Método encargado de indicar que el estado del proceso debe actualizarse para que 
        /// indique a los observadores "algo".
        /// </summary>
        /// <param name="sender">Indicamos la interfaz a quién se le envía la notificación</param>
        void ActualizarEstado(ISujeto sender);

    }
}
