using Practica.EF.Entities;
using Practica.EF.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.UI
{
    public class Menu
    {
        public void mostrarOpciones()
        {
            int opcion = 0;
            try
            {
                do
                {
                    Console.WriteLine("INGRESE UNA OPCIÓN: ");
                    Console.WriteLine("1: ORDENES         2: SHIPPERS");
                    Console.WriteLine("3:CATEGORIAS       4: SALIR");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            MenuOrders meOrd= new MenuOrders();
                            meOrd.mostrarMenu();
                            break;
                        case 2:
                            MenuShipper menSh = new MenuShipper();
                            menSh.mostrarMenu();
                            break;
                        case 3:
                            MenuCategories meCat = new MenuCategories();
                            meCat.mostrarMenu();
                            break;

                        case 4:
                            Console.WriteLine("Adiós");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Ingrese una opción valida");
                            break;
                    }

                } while (opcion != 4);

            }
            catch (FormatException)
            {

                Console.WriteLine("LA OPCIÓN INGRESADA DEBE SER UN NUMERO");
            }
            
        }
    }
}
