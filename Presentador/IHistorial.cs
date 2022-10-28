using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarkExamenTiendaRopa.Presentador {
    public interface IHistorial {

        List<string> historialCotizacion { get; set; }
        int indice { get; set; }
    }
}
