using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15___JAP1129522_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[40, 50];
            int sumaTotal = 0;
            Random r = new Random();
            for (int i = 0; i < 40; i++) 
            {
                for (int j = 0; j < 50; j++) 
                {
                    matriz[i,j] = r.Next(-100, 10);
                }
            }
            for (int i = 0; i < 40; i++) 
            {
                for (int j = 0; j < 50; j++) 
                {
                    Console.Write(" " + matriz[i, j]);
                    sumaTotal += matriz[i,j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("El resultado de toda la matriz es: " + sumaTotal);
            Console.ReadKey();
        }
    }
}
