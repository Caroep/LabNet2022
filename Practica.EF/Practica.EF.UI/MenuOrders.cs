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
            do
            {
                try
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
                            break;
                        case 2:
                            OrdersLogic ordersLogic1 = new OrdersLogic();
                            Console.WriteLine("Nombre de Ship en orden");
                            string o = Console.ReadLine();
                            ordersLogic1.Add(new Orders
                            {
                                ShipName = o,
                                OrderDate = DateTime.Now
                            });
                            Console.WriteLine("SE AGREGO CORRECTAMENTE");
                            break;
                        case 3:
                            OrdersLogic ordersLogic2 = new OrdersLogic();
                            Console.WriteLine("INGRESE EL ID A MODIFICAR: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Nombre de Ship en orden");
                            string x = Console.ReadLine();
                            //if (ordersLogic2.Update(new Orders
                            //{
                            //    ShipName = x,
                            //    OrderDate = DateTime.Now,
                            //    OrderID = n
                            //}))
                            //{
                            //    Console.WriteLine("SE MODIFICO CORRECTAMENTE");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("ERROR: EL ID SELECCIONADO ES NULO");
                            //}
                            break;
                        case 4:
                            OrdersLogic ordersLogic3 = new OrdersLogic();
                            Console.WriteLine("INGRESE EL ID DEL ELEMENTO A ELIMINAR: ");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                if (ordersLogic3.Delete(n1))
                                {
                                    Console.WriteLine("SE ELIMINO CORRECTAMENTE");
                                }
                                else
                                {
                                    Console.WriteLine("ERROR: EL ID SELECCIONADO ES NULO");
                                }
                            }
                            catch (DbUpdateException)
                            {
                                Console.WriteLine("La orden que desea ingresar se encuentra asosiada a un detalle de orden");
                            }
                            break;
                        case 5:
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("INGRESAR UNA OPCION VALIDA");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("LA OPCIÓN INGRESADA DEBE SER UN NUMERO");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(" ");
            } while (opc != 5);
        }
    }
}
