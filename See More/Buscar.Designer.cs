namespace See_More
{
    partial class Buscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNombreSerie = new System.Windows.Forms.Label();
            this.lblSinUso = new System.Windows.Forms.Label();
            this.dgvCuenta = new System.Windows.Forms.DataGridView();
            this.txtNombreSerie = new System.Windows.Forms.TextBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltros = new System.Windows.Forms.ComboBox();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.pnlRespaldo = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblDatoInfo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtNombreApartado = new System.Windows.Forms.TextBox();
            this.lblNombreApar = new System.Windows.Forms.Label();
            this.lblApartadoE = new System.Windows.Forms.Label();
            this.txtBuscarApartado = new System.Windows.Forms.TextBox();
            this.lblApartado = new System.Windows.Forms.Label();
            this.txtCrearApartado = new System.Windows.Forms.TextBox();
            this.lblCreacionApartado = new System.Windows.Forms.Label();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.apartadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEnElApartadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearApartadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverAlApartadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarARaizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoFuncionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrRefresco = new System.Windows.Forms.Timer(this.components);
            this.regresarALaCarpetaAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.mspMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreSerie
            // 
            this.lblNombreSerie.AutoSize = true;
            this.lblNombreSerie.BackColor = System.Drawing.Color.White;
            this.lblNombreSerie.Location = new System.Drawing.Point(4, 24);
            this.lblNombreSerie.Name = "lblNombreSerie";
            this.lblNombreSerie.Size = new System.Drawing.Size(137, 13);
            this.lblNombreSerie.TabIndex = 3;
            this.lblNombreSerie.Text = "Busca el nombre de la serie";
            // 
            // lblSinUso
            // 
            this.lblSinUso.AutoSize = true;
            this.lblSinUso.Location = new System.Drawing.Point(311, 71);
            this.lblSinUso.Name = "lblSinUso";
            this.lblSinUso.Size = new System.Drawing.Size(0, 13);
            this.lblSinUso.TabIndex = 4;
            // 
            // dgvCuenta
            // 
            this.dgvCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuenta.Location = new System.Drawing.Point(423, 12);
            this.dgvCuenta.Name = "dgvCuenta";
            this.dgvCuenta.Size = new System.Drawing.Size(249, 146);
            this.dgvCuenta.TabIndex = 8;
            // 
            // txtNombreSerie
            // 
            this.txtNombreSerie.Location = new System.Drawing.Point(7, 40);
            this.txtNombreSerie.Name = "txtNombreSerie";
            this.txtNombreSerie.Size = new System.Drawing.Size(489, 20);
            this.txtNombreSerie.TabIndex = 10;
            this.txtNombreSerie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombreSerie_KeyUp);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.Color.White;
            this.lblInformacion.Location = new System.Drawing.Point(832, 24);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(165, 39);
            this.lblInformacion.TabIndex = 13;
            this.lblInformacion.Text = "Si no se encontro una conexion\r\nestable no se preocupe SeeMore\r\ncontinuará reprod" +
    "uciendo videos.";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(273, 66);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(774, 431);
            this.dgvDatos.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.Controls.Add(this.button1);
            this.pnlContenedor.Controls.Add(this.textBox1);
            this.pnlContenedor.Controls.Add(this.textBox2);
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.label3);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.cboFiltros);
            this.pnlContenedor.Controls.Add(this.lblFiltros);
            this.pnlContenedor.Controls.Add(this.pnlRespaldo);
            this.pnlContenedor.Controls.Add(this.txtContraseña);
            this.pnlContenedor.Controls.Add(this.txtUsuario);
            this.pnlContenedor.Controls.Add(this.lblDatoInfo);
            this.pnlContenedor.Controls.Add(this.lblContraseña);
            this.pnlContenedor.Controls.Add(this.lblUsuario);
            this.pnlContenedor.Controls.Add(this.lblIniciarSesion);
            this.pnlContenedor.Controls.Add(this.txtSerie);
            this.pnlContenedor.Controls.Add(this.lblSerie);
            this.pnlContenedor.Controls.Add(this.txtNombreApartado);
            this.pnlContenedor.Controls.Add(this.lblNombreApar);
            this.pnlContenedor.Controls.Add(this.lblApartadoE);
            this.pnlContenedor.Controls.Add(this.txtBuscarApartado);
            this.pnlContenedor.Controls.Add(this.lblApartado);
            this.pnlContenedor.Controls.Add(this.txtCrearApartado);
            this.pnlContenedor.Controls.Add(this.lblCreacionApartado);
            this.pnlContenedor.Controls.Add(this.lblNombreSerie);
            this.pnlContenedor.Controls.Add(this.txtNombreSerie);
            this.pnlContenedor.Controls.Add(this.dgvDatos);
            this.pnlContenedor.Controls.Add(this.lblInformacion);
            this.pnlContenedor.Controls.Add(this.mspMenu);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1048, 498);
            this.pnlContenedor.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Comprobar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 49;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Compartir información de videos con otro usuario";
            // 
            // cboFiltros
            // 
            this.cboFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltros.FormattingEnabled = true;
            this.cboFiltros.Items.AddRange(new object[] {
            "mp4",
            "avi",
            "mkv",
            "wmv"});
            this.cboFiltros.Location = new System.Drawing.Point(726, 34);
            this.cboFiltros.Name = "cboFiltros";
            this.cboFiltros.Size = new System.Drawing.Size(67, 21);
            this.cboFiltros.TabIndex = 42;
            this.cboFiltros.Visible = false;
            this.cboFiltros.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.BackColor = System.Drawing.Color.White;
            this.lblFiltros.Location = new System.Drawing.Point(502, 34);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(218, 26);
            this.lblFiltros.TabIndex = 41;
            this.lblFiltros.Text = "¿No encontro videos?\r\npuedes intentar cambiar el filtro de busqueda";
            this.lblFiltros.Visible = false;
            // 
            // pnlRespaldo
            // 
            this.pnlRespaldo.BackColor = System.Drawing.Color.Transparent;
            this.pnlRespaldo.Location = new System.Drawing.Point(273, 66);
            this.pnlRespaldo.Name = "pnlRespaldo";
            this.pnlRespaldo.Size = new System.Drawing.Size(774, 429);
            this.pnlRespaldo.TabIndex = 40;
            this.pnlRespaldo.Visible = false;
            this.pnlRespaldo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlRespaldo_Scroll);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(16, 134);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(247, 20);
            this.txtContraseña.TabIndex = 38;
            this.txtContraseña.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(16, 95);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(247, 20);
            this.txtUsuario.TabIndex = 37;
            this.txtUsuario.Visible = false;
            // 
            // lblDatoInfo
            // 
            this.lblDatoInfo.AutoSize = true;
            this.lblDatoInfo.BackColor = System.Drawing.Color.White;
            this.lblDatoInfo.Location = new System.Drawing.Point(11, 159);
            this.lblDatoInfo.Name = "lblDatoInfo";
            this.lblDatoInfo.Size = new System.Drawing.Size(226, 26);
            this.lblDatoInfo.TabIndex = 36;
            this.lblDatoInfo.Text = "Para iniciar la sesión, solo seleccione un video\r\ny haga clic en Reproducir.";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(13, 118);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 35;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(13, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 34;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Visible = false;
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.White;
            this.lblIniciarSesion.Location = new System.Drawing.Point(13, 62);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(68, 13);
            this.lblIniciarSesion.TabIndex = 33;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            this.lblIniciarSesion.Visible = false;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(21, 475);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(180, 20);
            this.txtSerie.TabIndex = 31;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.BackColor = System.Drawing.Color.White;
            this.lblSerie.Location = new System.Drawing.Point(67, 459);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(95, 13);
            this.lblSerie.TabIndex = 30;
            this.lblSerie.Text = "Nombre de la serie";
            // 
            // txtNombreApartado
            // 
            this.txtNombreApartado.Location = new System.Drawing.Point(14, 435);
            this.txtNombreApartado.Name = "txtNombreApartado";
            this.txtNombreApartado.Size = new System.Drawing.Size(200, 20);
            this.txtNombreApartado.TabIndex = 29;
            // 
            // lblNombreApar
            // 
            this.lblNombreApar.AutoSize = true;
            this.lblNombreApar.BackColor = System.Drawing.Color.White;
            this.lblNombreApar.Location = new System.Drawing.Point(67, 419);
            this.lblNombreApar.Name = "lblNombreApar";
            this.lblNombreApar.Size = new System.Drawing.Size(106, 13);
            this.lblNombreApar.TabIndex = 28;
            this.lblNombreApar.Text = "Nombre del apartado";
            // 
            // lblApartadoE
            // 
            this.lblApartadoE.AutoSize = true;
            this.lblApartadoE.BackColor = System.Drawing.Color.White;
            this.lblApartadoE.Location = new System.Drawing.Point(32, 395);
            this.lblApartadoE.Name = "lblApartadoE";
            this.lblApartadoE.Size = new System.Drawing.Size(185, 13);
            this.lblApartadoE.TabIndex = 27;
            this.lblApartadoE.Text = "Mover videos a un apartado existente";
            // 
            // txtBuscarApartado
            // 
            this.txtBuscarApartado.Location = new System.Drawing.Point(13, 372);
            this.txtBuscarApartado.Name = "txtBuscarApartado";
            this.txtBuscarApartado.Size = new System.Drawing.Size(204, 20);
            this.txtBuscarApartado.TabIndex = 26;
            // 
            // lblApartado
            // 
            this.lblApartado.AutoSize = true;
            this.lblApartado.BackColor = System.Drawing.Color.White;
            this.lblApartado.Location = new System.Drawing.Point(21, 354);
            this.lblApartado.Name = "lblApartado";
            this.lblApartado.Size = new System.Drawing.Size(187, 13);
            this.lblApartado.TabIndex = 25;
            this.lblApartado.Text = "Buscar el nombre del apartado creado";
            // 
            // txtCrearApartado
            // 
            this.txtCrearApartado.Location = new System.Drawing.Point(14, 324);
            this.txtCrearApartado.Name = "txtCrearApartado";
            this.txtCrearApartado.Size = new System.Drawing.Size(201, 20);
            this.txtCrearApartado.TabIndex = 24;
            // 
            // lblCreacionApartado
            // 
            this.lblCreacionApartado.AutoSize = true;
            this.lblCreacionApartado.BackColor = System.Drawing.Color.White;
            this.lblCreacionApartado.Location = new System.Drawing.Point(40, 308);
            this.lblCreacionApartado.Name = "lblCreacionApartado";
            this.lblCreacionApartado.Size = new System.Drawing.Size(159, 13);
            this.lblCreacionApartado.TabIndex = 23;
            this.lblCreacionApartado.Text = "Crea un apartado para una serie";
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartadosToolStripMenuItem,
            this.reproducirToolStripMenuItem,
            this.regresarARaizToolStripMenuItem,
            this.regresarALaCarpetaAnteriorToolStripMenuItem,
            this.comoFuncionaToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(1048, 24);
            this.mspMenu.TabIndex = 39;
            this.mspMenu.Text = "menuStrip1";
            // 
            // apartadosToolStripMenuItem
            // 
            this.apartadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarEnElApartadoToolStripMenuItem,
            this.crearApartadoToolStripMenuItem,
            this.moverAlApartadoToolStripMenuItem});
            this.apartadosToolStripMenuItem.Name = "apartadosToolStripMenuItem";
            this.apartadosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.apartadosToolStripMenuItem.Text = "Apartados";
            // 
            // buscarEnElApartadoToolStripMenuItem
            // 
            this.buscarEnElApartadoToolStripMenuItem.Name = "buscarEnElApartadoToolStripMenuItem";
            this.buscarEnElApartadoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.buscarEnElApartadoToolStripMenuItem.Text = "Buscar en el Apartado";
            this.buscarEnElApartadoToolStripMenuItem.Click += new System.EventHandler(this.buscarEnElApartadoToolStripMenuItem_Click);
            // 
            // crearApartadoToolStripMenuItem
            // 
            this.crearApartadoToolStripMenuItem.Name = "crearApartadoToolStripMenuItem";
            this.crearApartadoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.crearApartadoToolStripMenuItem.Text = "Crear Apartado";
            this.crearApartadoToolStripMenuItem.Click += new System.EventHandler(this.crearApartadoToolStripMenuItem_Click);
            // 
            // moverAlApartadoToolStripMenuItem
            // 
            this.moverAlApartadoToolStripMenuItem.Name = "moverAlApartadoToolStripMenuItem";
            this.moverAlApartadoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.moverAlApartadoToolStripMenuItem.Text = "Mover al Apartado";
            this.moverAlApartadoToolStripMenuItem.Click += new System.EventHandler(this.moverAlApartadoToolStripMenuItem_Click);
            // 
            // reproducirToolStripMenuItem
            // 
            this.reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            this.reproducirToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.reproducirToolStripMenuItem.Text = "Reproducir";
            this.reproducirToolStripMenuItem.Click += new System.EventHandler(this.reproducirToolStripMenuItem_Click);
            // 
            // regresarARaizToolStripMenuItem
            // 
            this.regresarARaizToolStripMenuItem.Name = "regresarARaizToolStripMenuItem";
            this.regresarARaizToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.regresarARaizToolStripMenuItem.Text = "Regresar a raiz";
            this.regresarARaizToolStripMenuItem.Visible = false;
            this.regresarARaizToolStripMenuItem.Click += new System.EventHandler(this.regresarARaizToolStripMenuItem_Click);
            // 
            // comoFuncionaToolStripMenuItem
            // 
            this.comoFuncionaToolStripMenuItem.Name = "comoFuncionaToolStripMenuItem";
            this.comoFuncionaToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.comoFuncionaToolStripMenuItem.Text = "¿Como Funciona?";
            this.comoFuncionaToolStripMenuItem.Click += new System.EventHandler(this.comoFuncionaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pnlContenedor);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 497);
            this.panel1.TabIndex = 25;
            // 
            // tmrRefresco
            // 
            this.tmrRefresco.Interval = 500;
            this.tmrRefresco.Tick += new System.EventHandler(this.tmrRefresco_Tick);
            // 
            // regresarALaCarpetaAnteriorToolStripMenuItem
            // 
            this.regresarALaCarpetaAnteriorToolStripMenuItem.Name = "regresarALaCarpetaAnteriorToolStripMenuItem";
            this.regresarALaCarpetaAnteriorToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.regresarALaCarpetaAnteriorToolStripMenuItem.Text = "Regresar a la carpeta anterior";
            this.regresarALaCarpetaAnteriorToolStripMenuItem.Visible = false;
            this.regresarALaCarpetaAnteriorToolStripMenuItem.Click += new System.EventHandler(this.regresarALaCarpetaAnteriorToolStripMenuItem_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCuenta);
            this.Controls.Add(this.lblSinUso);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreSerie;
        private System.Windows.Forms.Label lblSinUso;
        private System.Windows.Forms.DataGridView dgvCuenta;
        private System.Windows.Forms.TextBox txtNombreSerie;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtNombreApartado;
        private System.Windows.Forms.Label lblNombreApar;
        private System.Windows.Forms.Label lblApartadoE;
        private System.Windows.Forms.TextBox txtBuscarApartado;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.TextBox txtCrearApartado;
        private System.Windows.Forms.Label lblCreacionApartado;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblDatoInfo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem apartadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEnElApartadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearApartadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverAlApartadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducirToolStripMenuItem;
        private System.Windows.Forms.Panel pnlRespaldo;
        private System.Windows.Forms.ToolStripMenuItem regresarARaizToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboFiltros;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem comoFuncionaToolStripMenuItem;
        private System.Windows.Forms.Timer tmrRefresco;
        private System.Windows.Forms.ToolStripMenuItem regresarALaCarpetaAnteriorToolStripMenuItem;
    }
}