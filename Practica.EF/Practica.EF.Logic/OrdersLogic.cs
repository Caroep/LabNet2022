using Practica.EF.Entities;
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
            context.Orders.Remove(ordersAEliminar);
            context.SaveChanges();
        }

        public List<Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public void Update(Orders orders)
        {
            var ordersUpdate = context.Orders.Find(orders.OrderID);
            ordersUpdate.OrderDate = orders.OrderDate;
            context.SaveChanges();
        }
    }
}