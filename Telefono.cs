using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Telefono
    {
        private static Telefono telefono;//atributo que representa la instancia de la clase
        
        private int numero; // atributo para contener el # de telefono

        //Metodo constructor publico
        private Telefono(int numero)
        {
            this.numero = numero;
        }

        public static Telefono GetTelefono(int num)
        {
            if(telefono==null)
            {
                telefono = new Telefono(num);
            }
            return telefono;
        }
        
        public void Mostrar()
        {
            Console.WriteLine($"El numero de la central configurado es: {numero}");
        }
            
       
    }
}
