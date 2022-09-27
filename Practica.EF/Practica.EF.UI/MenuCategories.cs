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
    public class MenuCategories
    {
        public void mostrarMenu()
        {
            int opc = 0;
                try
                {
                do 
                { 
                    Console.WriteLine("INGRESAR UNA OPCIÓN DENTRO DE CATEGORIAS: ");
                    Console.WriteLine("1. MOSTRAR CATEGORIAS        2.AGREGAR UNA NUEVA CATEGORIA");
                    Console.WriteLine("3.MODIFICAR UNA CATEGORIA    4. BORRAR UNA CATEGORIA");
                    Console.WriteLine("5.VOLVER AL MENU ANTERIOR");
                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            CategoriesLogic categorieLogic1 = new CategoriesLogic();
                            Console.WriteLine("****CATEGORIES LIST****");
                            Console.WriteLine(" ");
                            foreach (Categories categorie in categorieLogic1.GetAll())
                            {
                                Console.WriteLine($"{categorie.CategoryID} - {categorie.CategoryName}");
                            }
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            CategoriesLogic categorieLogic2 = new CategoriesLogic();
                            Console.WriteLine("NOMBRE DE LA CATEGORIA");
                            string b = Console.ReadLine();
                            categorieLogic2.Add(new Categories
                            {
                                CategoryName = b
                            });
                            break;
                        case 3:
                            CategoriesLogic categorieLogic3 = new CategoriesLogic();
                            Console.WriteLine("INGRESE EL ID DEL ELEMENTO A MODIFICAR: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("NOMBRE DE LA CATEGORIA");
                            string a = Console.ReadLine();
                            categorieLogic3.Update(new Categories
                            {
                                CategoryName= a,
                                Description =" DESCRIPCION",
                                CategoryID = n
                            });;
                            break;
                        case 4:
                            CategoriesLogic categorieLogic4 = new CategoriesLogic();
                            Console.WriteLine("INGRESE EL ID DEL ELEMENTO A ELIMINAR: ");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                categorieLogic4.Delete(n1);
                            }
                            catch (DbUpdateException)
                            {
                                Console.WriteLine("La categoria que desea ingresar se encuentra asosiada a un producto activo");
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
                }while (opc != 5);
        }
                catch (FormatException)
                {
                    Console.WriteLine("LA OPCIÓN INGRESADA DEBE SER UN NUMERO");
                }
        }
    }
}
