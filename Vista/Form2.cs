using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarkExamenTiendaRopa.Presentador;
using QuarkExamenTiendaRopa.Modelo;
namespace QuarkExamenTiendaRopa.Vista {
    public partial class Form2 : Form , IHistorial{
        public Form2() {
            InitializeComponent();
            
        }

        public Form2(int valor) {
            historialCotizacion = new List<string>();
            indice = valor;
        }

        public List<string> historialCotizacion { get => historialCotizacion; set => historialCotizacion = value; }
        public int indice { get => indice; set => indice = value; }

        /*
        public void llenarTablaCotizacion() {
            present p = new present(this);
            p.indiceDeHistorial();
            for (int j = 0; j < indice; j++) {
                p.historialCotizacion(j);
                int celda = dgv_HistorialCotizacion.Rows.Add();
                for (int i = 0; i < historialCotizacion.Count; i++) {
                    dgv_HistorialCotizacion.Rows[celda].Cells[i].Value = historialCotizacion[i];
                }
            }  
        }
         */
        public void mostrarValores() {
            present p = new present(this);
            p.indiceDeHistorial();
            try {
            p.historialCotizacion(0);

            } catch {
                MessageBox.Show("Ja");
            }
            MessageBox.Show($"{indice} y {historialCotizacion}");
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {}
        private void Form2_Load(object sender, EventArgs e) {}
    }
}
