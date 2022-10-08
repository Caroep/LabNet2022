using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practica.EF.MVC.Data
{
    public class PracticaEFMVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PracticaEFMVCContext() : base("name=PracticaEFMVCContext")
        {
        }

        public System.Data.Entity.DbSet<Practica.EF.Entities.Categories> Categories { get; set; }
    }
}
