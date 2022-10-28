
namespace QuarkExamenTiendaRopa {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_DireccionTienda = new System.Windows.Forms.Label();
            this.lbl_NombreTienda = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_cotizar = new System.Windows.Forms.Label();
            this.btn_cotizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpb_pantalon = new System.Windows.Forms.GroupBox();
            this.rdb_PantalonComun = new System.Windows.Forms.RadioButton();
            this.rdb_PantalonChupin = new System.Windows.Forms.RadioButton();
            this.gpb_Cuello = new System.Windows.Forms.GroupBox();
            this.rdb_CuelloMao = new System.Windows.Forms.RadioButton();
            this.rdb_CuelloComun = new System.Windows.Forms.RadioButton();
            this.gpb_Manga = new System.Windows.Forms.GroupBox();
            this.rdb_MangaLarga = new System.Windows.Forms.RadioButton();
            this.rdb_MangaCorta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_Pantalon = new System.Windows.Forms.RadioButton();
            this.rdb_Camisa = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_cantidadEnStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb_calidadPremium = new System.Windows.Forms.RadioButton();
            this.rdb_calidadStandar = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_cantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_precioUnitario = new System.Windows.Forms.TextBox();
            this.lbl_NombreVendedorYCodigo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_HistorialCotizacion = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpb_pantalon.SuspendLayout();
            this.gpb_Cuello.SuspendLayout();
            this.gpb_Manga.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(98, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tu cotizador de confianza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbl_DireccionTienda);
            this.panel2.Controls.Add(this.lbl_NombreTienda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 40);
            this.panel2.TabIndex = 1;
            // 
            // lbl_DireccionTienda
            // 
            this.lbl_DireccionTienda.AutoSize = true;
            this.lbl_DireccionTienda.Location = new System.Drawing.Point(314, 13);
            this.lbl_DireccionTienda.Name = "lbl_DireccionTienda";
            this.lbl_DireccionTienda.Size = new System.Drawing.Size(88, 13);
            this.lbl_DireccionTienda.TabIndex = 1;
            this.lbl_DireccionTienda.Text = "Direccion Tienda";
            // 
            // lbl_NombreTienda
            // 
            this.lbl_NombreTienda.AutoSize = true;
            this.lbl_NombreTienda.Location = new System.Drawing.Point(20, 13);
            this.lbl_NombreTienda.Name = "lbl_NombreTienda";
            this.lbl_NombreTienda.Size = new System.Drawing.Size(47, 13);
            this.lbl_NombreTienda.TabIndex = 0;
            this.lbl_NombreTienda.Text = "Nombre ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 5);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_cotizar);
            this.panel4.Controls.Add(this.btn_cotizar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 574);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 77);
            this.panel4.TabIndex = 3;
            // 
            // lbl_cotizar
            // 
            this.lbl_cotizar.AutoSize = true;
            this.lbl_cotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cotizar.Location = new System.Drawing.Point(257, 24);
            this.lbl_cotizar.Name = "lbl_cotizar";
            this.lbl_cotizar.Size = new System.Drawing.Size(32, 29);
            this.lbl_cotizar.TabIndex = 1;
            this.lbl_cotizar.Text = "$ ";
            // 
            // btn_cotizar
            // 
            this.btn_cotizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotizar.Location = new System.Drawing.Point(38, 18);
            this.btn_cotizar.Name = "btn_cotizar";
            this.btn_cotizar.Size = new System.Drawing.Size(124, 47);
            this.btn_cotizar.TabIndex = 0;
            this.btn_cotizar.Text = "Cotizar";
            this.btn_cotizar.UseVisualStyleBackColor = false;
            this.btn_cotizar.Click += new System.EventHandler(this.btn_cotizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.gpb_pantalon);
            this.groupBox1.Controls.Add(this.gpb_Cuello);
            this.groupBox1.Controls.Add(this.gpb_Manga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdb_Pantalon);
            this.groupBox1.Controls.Add(this.rdb_Camisa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 220);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gpb_pantalon
            // 
            this.gpb_pantalon.Controls.Add(this.rdb_PantalonComun);
            this.gpb_pantalon.Controls.Add(this.rdb_PantalonChupin);
            this.gpb_pantalon.Enabled = false;
            this.gpb_pantalon.Location = new System.Drawing.Point(145, 162);
            this.gpb_pantalon.Name = "gpb_pantalon";
            this.gpb_pantalon.Size = new System.Drawing.Size(205, 50);
            this.gpb_pantalon.TabIndex = 0;
            this.gpb_pantalon.TabStop = false;
            // 
            // rdb_PantalonComun
            // 
            this.rdb_PantalonComun.AutoSize = true;
            this.rdb_PantalonComun.Location = new System.Drawing.Point(24, 13);
            this.rdb_PantalonComun.Name = "rdb_PantalonComun";
            this.rdb_PantalonComun.Size = new System.Drawing.Size(68, 20);
            this.rdb_PantalonComun.TabIndex = 4;
            this.rdb_PantalonComun.TabStop = true;
            this.rdb_PantalonComun.Text = "Comun";
            this.rdb_PantalonComun.UseVisualStyleBackColor = true;
            this.rdb_PantalonComun.CheckedChanged += new System.EventHandler(this.rdb_PantalonComun_CheckedChanged);
            // 
            // rdb_PantalonChupin
            // 
            this.rdb_PantalonChupin.AutoSize = true;
            this.rdb_PantalonChupin.Location = new System.Drawing.Point(125, 13);
            this.rdb_PantalonChupin.Name = "rdb_PantalonChupin";
            this.rdb_PantalonChupin.Size = new System.Drawing.Size(67, 20);
            this.rdb_PantalonChupin.TabIndex = 10;
            this.rdb_PantalonChupin.TabStop = true;
            this.rdb_PantalonChupin.Text = "Chupín";
            this.rdb_PantalonChupin.UseVisualStyleBackColor = true;
            this.rdb_PantalonChupin.CheckedChanged += new System.EventHandler(this.rdb_PantalonChupin_CheckedChanged);
            // 
            // gpb_Cuello
            // 
            this.gpb_Cuello.Controls.Add(this.rdb_CuelloMao);
            this.gpb_Cuello.Controls.Add(this.rdb_CuelloComun);
            this.gpb_Cuello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Cuello.Location = new System.Drawing.Point(145, 80);
            this.gpb_Cuello.Name = "gpb_Cuello";
            this.gpb_Cuello.Size = new System.Drawing.Size(205, 50);
            this.gpb_Cuello.TabIndex = 9;
            this.gpb_Cuello.TabStop = false;
            this.gpb_Cuello.Text = "Cuello";
            // 
            // rdb_CuelloMao
            // 
            this.rdb_CuelloMao.AutoSize = true;
            this.rdb_CuelloMao.Location = new System.Drawing.Point(125, 21);
            this.rdb_CuelloMao.Name = "rdb_CuelloMao";
            this.rdb_CuelloMao.Size = new System.Drawing.Size(53, 20);
            this.rdb_CuelloMao.TabIndex = 3;
            this.rdb_CuelloMao.Text = "Mao";
            this.rdb_CuelloMao.UseVisualStyleBackColor = true;
            this.rdb_CuelloMao.CheckedChanged += new System.EventHandler(this.rdb_CuelloMao_CheckedChanged);
            // 
            // rdb_CuelloComun
            // 
            this.rdb_CuelloComun.AutoSize = true;
            this.rdb_CuelloComun.Checked = true;
            this.rdb_CuelloComun.Location = new System.Drawing.Point(27, 21);
            this.rdb_CuelloComun.Name = "rdb_CuelloComun";
            this.rdb_CuelloComun.Size = new System.Drawing.Size(68, 20);
            this.rdb_CuelloComun.TabIndex = 2;
            this.rdb_CuelloComun.TabStop = true;
            this.rdb_CuelloComun.Text = "Comun";
            this.rdb_CuelloComun.UseVisualStyleBackColor = true;
            this.rdb_CuelloComun.CheckedChanged += new System.EventHandler(this.rdb_CuelloComun_CheckedChanged);
            // 
            // gpb_Manga
            // 
            this.gpb_Manga.Controls.Add(this.rdb_MangaLarga);
            this.gpb_Manga.Controls.Add(this.rdb_MangaCorta);
            this.gpb_Manga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_Manga.Location = new System.Drawing.Point(145, 21);
            this.gpb_Manga.Name = "gpb_Manga";
            this.gpb_Manga.Size = new System.Drawing.Size(205, 50);
            this.gpb_Manga.TabIndex = 5;
            this.gpb_Manga.TabStop = false;
            this.gpb_Manga.Text = "Manga";
            // 
            // rdb_MangaLarga
            // 
            this.rdb_MangaLarga.AutoSize = true;
            this.rdb_MangaLarga.Location = new System.Drawing.Point(125, 21);
            this.rdb_MangaLarga.Name = "rdb_MangaLarga";
            this.rdb_MangaLarga.Size = new System.Drawing.Size(61, 20);
            this.rdb_MangaLarga.TabIndex = 1;
            this.rdb_MangaLarga.Text = "Larga";
            this.rdb_MangaLarga.UseVisualStyleBackColor = true;
            this.rdb_MangaLarga.CheckedChanged += new System.EventHandler(this.rdb_MangaLarga_CheckedChanged);
            // 
            // rdb_MangaCorta
            // 
            this.rdb_MangaCorta.AutoSize = true;
            this.rdb_MangaCorta.Checked = true;
            this.rdb_MangaCorta.Location = new System.Drawing.Point(27, 21);
            this.rdb_MangaCorta.Name = "rdb_MangaCorta";
            this.rdb_MangaCorta.Size = new System.Drawing.Size(58, 20);
            this.rdb_MangaCorta.TabIndex = 0;
            this.rdb_MangaCorta.TabStop = true;
            this.rdb_MangaCorta.Text = "Corta";
            this.rdb_MangaCorta.UseVisualStyleBackColor = true;
            this.rdb_MangaCorta.CheckedChanged += new System.EventHandler(this.rdb_MangaCorta_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "_____________________________________________________";
            // 
            // rdb_Pantalon
            // 
            this.rdb_Pantalon.AutoSize = true;
            this.rdb_Pantalon.Location = new System.Drawing.Point(20, 175);
            this.rdb_Pantalon.Name = "rdb_Pantalon";
            this.rdb_Pantalon.Size = new System.Drawing.Size(79, 20);
            this.rdb_Pantalon.TabIndex = 3;
            this.rdb_Pantalon.Text = "Pantalón";
            this.rdb_Pantalon.UseVisualStyleBackColor = true;
            this.rdb_Pantalon.CheckedChanged += new System.EventHandler(this.rdb_Pantalon_CheckedChanged);
            // 
            // rdb_Camisa
            // 
            this.rdb_Camisa.AutoSize = true;
            this.rdb_Camisa.Checked = true;
            this.rdb_Camisa.Location = new System.Drawing.Point(20, 30);
            this.rdb_Camisa.Name = "rdb_Camisa";
            this.rdb_Camisa.Size = new System.Drawing.Size(72, 20);
            this.rdb_Camisa.TabIndex = 0;
            this.rdb_Camisa.TabStop = true;
            this.rdb_Camisa.Text = "Camisa";
            this.rdb_Camisa.UseVisualStyleBackColor = true;
            this.rdb_Camisa.CheckedChanged += new System.EventHandler(this.rdb_Camisa_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_cantidadEnStock);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(38, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 44);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // lbl_cantidadEnStock
            // 
            this.lbl_cantidadEnStock.AutoSize = true;
            this.lbl_cantidadEnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadEnStock.Location = new System.Drawing.Point(221, 16);
            this.lbl_cantidadEnStock.Name = "lbl_cantidadEnStock";
            this.lbl_cantidadEnStock.Size = new System.Drawing.Size(32, 16);
            this.lbl_cantidadEnStock.TabIndex = 6;
            this.lbl_cantidadEnStock.Text = "150";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unidades en Stock disponibles: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb_calidadPremium);
            this.groupBox3.Controls.Add(this.rdb_calidadStandar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 83);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad de la Prenda";
            // 
            // rdb_calidadPremium
            // 
            this.rdb_calidadPremium.AutoSize = true;
            this.rdb_calidadPremium.Location = new System.Drawing.Point(20, 48);
            this.rdb_calidadPremium.Name = "rdb_calidadPremium";
            this.rdb_calidadPremium.Size = new System.Drawing.Size(79, 20);
            this.rdb_calidadPremium.TabIndex = 1;
            this.rdb_calidadPremium.Text = "Premium";
            this.rdb_calidadPremium.UseVisualStyleBackColor = true;
            // 
            // rdb_calidadStandar
            // 
            this.rdb_calidadStandar.AutoSize = true;
            this.rdb_calidadStandar.Checked = true;
            this.rdb_calidadStandar.Location = new System.Drawing.Point(20, 22);
            this.rdb_calidadStandar.Name = "rdb_calidadStandar";
            this.rdb_calidadStandar.Size = new System.Drawing.Size(73, 20);
            this.rdb_calidadStandar.TabIndex = 0;
            this.rdb_calidadStandar.TabStop = true;
            this.rdb_calidadStandar.Text = "Standar";
            this.rdb_calidadStandar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txb_cantidad);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txb_precioUnitario);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(219, 468);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 83);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio unitario y Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // txb_cantidad
            // 
            this.txb_cantidad.Location = new System.Drawing.Point(156, 33);
            this.txb_cantidad.Name = "txb_cantidad";
            this.txb_cantidad.Size = new System.Drawing.Size(50, 22);
            this.txb_cantidad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "$";
            // 
            // txb_precioUnitario
            // 
            this.txb_precioUnitario.Location = new System.Drawing.Point(33, 33);
            this.txb_precioUnitario.Name = "txb_precioUnitario";
            this.txb_precioUnitario.Size = new System.Drawing.Size(37, 22);
            this.txb_precioUnitario.TabIndex = 0;
            // 
            // lbl_NombreVendedorYCodigo
            // 
            this.lbl_NombreVendedorYCodigo.AutoSize = true;
            this.lbl_NombreVendedorYCodigo.Location = new System.Drawing.Point(20, 13);
            this.lbl_NombreVendedorYCodigo.Name = "lbl_NombreVendedorYCodigo";
            this.lbl_NombreVendedorYCodigo.Size = new System.Drawing.Size(90, 13);
            this.lbl_NombreVendedorYCodigo.TabIndex = 2;
            this.lbl_NombreVendedorYCodigo.Text = "Nombre V Codigo";
            this.lbl_NombreVendedorYCodigo.Click += new System.EventHandler(this.lbl_NombreVendedorYCodigo_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.btn_HistorialCotizacion);
            this.panel5.Controls.Add(this.lbl_NombreVendedorYCodigo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(475, 40);
            this.panel5.TabIndex = 8;
            // 
            // btn_HistorialCotizacion
            // 
            this.btn_HistorialCotizacion.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_HistorialCotizacion.FlatAppearance.BorderSize = 0;
            this.btn_HistorialCotizacion.Location = new System.Drawing.Point(359, 8);
            this.btn_HistorialCotizacion.Name = "btn_HistorialCotizacion";
            this.btn_HistorialCotizacion.Size = new System.Drawing.Size(75, 23);
            this.btn_HistorialCotizacion.TabIndex = 3;
            this.btn_HistorialCotizacion.Text = "Historial";
            this.btn_HistorialCotizacion.UseVisualStyleBackColor = false;
            this.btn_HistorialCotizacion.Click += new System.EventHandler(this.btn_HistorialCotizacion_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 5);
            this.panel6.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(475, 651);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tienda de Ropa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpb_pantalon.ResumeLayout(false);
            this.gpb_pantalon.PerformLayout();
            this.gpb_Cuello.ResumeLayout(false);
            this.gpb_Cuello.PerformLayout();
            this.gpb_Manga.ResumeLayout(false);
            this.gpb_Manga.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_cotizar;
        private System.Windows.Forms.Button btn_cotizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_Pantalon;
        private System.Windows.Forms.RadioButton rdb_Camisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpb_Manga;
        private System.Windows.Forms.GroupBox gpb_Cuello;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_cantidadEnStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_calidadPremium;
        private System.Windows.Forms.RadioButton rdb_calidadStandar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txb_cantidad;
        private System.Windows.Forms.TextBox txb_precioUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpb_pantalon;
        private System.Windows.Forms.RadioButton rdb_PantalonChupin;
        private System.Windows.Forms.RadioButton rdb_PantalonComun;
        private System.Windows.Forms.RadioButton rdb_CuelloMao;
        private System.Windows.Forms.RadioButton rdb_CuelloComun;
        private System.Windows.Forms.RadioButton rdb_MangaLarga;
        private System.Windows.Forms.RadioButton rdb_MangaCorta;
        private System.Windows.Forms.Label lbl_DireccionTienda;
        private System.Windows.Forms.Label lbl_NombreTienda;
        private System.Windows.Forms.Label lbl_NombreVendedorYCodigo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_HistorialCotizacion;
    }
}

