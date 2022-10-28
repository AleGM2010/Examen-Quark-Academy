using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuarkExamenTiendaRopa.Modelo {
    public class Vendedor {
        private string nombre;
        private string apellido;
        private int codigoDeVendedor;

        public static List<List<string>> historial = new List<List<string>>();
        

        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public int CodigoDeVendedor { get => codigoDeVendedor;}
        

        public Vendedor() {
            nombre = "Franco";
            apellido = "Escamilla";
            codigoDeVendedor = 10001;
        }

        public double CotizarPrenda(int cantidad , Prenda prenda) {
            
            double total= cantidad * prenda.PrecioRealPorPrenda();
            AgregarElementoHistorialCotizacion(cantidad, prenda, total);
            return total;
            

        } 
        public void AgregarElementoHistorialCotizacion(int cantidad, Prenda prenda, double total) {
            List<string> lista = new List<string> { };
            lista.Add((1000+historial.Count).ToString());
            lista.Add(DateTime.Now.ToString());
            lista.Add(CodigoDeVendedor.ToString());
            lista.Add(prenda.NombrePropio());
            lista.Add(cantidad.ToString());
            lista.Add(total.ToString());
            historial.Add(lista);
        }
     
        public List<List<string>> HistorialCompleto() {
            return historial;
        }
    }
}
