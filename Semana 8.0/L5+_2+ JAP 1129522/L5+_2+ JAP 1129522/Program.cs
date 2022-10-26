using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5__2__JAP_1129522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int día;
            Console.WriteLine("EJERCICIO 2");
            Console.WriteLine("Ingresar el número de dia");
           día=Convert.ToInt32(Console.ReadLine());
        if (día < 0)
        {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
        }
        if (día > 7)
        {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
        }
        if (día == 1)
        { 
         Console.WriteLine("El día es lunes");
        }
        if (día == 2)
        {
                Console.WriteLine("El día es martes");
        }
        if (día == 3)
        { 
        Console.WriteLine("El día es miercoles");
        }
            if (día == 4)
            {
                Console.WriteLine("El día es jueves");
            }
            if (día == 5)
            {
                Console.WriteLine("El día es viernes");
            }
            if (día == 6)
            {
                Console.WriteLine("El día es sábado");
            }
            if (día == 7)
            { 
            Console.WriteLine("El día es domingo");
            }
            Console.ReadKey();
        }
    }
}
