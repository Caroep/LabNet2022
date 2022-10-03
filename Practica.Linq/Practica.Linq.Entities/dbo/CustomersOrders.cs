using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Entities
{
    public class CustomersOrder { 

        public String CustomersId{ get; set; }
        public String CustomersCompanyName { get; set; }
        public String CustomersName{ get; set; }
        public String Region { get; set; }
        public DateTime? OrderDate { get; set; }
        public int OrderId { get; set; }
        public int?  OrderShipVia { get; set; }
    }

}
