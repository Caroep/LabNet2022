using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejcPooConsola
{
    public abstract class TransportePublico
    {
        private int pasajeros;

        protected TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public TransportePublico()
        {
        }

        public int Pasajeros { get; set; }

        public abstract string Avanzar();

        public abstract string Detenerse();

        public abstract string Mostrar();
    }
}