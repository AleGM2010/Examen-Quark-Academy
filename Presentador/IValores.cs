using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkExamenTiendaRopa {
   public interface IValores {
        /*
        Valores Booleanos para definir el tipo de prenda

                    False            True

        Prenda      Camisa          Pantalon
        Manga       Corta           Larga
        Cuello      Comun           Mao
        Pantalon    Comun           Chupin
        Calidad     Standar         Premium
         */ 
        bool prenda { get; }
        bool manga{ get; }      
        bool cuello { get; }   
        bool pantalonTipo { get; }      
        bool calidad {get;}

        // Valores para Labels de Nombres
        string nombreTienda { set; }
        string direccionTienda { set; }
        string nombreVendedorYCodigo { set; }
       
        // Historial 
        List<List<string>> devolverHistorial();

       // Valores para hacer calculos
        double precio { set; }
        float precioUnitario {get;}
        int cantidadPrenda {get;}
        int cantidadEnStock { set; } 

       

    }
}
