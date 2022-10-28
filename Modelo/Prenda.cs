using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkExamenTiendaRopa.Modelo {
    public abstract class Prenda {

        protected string nombre;
        protected bool calidad;
        protected int cantidadStock;
        protected double precioUnitario;

        public abstract double PrecioRealPorPrenda();
        public abstract int CantidadEnStock();

        public abstract string NombrePropio();

    }
}
