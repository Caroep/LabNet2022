using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsPoo;

namespace ejcPooConsola
{
    public class Taxi : TransportePublico
    {
        public Taxi() : base()
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