using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejcPooConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> list = new List<TransportePublico>();
            Console.WriteLine("Introduzca la cantidad de omnibus que ingresara:");
            int cantidadO = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidadO; i++)
            {
                Omnibus omnibus = new Omnibus();
                Console.WriteLine("Ingresar la cantidad de pasajeros");
                omnibus.Pasajeros = Convert.ToInt32(Console.ReadLine());
                list.Add(omnibus);
            }
            Console.WriteLine("Introduzca la cantidad de taxis que ingresara:");
            int cantidad1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad1; i++)
            {
                Taxi taxi = new Taxi();
                Console.WriteLine("Ingresar la cantidad de pasajeros");
                taxi.Pasajeros = Convert.ToInt32(Console.ReadLine());
                list.Add(taxi);
            }
            int pos = 1;
            foreach (TransportePublico item in list)
            {
                if (pos <= cantidadO)
                {
                    Console.WriteLine(item.GetType().Name + " {0}: " + item.Mostrar(), pos);
                    pos++;
                }
                else
                {
                    pos = 1;
                    Console.WriteLine(item.GetType().Name + " {0}: " + item.Mostrar(), pos);
                    pos++;
                }

            }
            Console.ReadKey();
        }
    }
}
