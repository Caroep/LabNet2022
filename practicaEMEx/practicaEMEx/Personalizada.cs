using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaEMEx
{
    public class Personalizada : Exception
    {
        public Personalizada() : base("Nueva excepcion personalizada, ")
        {

        }
    }
}
