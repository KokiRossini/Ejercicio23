using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            double medidaPulgadas, medidaCentimetros;
            double medidaConvertida;
            string opcionMedida;

            Console.WriteLine("ingrese el formato de convercion");
            Console.WriteLine("(C)entimetros a Pulgadas o (P)ulgaadas a Centrimetros");
            opcionMedida = Convert.ToString(Console.ReadLine());

            if (opcionMedida.ToUpper() == "C" || opcionMedida.ToUpper() == "P")
            {
                if (opcionMedida.ToUpper() == "C")
                {
                    Console.WriteLine("ingrese medida en centimetros");
                    medidaCentimetros = Convert.ToDouble(Console.ReadLine());
                    medidaConvertida = medidaCentimetros * 0.39370;
                    Console.WriteLine($"{medidaCentimetros} centimetros equivalen a {medidaConvertida} pulgadas");

                }
                else
                {
                    Console.WriteLine("ingrese medida en Pulgadas");
                    medidaPulgadas = Convert.ToDouble(Console.ReadLine());
                    medidaConvertida = medidaPulgadas / 0.39370;

                }


            }
            else
            {
                Console.WriteLine("ingrese una opcion valida");
            }
        }
    }
}
