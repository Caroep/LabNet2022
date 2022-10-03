using Practica.Linq.Data;
using Practica.Linq.Entities;
using Practica.Linq.Entities.dbo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic
{
    public class ConsultaProduct : BaseLogic<Products>
    {
        //Ejercicio 2: Query para devolver todos los productos sin stock
        public IEnumerable<Products> ProductQuery()
        {
            var query = context.Products.Where(p => p.UnitsInStock == 0)
                .Select(p => p);
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductID}-{item.ProductName}");
            }
            return query.ToList();
        }

        //Ejercicio 3: Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad

        public IEnumerable<Products> ProductInStock()
        {
            var query = context.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3)
                .OrderBy(p => p.UnitPrice).Select(p => p);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.UnitsInStock}-{item.UnitPrice}");
            }
            return query.ToList();
        }

        //Ejercicio 5: Query para devolver el primer elemento o nulo de una lista de productos donde el ID de
        //producto sea igual a 789

        public void OneElement()
        {
            var query = context.Products.Where(p => p.ProductID == 789).FirstOrDefault();
            if(query != null)
            {
                Console.WriteLine(query);
            }
            else
            {
                Console.WriteLine("Nulo");
            }
        }

        //Ejercicio 9: Query para devolver lista de productos ordenados por nombre

        public void ProductsName()
        {
            var query = context.Products.OrderBy(p => p.ProductName)
                .Select(p => p);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName}");
            }
        }

        //Ejercicio 10:  Query para devolver lista de productos ordenados por unit in stock de mayor a menor.

        public String ProductsStock()
        {
            var query = context.Products.OrderByDescending(p => p.UnitsInStock)
                .Select(p => p);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName} -{item.UnitsInStock}");
            }

            return query.ToString();    
        }

        // Ejercicio 11:Query para devolver las distintas categorías asociadas a los productos

        public IQueryable<CategoriesProducts> CategoriesProducts()
        {
            var queryJoineable = from categorie in context.Categories
                        join product in context.Products
                        on categorie.CategoryID equals product.CategoryID
                        select new CategoriesProducts
                        {
                            CategoryID = categorie.CategoryID,
                            CategoryName =  categorie.CategoryName,
                            ProductID = product.ProductID,
                            ProductName = product.ProductName
                        };
            foreach (var item in queryJoineable)
            {
                Console.WriteLine($"{item.CategoryID}-{item.CategoryName} " +
                    $"{item.ProductID}-{item.ProductName}");

            }
            return queryJoineable;   

        }

        //Ejercicio 12: Query para devolver el primer elemento de una lista de productos

        public void FirstProduct()
        {
            var query = context.Products.First();

                Console.WriteLine($"{query.ProductID}{query.ProductName}");
        }
    }
}
