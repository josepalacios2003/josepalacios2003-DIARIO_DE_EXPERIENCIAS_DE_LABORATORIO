using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");

            Console.WriteLine("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            string edad = Console.ReadLine();

            Console.WriteLine("Igresa tu carrera: ");
            string carrera = Console.ReadLine();

            Console.WriteLine("Ingresa tu carne: ");
            string carne = Console.ReadLine();

            Console.WriteLine("Soy " + nombre + " tengo " + edad + " años y estudio la carrera de " + carrera + " y mi numero de carnet es: " + carne);

            Console.ReadKey();

        }
    }
}