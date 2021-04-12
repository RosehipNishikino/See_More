namespace See_More
{
    partial class Reproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.wmpCentral = new AxWMPLib.AxWindowsMediaPlayer();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarLaSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comoFuncionaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblSinUso = new System.Windows.Forms.Label();
            this.lblSinUso2 = new System.Windows.Forms.Label();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDuracionInicial = new System.Windows.Forms.Label();
            this.lblDuracionFinal = new System.Windows.Forms.Label();
            this.lblAutoPausa = new System.Windows.Forms.Label();
            this.lblAutoRepetir = new System.Windows.Forms.Label();
            this.tmrProceso = new System.Windows.Forms.Timer(this.components);
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.tmrProgreso = new System.Windows.Forms.Timer(this.components);
            this.tmrEstadoActual = new System.Windows.Forms.Timer(this.components);
            this.tmrBateria = new System.Windows.Forms.Timer(this.components);
            this.tmrGuardarAuto = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpCentral)).BeginInit();
            this.mspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpCentral
            // 
            this.wmpCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpCentral.Enabled = true;
            this.wmpCentral.Location = new System.Drawing.Point(0, 22);
            this.wmpCentral.Name = "wmpCentral";
            this.wmpCentral.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpCentral.OcxState")));
            this.wmpCentral.Size = new System.Drawing.Size(1308, 419);
            this.wmpCentral.TabIndex = 0;
            this.wmpCentral.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpCentral_PlayStateChange);
            this.wmpCentral.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.axWindowsMediaPlayer1_ClickEvent);
            this.wmpCentral.KeyPressEvent += new AxWMPLib._WMPOCXEvents_KeyPressEventHandler(this.axWindowsMediaPlayer1_KeyPressEvent);
            this.wmpCentral.KeyUpEvent += new AxWMPLib._WMPOCXEvents_KeyUpEventHandler(this.axWindowsMediaPlayer1_KeyUpEvent);
            this.wmpCentral.Enter += new System.EventHandler(this.wmpCentral_Enter);
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.iniciarSesiónToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.comoFuncionaToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(1308, 24);
            this.mspMenu.TabIndex = 8;
            this.mspMenu.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.buscarToolStripMenuItem1,
            this.actualizarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.personalizaciónToolStripMenuItem,
            this.iniciarSesiónToolStripMenuItem1});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.nuevoToolStripMenuItem.Text = "See More";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // actualizarToolStripMenuItem1
            // 
            this.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1";
            this.actualizarToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.actualizarToolStripMenuItem1.Text = "Actualizar";
            this.actualizarToolStripMenuItem1.Click += new System.EventHandler(this.actualizarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem3.Text = "|||||||||";
            this.toolStripMenuItem3.Visible = false;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // personalizaciónToolStripMenuItem
            // 
            this.personalizaciónToolStripMenuItem.Name = "personalizaciónToolStripMenuItem";
            this.personalizaciónToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.personalizaciónToolStripMenuItem.Text = "Personalización";
            this.personalizaciónToolStripMenuItem.Visible = false;
            this.personalizaciónToolStripMenuItem.Click += new System.EventHandler(this.personalizaciónToolStripMenuItem_Click);
            // 
            // iniciarSesiónToolStripMenuItem1
            // 
            this.iniciarSesiónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem1,
            this.cerrarSesiónToolStripMenuItem});
            this.iniciarSesiónToolStripMenuItem1.Name = "iniciarSesiónToolStripMenuItem1";
            this.iniciarSesiónToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.iniciarSesiónToolStripMenuItem1.Text = "Iniciar Sesión";
            this.iniciarSesiónToolStripMenuItem1.Visible = false;
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.menuToolStripMenuItem1.Text = "Menu";
            this.menuToolStripMenuItem1.Click += new System.EventHandler(this.menuToolStripMenuItem1_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaToolStripMenuItem1});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Cuentas";
            // 
            // crearCuentaToolStripMenuItem1
            // 
            this.crearCuentaToolStripMenuItem1.Name = "crearCuentaToolStripMenuItem1";
            this.crearCuentaToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.crearCuentaToolStripMenuItem1.Text = "Crear Cuenta";
            this.crearCuentaToolStripMenuItem1.Click += new System.EventHandler(this.crearCuentaToolStripMenuItem1_Click);
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.cerrarLaSesiónToolStripMenuItem});
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // cerrarLaSesiónToolStripMenuItem
            // 
            this.cerrarLaSesiónToolStripMenuItem.Name = "cerrarLaSesiónToolStripMenuItem";
            this.cerrarLaSesiónToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cerrarLaSesiónToolStripMenuItem.Text = "Cerrar la sesión";
            this.cerrarLaSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarLaSesiónToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cerrarToolStripMenuItem.Text = "Personalización";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "|||||||||";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // comoFuncionaToolStripMenuItem
            // 
            this.comoFuncionaToolStripMenuItem.Name = "comoFuncionaToolStripMenuItem";
            this.comoFuncionaToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.comoFuncionaToolStripMenuItem.Text = "¿Como funciona?";
            this.comoFuncionaToolStripMenuItem.Click += new System.EventHandler(this.comoFuncionaToolStripMenuItem_Click);
            // 
            // lblVolumen
            // 
            this.lblVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(1196, 6);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(0, 13);
            this.lblVolumen.TabIndex = 10;
            // 
            // lblSinUso
            // 
            this.lblSinUso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSinUso.AutoSize = true;
            this.lblSinUso.Location = new System.Drawing.Point(963, 6);
            this.lblSinUso.Name = "lblSinUso";
            this.lblSinUso.Size = new System.Drawing.Size(0, 13);
            this.lblSinUso.TabIndex = 11;
            // 
            // lblSinUso2
            // 
            this.lblSinUso2.AutoSize = true;
            this.lblSinUso2.Location = new System.Drawing.Point(554, 388);
            this.lblSinUso2.Name = "lblSinUso2";
            this.lblSinUso2.Size = new System.Drawing.Size(0, 13);
            this.lblSinUso2.TabIndex = 14;
            this.lblSinUso2.Visible = false;
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "openFileDialog1";
            // 
            // picUsuario
            // 
            this.picUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUsuario.Location = new System.Drawing.Point(1266, 0);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(42, 41);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 7;
            this.picUsuario.TabStop = false;
            this.picUsuario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDuracionInicial
            // 
            this.lblDuracionInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDuracionInicial.AutoSize = true;
            this.lblDuracionInicial.Location = new System.Drawing.Point(2, 426);
            this.lblDuracionInicial.Name = "lblDuracionInicial";
            this.lblDuracionInicial.Size = new System.Drawing.Size(0, 13);
            this.lblDuracionInicial.TabIndex = 22;
            // 
            // lblDuracionFinal
            // 
            this.lblDuracionFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuracionFinal.AutoSize = true;
            this.lblDuracionFinal.Location = new System.Drawing.Point(1263, 428);
            this.lblDuracionFinal.Name = "lblDuracionFinal";
            this.lblDuracionFinal.Size = new System.Drawing.Size(0, 13);
            this.lblDuracionFinal.TabIndex = 23;
            // 
            // lblAutoPausa
            // 
            this.lblAutoPausa.AutoSize = true;
            this.lblAutoPausa.Location = new System.Drawing.Point(554, 6);
            this.lblAutoPausa.Name = "lblAutoPausa";
            this.lblAutoPausa.Size = new System.Drawing.Size(0, 13);
            this.lblAutoPausa.TabIndex = 25;
            // 
            // lblAutoRepetir
            // 
            this.lblAutoRepetir.AutoSize = true;
            this.lblAutoRepetir.Location = new System.Drawing.Point(780, 6);
            this.lblAutoRepetir.Name = "lblAutoRepetir";
            this.lblAutoRepetir.Size = new System.Drawing.Size(0, 13);
            this.lblAutoRepetir.TabIndex = 26;
            // 
            // tmrProceso
            // 
            this.tmrProceso.Interval = 5000;
            this.tmrProceso.Tick += new System.EventHandler(this.tmrProceso_Tick);
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(1052, 7);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(0, 13);
            this.lblInicio.TabIndex = 27;
            // 
            // lblFinal
            // 
            this.lblFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(1122, 9);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 13);
            this.lblFinal.TabIndex = 28;
            // 
            // tmrProgreso
            // 
            this.tmrProgreso.Tick += new System.EventHandler(this.tmrProgreso_Tick);
            // 
            // tmrEstadoActual
            // 
            this.tmrEstadoActual.Interval = 1000;
            this.tmrEstadoActual.Tick += new System.EventHandler(this.tmrEstadoActual_Tick);
            // 
            // tmrBateria
            // 
            this.tmrBateria.Interval = 1500;
            this.tmrBateria.Tick += new System.EventHandler(this.tmrBateria_Tick);
            // 
            // tmrGuardarAuto
            // 
            this.tmrGuardarAuto.Interval = 5000;
            this.tmrGuardarAuto.Tick += new System.EventHandler(this.tmrGuardarAuto_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Visible = true;
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 441);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblAutoRepetir);
            this.Controls.Add(this.lblAutoPausa);
            this.Controls.Add(this.lblDuracionFinal);
            this.Controls.Add(this.lblDuracionInicial);
            this.Controls.Add(this.lblSinUso2);
            this.Controls.Add(this.lblSinUso);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.wmpCentral);
            this.Controls.Add(this.mspMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Reproductor";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.wmpCentral)).EndInit();
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpCentral;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblSinUso;
        private System.Windows.Forms.Label lblSinUso2;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDuracionInicial;
        private System.Windows.Forms.Label lblDuracionFinal;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comoFuncionaToolStripMenuItem;
        private System.Windows.Forms.Label lblAutoPausa;
        private System.Windows.Forms.Label lblAutoRepetir;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarLaSesiónToolStripMenuItem;
        private System.Windows.Forms.Timer tmrProceso;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Timer tmrProgreso;
        private System.Windows.Forms.Timer tmrEstadoActual;
        private System.Windows.Forms.Timer tmrBateria;
        private System.Windows.Forms.Timer tmrGuardarAuto;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem personalizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}

