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
using QuarkExamenTiendaRopa.Vista;



namespace QuarkExamenTiendaRopa {
    public partial class Form1 : Form, IValores {
        public Form1() {
            InitializeComponent();
            IniciarVendedorYTienda();
        }
        // Accion iniciar valores
        void IniciarVendedorYTienda() {
            present p = new present(this);
            p.IniciarValoresVendedorTienda();

        }

        Form3 auxiliarForm = null;
        
       

        // Atributos y metodos de la interface
        public string nombreTienda { set => lbl_NombreTienda.Text = value; }
        public string direccionTienda { set => lbl_DireccionTienda.Text = value; }
        public string nombreVendedorYCodigo { set => lbl_NombreVendedorYCodigo.Text = value; }
        public bool prenda { get => rdb_Pantalon.Checked; }
        public bool manga { get => rdb_MangaLarga.Checked; }
        public bool cuello { get => rdb_CuelloMao.Checked; }
        public bool pantalonTipo { get => rdb_PantalonChupin.Checked; }
        public bool calidad { get => rdb_calidadPremium.Checked; }
        public float precioUnitario { get => float.Parse(txb_precioUnitario.Text); }
        public int cantidadPrenda { get => int.Parse(txb_cantidad.Text); }
        public int cantidadEnStock { set => lbl_cantidadEnStock.Text = value.ToString(); }
        public double precio { set => lbl_cotizar.Text = "$ " + value.ToString(); }
        public List<List<string>> devolverHistorial() {
            present p = new present(this);
            return p.historialCotizacion();
        }


        
        // Metodo de control e informacion de botones

      
        // Si el Form3 ya esta creado , no crea uno nuevo y lo actualiza 
        // Si cierro auxiliar , no va a poder acceder y pasara al catch
        public void CrearOActualizarTablaCotizacion(bool condicion) {
            try { 
                auxiliarForm.llenarTablaCotizacion(devolverHistorial());
                this.auxiliarForm.Show();
            } 
            catch { // condicion es para saber si el boton Historial llama este metodo
                if (condicion) {
                    Form3 formGrid = new Form3();
                    this.auxiliarForm = formGrid;
                    auxiliarForm.Show();
                    auxiliarForm.llenarTablaCotizacion(devolverHistorial());
                }
            } 
        }
        public bool checkBotones() {
            return ((rdb_Pantalon.Checked) && (rdb_PantalonChupin.Checked ^ rdb_PantalonComun.Checked)) || (rdb_Camisa.Checked) && ((rdb_MangaCorta.Checked ^ rdb_MangaLarga.Checked) && (rdb_CuelloComun.Checked ^ rdb_CuelloMao.Checked));
        }

        private void btn_cotizar_Click(object sender, EventArgs e) {
            if (checkBotones()) {

            try {
                present p = new present(this);
                if (p.Cotizar()) {                   
                    CrearOActualizarTablaCotizacion(false);                   
                } else {
                    MessageBox.Show("Cantidad no debe superar el Stock o ser Negativa", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch {             
                MessageBox.Show("El Precio y Cantidad deben ser numericos\n", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            } else {
                MessageBox.Show("Debe seleccionar tipo de Prenda","Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_HistorialCotizacion_Click(object sender, EventArgs e) {
            CrearOActualizarTablaCotizacion(true);           
        }
        

        void cantidadStockPrenda() {

            present p = new present(this);
            p.CantidadStock();
        }
        public void mostrarCantidadEnStock() {
            lbl_cantidadEnStock.Text = 0.ToString()+"  (Completar Prenda)";
            if (rdb_Pantalon.Checked) {
                if (rdb_PantalonChupin.Checked ^ rdb_PantalonComun.Checked) {
                    cantidadStockPrenda();
                }
            }
            if (rdb_Camisa.Checked) {
                if ((rdb_MangaCorta.Checked ^ rdb_MangaLarga.Checked) && (rdb_CuelloComun.Checked ^ rdb_CuelloMao.Checked)) {
                    cantidadStockPrenda();
                }
            }
        }


        // Botones
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {

        }
        private void rdb_Camisa_CheckedChanged(object sender, EventArgs e) {
            mostrarCantidadEnStock();

            gpb_Manga.Enabled = true;
            gpb_Cuello.Enabled = true;

            rdb_PantalonComun.Checked = false;
            rdb_PantalonChupin.Checked = false;

            if (rdb_Camisa.Checked) {
                gpb_pantalon.Enabled = false;
            }
        }
        private void rdb_Pantalon_CheckedChanged(object sender, EventArgs e) {
            mostrarCantidadEnStock();

            gpb_pantalon.Enabled = true;

            rdb_MangaCorta.Checked = false;
            rdb_MangaLarga.Checked = false;
            rdb_CuelloComun.Checked = false;
            rdb_CuelloMao.Checked = false;

            if (rdb_Pantalon.Checked) {

                gpb_Manga.Enabled = false;
                gpb_Cuello.Enabled = false;
            }
        }
        private void rdb_MangaCorta_CheckedChanged(object sender, EventArgs e) {
            mostrarCantidadEnStock();
        }
        private void rdb_MangaLarga_CheckedChanged(object sender, EventArgs e) {
            mostrarCantidadEnStock();
        }
        private void rdb_CuelloComun_CheckedChanged(object sender, EventArgs e) {
            mostrarCantidadEnStock();
        }
        private void rdb_CuelloMao_CheckedChanged(object sender, EventArgs e) {
            mostrarCantidadEnStock();
        }
        private void rdb_PantalonComun_CheckedChanged(object sender, EventArgs e) {
            mostrarCantidadEnStock();
        }
        private void rdb_PantalonChupin_CheckedChanged(object sender, EventArgs e) {
            mostrarCantidadEnStock();
        }
        private void lbl_NombreVendedorYCodigo_Click(object sender, EventArgs e) {}


    } // Fin Form1

} 





