using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuarkExamenTiendaRopa.Modelo {
    public class  Pantalon : Prenda {
        
        public string Nombre { get => nombre;}
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }

        public Pantalon(bool tipoPantalon, bool calidad) {
            this.calidad = calidad;
            this.cantidadStock = tipoPantalon ? (calidad ? 750 : 750) : (calidad ? 250 : 250);
        }
        public Pantalon(bool tipoPantalon, bool calidad,float precio) {
            this.calidad = calidad;
            this.nombre = tipoPantalon ? calidad? ("Pantalon Chupin Premium") :("Pantalon Chupin Standar") : calidad ? ("Pantalon Comun Premium") : ("Pantalon Comun Standar");      
            this.cantidadStock = tipoPantalon ? ( calidad? 750:750 ) : ( calidad? 250 : 250 );
            PrecioUnitario = precio;
            if (tipoPantalon) {
                PrecioUnitario *= 0.88;
            }       
            if (calidad) {
                PrecioUnitario *= 1.3;
            }
        }
       
        public override double PrecioRealPorPrenda() {
            return PrecioUnitario;
        }

        public override int CantidadEnStock() {
            return CantidadStock;
        }
        public override string NombrePropio() {
            return Nombre;
        }

    }
}
