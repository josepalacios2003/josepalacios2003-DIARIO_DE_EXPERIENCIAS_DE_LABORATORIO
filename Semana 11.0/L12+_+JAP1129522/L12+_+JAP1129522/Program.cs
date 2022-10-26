using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12___JAP1129522
{
    class PruebaVector2
    {
        private float[] notas;
        private float promedio;

        public void Cargar()
        {
            notas = new float[15];
            for (int f = 0; f < 15; f++)
            {
                Console.Write("Ingrese la nota de curso:");
                string linea = Console.ReadLine();
                notas[f] = float.Parse(linea);
            }
        }
        public void Totalnotas()
        {
            float total = 0;
            for (int f = 0; f < 15; f++)
            {
                total = total + notas[f];
            }
            Console.WriteLine("El total de notas es:" + total);
            Console.WriteLine();
        }

        public void CalcularPromedio()
        {
            float suma;
            suma = 0;
            for (int f = 0; f < 15; f++)
            {
                suma = suma + notas[f];
            }
            promedio = suma / 15;
            Console.WriteLine("El promedio de notas es:" + promedio);
        }

        public void CALCULOMAYORES()
        {
            int mayor, menor;
            mayor = 0;
            menor = 0;
            for (int f = 0; f < 15; f++)
            {
                if (notas[f] > promedio)
                {
                    mayor++;
                }
                else
                {
                    if (notas[f] < promedio)
                    {
                        menor++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio:" + mayor);
            Console.WriteLine("Cantidad de personas menores al promedio:" + menor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector2 pv2 = new PruebaVector2();
            pv2.Cargar();
            pv2.Totalnotas();
            pv2.CalcularPromedio();
            pv2.CALCULOMAYORES();
        }
    }
}
