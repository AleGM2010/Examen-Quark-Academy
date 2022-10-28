
namespace QuarkExamenTiendaRopa.Vista {
    partial class Form3 {
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
            this.dgv_TablaCotizacion = new System.Windows.Forms.DataGridView();
            this.Nident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrendaCoti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaCotizacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_TablaCotizacion
            // 
            this.dgv_TablaCotizacion.AllowUserToAddRows = false;
            this.dgv_TablaCotizacion.AllowUserToDeleteRows = false;
            this.dgv_TablaCotizacion.AllowUserToOrderColumns = true;
            this.dgv_TablaCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TablaCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nident,
            this.fechaHora,
            this.CodigoVendedor,
            this.PrendaCoti,
            this.Cantidad,
            this.Precio});
            this.dgv_TablaCotizacion.Location = new System.Drawing.Point(0, 42);
            this.dgv_TablaCotizacion.Name = "dgv_TablaCotizacion";
            this.dgv_TablaCotizacion.ReadOnly = true;
            this.dgv_TablaCotizacion.Size = new System.Drawing.Size(814, 339);
            this.dgv_TablaCotizacion.TabIndex = 0;
            this.dgv_TablaCotizacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TablaCotizacion_CellContentClick);
            // 
            // Nident
            // 
            this.Nident.HeaderText = "N° Identificacion";
            this.Nident.Name = "Nident";
            this.Nident.ReadOnly = true;
            this.Nident.Width = 120;
            // 
            // fechaHora
            // 
            this.fechaHora.HeaderText = "Fecha y Hora";
            this.fechaHora.Name = "fechaHora";
            this.fechaHora.ReadOnly = true;
            this.fechaHora.Width = 150;
            // 
            // CodigoVendedor
            // 
            this.CodigoVendedor.HeaderText = "Codigo Vendedor";
            this.CodigoVendedor.Name = "CodigoVendedor";
            this.CodigoVendedor.ReadOnly = true;
            this.CodigoVendedor.Width = 120;
            // 
            // PrendaCoti
            // 
            this.PrendaCoti.HeaderText = "Prenda";
            this.PrendaCoti.Name = "PrendaCoti";
            this.PrendaCoti.ReadOnly = true;
            this.PrendaCoti.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio ";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 36);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla de Cotizaciones realizadas";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(813, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_TablaCotizacion);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaCotizacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TablaCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nident;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrendaCoti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}