using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkExamenTiendaRopa.Modelo {
    public class Camisa : Prenda {
        
        public string Nombre { get => nombre; }
        public bool Calidad { get => calidad; set => calidad = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }

        public Camisa(bool manga, bool cuello, bool calidad) {
            Calidad = calidad;
            CantidadStock = manga ? (cuello ? Calidad ? (75) : (75) : Calidad ? (175) : (175)) : (cuello ? Calidad ? (100) : (100) : Calidad ? (150) : (150));
        }
        public Camisa(bool manga, bool cuello,bool calidad, float precio) {
            Calidad = calidad;
            this.nombre = manga ? (cuello ? Calidad ? ("Camisa M.Larga Mao Premium") : ("Camisa M.Larga Mao Standar") : Calidad ? ("Camisa M.Larga Premium") : ("Camisa M.Larga Mao Standar")) : (cuello ? Calidad ? ("Camisa M.Corta Mao Premium") : ("Camisa M.Corta Mao Standar") : Calidad ? ("Camisa M.Corta Premium") : ("Camisa M.Corta Standar"));
            CantidadStock = manga ? (cuello ? Calidad ? (75) : (75) : Calidad ? (175) : (175)) : (cuello ? Calidad ? (100) : (100) : Calidad ? (150) : (150));
            PrecioUnitario = precio;
            if (!manga) {
                PrecioUnitario *= 0.9;
            }
            if (cuello) {
                    PrecioUnitario *= 1.03;
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
