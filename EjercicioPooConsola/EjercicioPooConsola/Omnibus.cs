using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejcPooConsola
{
    public class Omnibus : TransportePublico
    {
        public Omnibus() : base()
        {
        }

        public override string Avanzar()
        {
            throw new NotImplementedException();
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }

        public override string Mostrar()
        {
            return String.Format("{0} pasajeros", Pasajeros);
        }
    }
}