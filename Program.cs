using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Configure # de la Central: ");//Se solicita un # telefonico
            int numeroTelefonico = int.Parse(Console.ReadLine()); //Se captura lo ingresado por el usuario

            
            Telefono telefono1 = Telefono.GetTelefono(numeroTelefonico); 

            //Se muestra el # telefonico configurado
            telefono1.Mostrar();

            Console.ReadKey();

            Console.WriteLine("Configure el otro # de la Central: ");
            int otroNumero = int.Parse(Console.ReadLine());

            Telefono telefono2 = Telefono.GetTelefono(otroNumero);

            telefono1.Mostrar();
            telefono2.Mostrar();
            Console.ReadKey();
        }
    }
}
