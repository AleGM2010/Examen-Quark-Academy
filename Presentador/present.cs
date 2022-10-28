using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuarkExamenTiendaRopa.Modelo;
using QuarkExamenTiendaRopa.Presentador;
using QuarkExamenTiendaRopa.Vista;



namespace QuarkExamenTiendaRopa.Presentador {
      public class present {
        private IValores IView;
       
        public present(IValores iview) {
            this.IView = iview;          
        }
        public List<List<String>> historialCotizacion() {
            Vendedor v = new Vendedor();
            return v.HistorialCompleto();
        }
      
        public void IniciarValoresVendedorTienda() {
            Tienda t = new Tienda();
            Vendedor v = new Vendedor();
            IView.nombreTienda = $"{t.Nombre}";
            IView.direccionTienda = $"{t.Direccion}";
            IView.nombreVendedorYCodigo = $"{v.Nombre} {v.Apellido} | Codigo: {v.CodigoDeVendedor}";
        }


       
        private Prenda QuePrendaCrear() {      
            if (IView.prenda) {
                Pantalon p = new Pantalon(tipoPantalon: IView.pantalonTipo, calidad: IView.calidad, precio: IView.precioUnitario);
                return p;
            } else {
                Camisa p = new Camisa(manga: IView.manga, cuello: IView.cuello, calidad: IView.calidad, precio: IView.precioUnitario);
                return p;
            }
        }
        private Prenda QuePrendaCrearStock() {
            if (IView.prenda) {
                Pantalon p = new Pantalon(tipoPantalon: IView.pantalonTipo, calidad: IView.calidad);
                return p;
            } else {
                Camisa p = new Camisa(manga: IView.manga, cuello: IView.cuello, calidad: IView.calidad);
                return p;
            }
        }

         public bool Cotizar() {
            Vendedor v = new Vendedor();
            Prenda p = QuePrendaCrear();
            if (IView.cantidadPrenda <= p.CantidadEnStock() && IView.cantidadPrenda >= 0) {
                IView.precio = v.CotizarPrenda(IView.cantidadPrenda, p);
                return true;
            } else {
                return false;
            }
        
         }
      
        public void CantidadStock() {
            Prenda p = QuePrendaCrearStock();          
            IView.cantidadEnStock = p.CantidadEnStock();
        }
     


    } // Fin presentador
}
