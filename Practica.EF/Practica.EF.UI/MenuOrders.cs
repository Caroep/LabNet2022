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
    public class MenuOrders
    {

        public void mostrarMenu()
        {
            int opc = 0;
            try
            {
                do
                {
                    Console.WriteLine("INGRESAR UNA OPCIÓN DENTRO DE ORDENES: ");
                    Console.WriteLine("1. MOSTRAR ORDENES        2.AGREGAR UNA NUEVA ORDEN");
                    Console.WriteLine("3.MODIFICAR UNA ORDEN    4. BORRAR UNA ORDEN");
                    Console.WriteLine("5.VOLVER AL MENU ANTERIOR");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            OrdersLogic ordersLogic = new OrdersLogic();
                            Console.WriteLine("****ORDERS LIST****");
                            Console.WriteLine(" ");
                            foreach (Orders order in ordersLogic.GetAll())
                            {
                                Console.WriteLine($"{order.ShipName} - {order.OrderDate}");
                            }

                            Console.WriteLine(" "); ;
                            break;
                        case 2:
                            OrdersLogic ordersLogic1 = new OrdersLogic();
                            ordersLogic1.Add(new Orders
                            {
                                ShipName ="nombre" ,
                                OrderDate = DateTime.Now,
                            }) ;
                            break;
                        case 3:
                            OrdersLogic ordersLogic2 = new OrdersLogic();
                            Console.WriteLine("INGRESE EL ID DEL ELEMENTO A MODIFICAR DESDE EL INICIAL 1048: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            ordersLogic2.Update(new Orders
                            {
                                ShipName = "Sugar",
                                OrderID = n,
                            });
                            break;
                        case 4:
                            OrdersLogic ordersLogic3 = new OrdersLogic();
                            Console.WriteLine("INGRESE EL ID DEL ELEMENTO A ELIMINAR: ");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                ordersLogic3.Delete(n1);
                            }
                            catch (DbUpdateException)
                            {
                                Console.WriteLine("La orden que desea ingresar se encuentra asosiada a un detalle de orden");
                                Console.WriteLine(" ");
                            }

                            break;
                        case 5:
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("INGRESAR UNA OPCION VALIDA");
                            break;
                    }
                } while (opc != 5);
            }
            catch (FormatException)
            {
                Console.WriteLine("LA OPCIÓN INGRESADA DEBE SER UN NUMERO");
            }
        }
       }
}
