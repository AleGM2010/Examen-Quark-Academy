using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkExamenTiendaRopa.Modelo {
    class Tienda {
        private string nombre;
        private string direccion;
        List<Prenda> prendas;


        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }

        public Tienda() {
            this.nombre = "KNAUER";
            this.direccion = " Av. de Acceso Este 3280";          
        }

   

    } // Fin Tienda
}
