using Practica.Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.common
{
    public class Validaciones
    {
        public Boolean ValidarEntrada(String ingreso)
        {
            int cont = ingreso.Length;
            if(ingreso.Trim() != String.Empty)
            {
                if(cont == 5) 
                {
                    return true;
                }
            }
            return false;
        }

        public void IsNull(String cust)
        {
            if(cust.Length == 0 )
            {
                Console.WriteLine("El id no se encuentra en en la tabla Customers");
            }
        }
    }
}
