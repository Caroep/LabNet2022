﻿using Practica.EF.Entities;
using System;
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
            if (shipperAEliminar != null)
            {
                context.Shippers.Remove(shipperAEliminar);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("No se pudo realizar la operación solicitada");
            }
        }

        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Update(Shippers shipper)
        {
            var shipperUpdate = context.Shippers.Find(shipper.ShipperID);
            if (shipperUpdate != null)
            {
                shipperUpdate.CompanyName = shipper.CompanyName;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("No se pudo realizar la operación solicitada");
            }
        }
    }
}
