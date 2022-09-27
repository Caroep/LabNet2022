using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica.EF.Logic
{
    public class OrdersLogic : BaseLogic, IABMLogic<Orders>
    {
    public void Add(Orders newOrders)
        {
            context.Orders.Add(newOrders);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ordersAEliminar = context.Orders.Find(id);
            if (ordersAEliminar != null)
            {
                context.Orders.Remove(ordersAEliminar);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("ERROR: EL ID SELECCIONADO ES NULO");
                Console.WriteLine(" ");
            }    
        }

        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public void Update(Orders orders)
        {
            var ordersUpdate = context.Orders.Find(orders.OrderID);
            if (ordersUpdate != null)
            {
                ordersUpdate.ShipName = orders.ShipName;
                ordersUpdate.ShipAddress = orders.ShipAddress;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("ERROR: EL ID SELECCIONADO ES NULO");
                Console.WriteLine(" ");
            }
        }
    }
}