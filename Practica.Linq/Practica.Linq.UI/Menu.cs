using Practica.Linq.common;
using Practica.Linq.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.UI
{
    public class Menu
    {
        public void menu() {
            int opcion = 0;
            var val = new Validaciones();
            try
            {
                do
                {
                    Console.WriteLine("Ingrese una opcion");
                    Console.WriteLine("1:Ej. 1      2.Ej.2      3.Ej.3      4.Ej.4      " +
                       "5.Ej.5      6.Ej.6      7.Ej. 7        8.Ej.8      9.Ej.9");
                    Console.WriteLine("10.Ej.10     11.Ej.11       12.Ej.12        " +
                        "13.Ej.13        14.Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            var aux = true;
                            while (aux)
                            {
                                ConsultaCustomer q = new ConsultaCustomer();
                                Console.WriteLine("INGRESE EL CODIGO ID");
                                String id = Console.ReadLine();
                                if (val.ValidarEntrada(id)){
                                    id = id.ToUpper();
                                    aux = false;
                                }
                                else
                                {
                                    Console.WriteLine("INGRESAR UN ID CORRECTAMENTE DE 5 CARACTERES");
                                }
                              );
                               
                            }
                            
                            Console.WriteLine();
                            break;
                        case 2:
                            ConsultaProduct pd = new ConsultaProduct();
                            pd.ProductQuery();
                            Console.WriteLine();
                            break;
                        case 3:
                            ConsultaProduct pds = new ConsultaProduct();
                            pds.ProductInStock();
                            Console.WriteLine();
                            break;
                        case 4:
                            ConsultaCustomer q1 = new ConsultaCustomer();
                            q1.CustomerWA();
                            Console.WriteLine();
                            break;
                        case 5:
                            ConsultaProduct pdo = new ConsultaProduct();
                            pdo.OneElement();
                            Console.WriteLine();
                            break;
                        case 6:
                            ConsultaCustomer q2 = new ConsultaCustomer();
                            q2.CustomerTU_TL();
                            Console.WriteLine();
                            break;
                        case 7:
                            ConsultaCustomer q3 = new ConsultaCustomer();
                            q3.CustomersOrdersRegFecha();
                            Console.WriteLine();
                            break;
                        case 8:
                            ConsultaCustomer q4 = new ConsultaCustomer();
                            q4.Custormers3WA();
                            Console.WriteLine();
                            break;
                        case 9:
                            ConsultaProduct pdn = new ConsultaProduct();
                            pdn.ProductsName();
                            Console.WriteLine();
                            break;
                        case 10:
                            ConsultaProduct pdis = new ConsultaProduct();
                            pdis.ProductsStock();
                            Console.WriteLine();
                            break;
                        case 11:
                            ConsultaProduct pde = new ConsultaProduct();
                            pde.CategoriesProducts();
                            Console.WriteLine();
                            break;
                        case 12:
                            ConsultaProduct pdf = new ConsultaProduct();
                            pdf.FirstProduct();
                            Console.WriteLine();
                            break;
                        case 13:
                            Console.WriteLine();
                            break;

                        case 14:
                            Console.WriteLine("Adiós");
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Opción incorrecta, vuelva a ingresarla nuevamente");
                            Console.WriteLine();
                            break;
                    }
                } while (opcion != 13);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
             
    }
}
