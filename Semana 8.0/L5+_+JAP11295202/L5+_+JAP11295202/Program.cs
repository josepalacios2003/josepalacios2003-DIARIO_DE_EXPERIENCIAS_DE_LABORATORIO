using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5___JAP11295202
{
       class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;

            Console.WriteLine("EJERCICIO 1");
            Console.WriteLine("Ingrese un numero entero");
            numeroEntero = Convert.ToInt32(Console.ReadLine());

            if (numeroEntero > 0)
            {
                Console.WriteLine("Resultado : positivo");
            }
            else if (numeroEntero < 0)
            {
                Console.WriteLine("Resultado : Negativo");
            }
            else if (numeroEntero == 0)
            {
                Console.WriteLine("Resultado : el valor ingresado es cero");
            }
            Console.ReadKey();
        }
    }
}
