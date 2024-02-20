using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string unidad, opc;
            double cant, result;

            do
            {
                Console.WriteLine("Dile la unidad(segundos/minutos): ");
                unidad = Console.ReadLine();

                Console.WriteLine("Dile la cantidad: ");
                cant = double.Parse(Console.ReadLine());

                if (unidad == "segundos")
                {
                    result = HadaP1.Seconds2Minutes(cant);
                    Console.WriteLine("La cantidad de " + cant + " segundos equivale a " + result + " minutos.");
                }
                else if (unidad == "minutos")
                {
                    result = HadaP1.Minutes2Seconds(cant);
                    Console.WriteLine("La cantidad de " + cant + " minutos equivale a " + result + " segundos.");
                }
                else if (unidad == "horas")
                {
                    result = HadaP1.Hours2Minutes(cant);
                    Console.WriteLine("La cantidad de " + cant + " horas equivale a " + result + " minutos.");
                }

                Console.WriteLine("¿Quieres seguir?(s/n): ");
                opc = Console.ReadLine();
            } while (opc == "s");
        }
    }
}
