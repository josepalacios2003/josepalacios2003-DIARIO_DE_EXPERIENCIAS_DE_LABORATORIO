using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11___JAP1129522
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double libra, dolar, yen, canteurosl, canteurosd, canteurosy;

            Console.WriteLine("Ingrese cantidad de libras");
            libra = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de dolares");
            dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de yenes");
            yen = double.Parse(Console.ReadLine());
           
            

            canteurosl = libra * 1.22;
            canteurosd = dolar * 0.75;
            canteurosy = yen * 0.009;


            Console.WriteLine(libra + "libras a euros es: {0}", canteurosl);
            Console.ReadLine();
            Console.WriteLine(dolar + " dolares a euros es: {0}", canteurosd);
            Console.ReadLine();
            Console.WriteLine(yen + " yenes a euros es: {0}", canteurosy);
            Console.ReadLine();
            Console.ReadKey();
        }

    }


}

