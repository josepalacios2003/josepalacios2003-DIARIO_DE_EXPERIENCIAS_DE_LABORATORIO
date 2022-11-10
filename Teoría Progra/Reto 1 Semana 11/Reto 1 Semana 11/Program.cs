using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] personas = new int[5];
            int v, max = personas[0], min = personas[0];
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Ingrese el numero de personas en N1: ");
                v = int.Parse(Console.ReadLine());
                personas[i] = v;
            }
            for (int i = 1; i < 2; i++)
            {
                Console.Write("Ingrese el numero de personas en N2: ");
                v = int.Parse(Console.ReadLine());
                personas[i] = v;
            }
            for (int i = 2; i < 3; i++)
            {
                Console.Write("Ingrese el numero de personas en N3: ");
                v = int.Parse(Console.ReadLine());
                personas[i] = v;
            }
            for (int i = 3; i < 4; i++)
            {
                Console.Write("Ingrese el numero de personas en N4: ");
                v = int.Parse(Console.ReadLine());
                personas[i] = v;
            }
            for (int i = 4; i < 5; i++)
            {
                Console.Write("Ingrese el numero de personas en N5: ");
                v = int.Parse(Console.ReadLine());
                personas[i] = v;
            }

            Console.Write("\n\nEl N con mayor cantidad de personas es: " + personas.Max());
            Console.ReadKey();
        }
    }
}

