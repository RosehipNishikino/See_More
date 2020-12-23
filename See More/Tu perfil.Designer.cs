namespace See_More
{
    partial class Tu_perfil
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.rtxHistorialUsuario = new System.Windows.Forms.RichTextBox();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAnimesVistosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarImagenDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.lblInfoImagen = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.lblComprobacion = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(3, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 0;
            // 
            // rtxHistorialUsuario
            // 
            this.rtxHistorialUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxHistorialUsuario.Location = new System.Drawing.Point(6, 22);
            this.rtxHistorialUsuario.Name = "rtxHistorialUsuario";
            this.rtxHistorialUsuario.Size = new System.Drawing.Size(381, 293);
            this.rtxHistorialUsuario.TabIndex = 1;
            this.rtxHistorialUsuario.Text = "";
            this.rtxHistorialUsuario.TextChanged += new System.EventHandler(this.rtxHistorialUsuario_TextChanged);
            // 
            // mspMenu
            // 
            this.mspMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mspMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.iniciarSesiónToolStripMenuItem,
            this.mostrarAnimesVistosToolStripMenuItem,
            this.agregarImagenDeFondoToolStripMenuItem,
            this.editarPerfilToolStripMenuItem,
            this.actualizarPerfilToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 318);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(763, 24);
            this.mspMenu.TabIndex = 2;
            this.mspMenu.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.guardarToolStripMenuItem.Text = "Guardar &Historial";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // mostrarAnimesVistosToolStripMenuItem
            // 
            this.mostrarAnimesVistosToolStripMenuItem.Enabled = false;
            this.mostrarAnimesVistosToolStripMenuItem.Name = "mostrarAnimesVistosToolStripMenuItem";
            this.mostrarAnimesVistosToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.mostrarAnimesVistosToolStripMenuItem.Text = "Mostrar Animes vistos";
            this.mostrarAnimesVistosToolStripMenuItem.Click += new System.EventHandler(this.mostrarAnimesVistosToolStripMenuItem_Click);
            // 
            // agregarImagenDeFondoToolStripMenuItem
            // 
            this.agregarImagenDeFondoToolStripMenuItem.Enabled = false;
            this.agregarImagenDeFondoToolStripMenuItem.Name = "agregarImagenDeFondoToolStripMenuItem";
            this.agregarImagenDeFondoToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.agregarImagenDeFondoToolStripMenuItem.Text = "Agregar Imagen de fondo";
            this.agregarImagenDeFondoToolStripMenuItem.ToolTipText = "Se establecera una imagen para el perfil actual";
            this.agregarImagenDeFondoToolStripMenuItem.Click += new System.EventHandler(this.agregarImagenDeFondoToolStripMenuItem_Click);
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Enabled = false;
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.editarPerfilToolStripMenuItem.Text = "Editar Perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // actualizarPerfilToolStripMenuItem
            // 
            this.actualizarPerfilToolStripMenuItem.Enabled = false;
            this.actualizarPerfilToolStripMenuItem.Name = "actualizarPerfilToolStripMenuItem";
            this.actualizarPerfilToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.actualizarPerfilToolStripMenuItem.Text = "Actualizar perfil";
            this.actualizarPerfilToolStripMenuItem.Click += new System.EventHandler(this.actualizarPerfilToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Enabled = false;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(529, 289);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(242, 26);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Para actualizar tu historial personal borra esa linea\r\ny guarda con Alt + H o Cli" +
    "c en Guardar Historial";
            this.lblInfo.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSeries
            // 
            this.txtSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeries.Location = new System.Drawing.Point(440, 266);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(326, 20);
            this.txtSeries.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtSeries, "Recuerda hacer \"ENTER\" despues de escribir el nombre");
            this.txtSeries.Visible = false;
            this.txtSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.txtSeries.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyUp);
            // 
            // picUsuario
            // 
            this.picUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUsuario.Location = new System.Drawing.Point(671, -1);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(100, 94);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 4;
            this.picUsuario.TabStop = false;
            this.picUsuario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblInfoImagen
            // 
            this.lblInfoImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoImagen.AutoSize = true;
            this.lblInfoImagen.Location = new System.Drawing.Point(672, 96);
            this.lblInfoImagen.Name = "lblInfoImagen";
            this.lblInfoImagen.Size = new System.Drawing.Size(90, 26);
            this.lblInfoImagen.TabIndex = 5;
            this.lblInfoImagen.Text = "Haz clic sobre la\r\nimagen a cambiar";
            this.lblInfoImagen.Visible = false;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(435, 48);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(98, 13);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Nueva contraseña:";
            this.lblContraseña.Visible = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Location = new System.Drawing.Point(435, 64);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(208, 20);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.Visible = false;
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(435, 103);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(208, 20);
            this.txtConfirmarContraseña.TabIndex = 10;
            this.txtConfirmarContraseña.Visible = false;
            this.txtConfirmarContraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(435, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblNombreUsuario.TabIndex = 11;
            this.lblNombreUsuario.Text = "Usuario:";
            this.lblNombreUsuario.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(435, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 20);
            this.txtUsuario.TabIndex = 12;
            this.txtUsuario.Visible = false;
            // 
            // lblSeries
            // 
            this.lblSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(435, 250);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(154, 13);
            this.lblSeries.TabIndex = 13;
            this.lblSeries.Text = "Escribe las series que has visto";
            this.lblSeries.Visible = false;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(435, 87);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(143, 13);
            this.lblConfirmarContraseña.TabIndex = 15;
            this.lblConfirmarContraseña.Text = "Confirmar nueva contraseña:";
            this.lblConfirmarContraseña.Visible = false;
            // 
            // lblComprobacion
            // 
            this.lblComprobacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComprobacion.AutoSize = true;
            this.lblComprobacion.Location = new System.Drawing.Point(440, 126);
            this.lblComprobacion.Name = "lblComprobacion";
            this.lblComprobacion.Size = new System.Drawing.Size(0, 13);
            this.lblComprobacion.TabIndex = 16;
            this.lblComprobacion.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Tu_perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 342);
            this.Controls.Add(this.lblComprobacion);
            this.Controls.Add(this.lblConfirmarContraseña);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblInfoImagen);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rtxHistorialUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Tu_perfil";
            this.Load += new System.EventHandler(this.Tu_perfil_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.RichTextBox rtxHistorialUsuario;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarImagenDeFondoToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.Label lblInfoImagen;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ToolStripMenuItem actualizarPerfilToolStripMenuItem;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.ToolStripMenuItem mostrarAnimesVistosToolStripMenuItem;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.Label lblComprobacion;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}