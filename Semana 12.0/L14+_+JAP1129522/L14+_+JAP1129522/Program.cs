using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14___JAP1129522
{
    class program
    {
        static void Main(string[] args)
        {
            int opcion = 0;


            Console.WriteLine("Bienvenido al menú, seleccione una opción:");
            Console.WriteLine("Presione 1: ------>  Edad y nombre de empleados ");
            Console.WriteLine("Presione 2: ------>  Puestos y Salarios ");
            Console.WriteLine("Presione 3: ------>  Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    string[] nombres = new string[5];
                    int[] edades = new int[5];
                    int[] calculo = new int[5];


                    for (int a = 0; a < 5; a++)
                    {
                        Console.WriteLine("Ingrese el nombre de la persona");
                        nombres[a] = Console.ReadLine();
                        Console.WriteLine("Ingrese en que año nació " + nombres[a]);
                        edades[a] = int.Parse(Console.ReadLine());
                        calculo[a] = 2022 - edades[a];
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(nombres[i] + " tiene: " + calculo[i] + " años");
                    }

                    break;

                case 2:
                    string[] puesto = new string[5];
                    double[] salario = new double[5];
                    for (int p = 0; p < 5; p++)
                    {
                        Console.WriteLine("Ingrese un puesto");
                        puesto[p] = Console.ReadLine();
                        Console.WriteLine("Ingrese el salario es " + puesto[p]);
                        salario[p] = double.Parse(Console.ReadLine());
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(puesto[i] + " el salario es de: " + salario[i]);
                    }
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

            }

            Console.ReadKey();
        }
    }
}