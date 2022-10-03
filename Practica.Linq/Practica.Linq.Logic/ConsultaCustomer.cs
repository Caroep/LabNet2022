using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Practica.Linq.Data;
using Practica.Linq.Entities;


namespace Practica.Linq.Logic
{
    public class ConsultaCustomer : BaseLogic<Customers>
    {
        //Ejercicio 1: Query para devolver objeto customer.

        public String OneGetCustomer(String customerId)
        {
            var query = context.Customers.Where(c => c.CustomerID == customerId)
                .ToList();
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CustomerID}- {item.CompanyName}");
            }
           return query.ToString();
        }

        //Ejercicio 4: Query para devolver todos los customers de la Región WA
        public String CustomerWA()
        {
            var query = from custormer in context.Customers
                        where(custormer.Region == "WA") 
                        select custormer;
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CustomerID}- {item.Region}");
            }
            return query.ToString();
        }

        //Ejercicio 6: Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.

        public void CustomerTU_TL()
        {
            var query = context.Customers;
            foreach (var item in query)
            {
                Console.WriteLine($"NOMBRE EN MINUSCULA: {item.CompanyName.ToLower()}"); 
                Console.WriteLine($"NOMBRE EN MAYUSCULA: {item.CompanyName.ToUpper()}");
                Console.WriteLine("-------------------------------------------------------");
            }

        }

        //Ejercicio 7: Query para devolver Join entre Customers y Orders donde los customers sean de la 
        //Región WA y la fecha de orden sea mayor a 1/1/1997.

        public IEnumerable<CustomersOrder> CustomersOrdersRegFecha()
        {
            var queryJoin = context.Customers.Join(context.Orders, c => c.CustomerID, o => o.CustomerID,
                (c, o) => new CustomersOrder
                {
                   Region =  c.Region,
                   OrderDate = o.OrderDate
                }).Where(c => c.Region == "WA").Where(o => o.OrderDate > new DateTime(1997, 01, 01));

            foreach (var item in queryJoin)
            {
                Console.WriteLine($"{item.Region} - {item.OrderDate}");
            }
            return queryJoin;
        }


        //Ejercicio 8: Query para devolver los primeros 3 Customers de la  Región WA

        public void Custormers3WA()
        {
            var query = context.Customers.Where(c => c.Region == "WA")
                .Take(3).OrderByDescending(c => c.CustomerID).Select(c => c);
           
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CustomerID}- {item.Region}");
            }
        }

        //Ejercicio 13: Query para devolver los customer con la cantidad de ordenes asociadas

        public void CustOrd()
        {
            var query = from customer in context.Customers
                        join order in context.Orders
                        on customer.CustomerID equals order.CustomerID
                        select new CustomersOrder
                        {
                            CustomersId =  customer.CustomerID,
                            CustomersCompanyName = customer.CompanyName,
                            OrderId =  order.OrderID,
                            OrderShipVia = order.ShipVia
                        };
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CustomersId}-{item.CustomersName}-" +
                    $"{item.OrderId} - {item.OrderShipVia}");
            }
        }
    }
}
