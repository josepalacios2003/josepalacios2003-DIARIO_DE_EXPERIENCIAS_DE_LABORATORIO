using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO_2_SEMANA_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nivel = new string[5];
            int[] adultos = new int[5];
            int[] niños = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el N del edificio");
                nivel[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de adultos ");
                adultos[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de niños");
                niños[i] = int.Parse(Console.ReadLine());
            }

            double suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma = suma + adultos[i];
            }

            double suman = 0;
            for (int i = 0; i < 5; i++)
            {
                suman = suman + niños[i];
            }



        }
    }
}

        
    

