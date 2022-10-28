
namespace QuarkExamenTiendaRopa.Vista {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv_HistorialCotizacion = new System.Windows.Forms.DataGridView();
            this.NumeroIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaYHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrendaCotizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCotizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistorialCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HistorialCotizacion
            // 
            this.dgv_HistorialCotizacion.AllowUserToAddRows = false;
            this.dgv_HistorialCotizacion.AllowUserToDeleteRows = false;
            this.dgv_HistorialCotizacion.AllowUserToOrderColumns = true;
            this.dgv_HistorialCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HistorialCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroIdentificacion,
            this.FechaYHora,
            this.CodigoVendedor,
            this.PrendaCotizada,
            this.Unidades,
            this.totalCotizado});
            this.dgv_HistorialCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HistorialCotizacion.Location = new System.Drawing.Point(0, 0);
            this.dgv_HistorialCotizacion.Name = "dgv_HistorialCotizacion";
            this.dgv_HistorialCotizacion.ReadOnly = true;
            this.dgv_HistorialCotizacion.Size = new System.Drawing.Size(708, 364);
            this.dgv_HistorialCotizacion.TabIndex = 0;
            this.dgv_HistorialCotizacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumeroIdentificacion
            // 
            this.NumeroIdentificacion.HeaderText = "N° Identificacion";
            this.NumeroIdentificacion.Name = "NumeroIdentificacion";
            this.NumeroIdentificacion.ReadOnly = true;
            this.NumeroIdentificacion.Width = 135;
            // 
            // FechaYHora
            // 
            this.FechaYHora.HeaderText = "Fecha y Hora";
            this.FechaYHora.Name = "FechaYHora";
            this.FechaYHora.ReadOnly = true;
            // 
            // CodigoVendedor
            // 
            this.CodigoVendedor.HeaderText = "Codigo del Vendedor";
            this.CodigoVendedor.Name = "CodigoVendedor";
            this.CodigoVendedor.ReadOnly = true;
            this.CodigoVendedor.Width = 130;
            // 
            // PrendaCotizada
            // 
            this.PrendaCotizada.HeaderText = "Prenda";
            this.PrendaCotizada.Name = "PrendaCotizada";
            this.PrendaCotizada.ReadOnly = true;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.ReadOnly = true;
            // 
            // totalCotizado
            // 
            this.totalCotizado.HeaderText = "Total";
            this.totalCotizado.Name = "totalCotizado";
            this.totalCotizado.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 364);
            this.Controls.Add(this.dgv_HistorialCotizacion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistorialCotizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HistorialCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaYHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrendaCotizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCotizado;
    }
}