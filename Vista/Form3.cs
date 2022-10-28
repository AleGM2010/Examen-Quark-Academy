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

namespace QuarkExamenTiendaRopa.Vista {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        public void llenarTablaCotizacion(List<List<string>> ListaListaCot) {
            dgv_TablaCotizacion.Rows.Clear();
            for (int j = 0; j < ListaListaCot.Count; j++) {
                int celda = dgv_TablaCotizacion.Rows.Add();
                for (int i = 0; i < ListaListaCot[j].Count; i++) {
                    dgv_TablaCotizacion.Rows[celda].Cells[i].Value = ListaListaCot[j][i];
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e) {

        }
      

        private void dgv_TablaCotizacion_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btn_Minimizar_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Minimized;
            }
            
        }
      
    }
}
