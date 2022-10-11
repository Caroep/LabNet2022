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
    public class MenuShipper
    {

        public void mostrarMenu()
        {
            int opc = 0;
            do
            {
                try
                {
                    Console.WriteLine("INGRESAR UNA OPCIÓN DENTRO DE CARGADORES: ");
                    Console.WriteLine("1. MOSTRAR CARGADORES       2.AGREGAR UN NUEVO CARGADOR");
                    Console.WriteLine("3.MODIFICAR UN CARGADOR    4. BORRAR UN CARGADOR");
                    Console.WriteLine("5.VOLVER AL MENU ANTERIOR");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            ShippersLogic shippersLogic = new ShippersLogic();
                            Console.WriteLine("****SHIPPERS LIST****");
                            Console.WriteLine(" ");
                            foreach (Shippers shipper in shippersLogic.GetAll())
                            {
                                Console.WriteLine($"{shipper.ShipperID}-{shipper.CompanyName} -{shipper.Phone}");
                            }
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            ShippersLogic shippersLogic1 = new ShippersLogic();
                            Console.WriteLine("NOMBRE DE LA COMPAÑIA");
                            string k = Console.ReadLine();
                            shippersLogic1.Add(new Shippers
                            {
                                CompanyName = k,
                                Phone = "1234567",
                            });
                            Console.WriteLine("SE AGREGO CORRECTAMENTE");
                            break;
                        case 3:
                            ShippersLogic shippersLogic2 = new ShippersLogic();
                            Console.WriteLine("INGRESE EL ID DEL ELEMENTO A MODIFICAR: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("NOMBRE DE LA COMPAÑIA");
                            string z = Console.ReadLine();
                            //if (shippersLogic2.Update(new Shippers
                            //{
                            //    CompanyName = z,
                            //    ShipperID = n,
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
                            ShippersLogic shippersLogic3 = new ShippersLogic();
                            Console.WriteLine("INGRESE EL ID DEL ELEMENTO A ELIMINAR: ");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                shippersLogic3.Delete(n1);
                                //{
                                //    Console.WriteLine("SE ELIMINO CORRECTAMENTE");
                                //}
                                //else
                                //{
                                //    Console.WriteLine("ERROR: EL ID SELECCIONADO ES NULO");
                                //}
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
