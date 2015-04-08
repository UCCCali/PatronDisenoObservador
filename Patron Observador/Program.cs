using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Observador
{
    public class Program
    {
        static void Main(string[] args)
        {

            ISujeto objSujeto = new Sujeto();

            IObservador objObservador1 = new Observador1();
            IObservador objObservador3 = new Observador1();
            IObservador objObservador2 = new Observador2();


            objSujeto.Suscribir(objObservador1);
            objSujeto.Suscribir(objObservador2);
            objSujeto.Suscribir(objObservador3);

            objSujeto.Notificar();

            Console.ReadLine();

        }
    }
}
