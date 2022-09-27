using Practica.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Practica.EF.Logic
{
    public class ShippersLogic : BaseLogic,IABMLogic<Shippers>
    {
        public void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shipperAEliminar = context.Shippers.Find(id);
            context.Shippers.Remove(shipperAEliminar);
            context.SaveChanges();
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Update(Shippers shipper)
        {
            var shipperUpdate = context.Shippers.Find(shipper.ShipperID);
            shipperUpdate.CompanyName= shipper.CompanyName;
            context.SaveChanges();
        }
    }
}
