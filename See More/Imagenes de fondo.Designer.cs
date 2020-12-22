namespace See_more
{
    partial class Imagenes_de_fondo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previsualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previsualizarImagenAGuardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.previsualizarImagenDeHistorialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarPrevisualizaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.rtxHistorialImagen = new System.Windows.Forms.RichTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblFondo = new System.Windows.Forms.Label();
            this.lblCasillas = new System.Windows.Forms.Label();
            this.chkReproductor = new System.Windows.Forms.CheckBox();
            this.chkActualizar = new System.Windows.Forms.CheckBox();
            this.chkBuscar = new System.Windows.Forms.CheckBox();
            this.chkBusqueda = new System.Windows.Forms.CheckBox();
            this.chkCrearCuenta = new System.Windows.Forms.CheckBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.chkHistorial = new System.Windows.Forms.CheckBox();
            this.chkNuevo = new System.Windows.Forms.CheckBox();
            this.lblInfoFondo = new System.Windows.Forms.Label();
            this.picComprobacion = new System.Windows.Forms.PictureBox();
            this.mspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComprobacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.previsualizacionesToolStripMenuItem,
            this.guardarHistorialToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(968, 24);
            this.mspMenu.TabIndex = 1;
            this.mspMenu.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.guardarToolStripMenuItem.Text = "Establecer";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // previsualizacionesToolStripMenuItem
            // 
            this.previsualizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previsualizarImagenAGuardarToolStripMenuItem1,
            this.previsualizarImagenDeHistorialToolStripMenuItem1,
            this.cerrarPrevisualizaciónToolStripMenuItem1});
            this.previsualizacionesToolStripMenuItem.Name = "previsualizacionesToolStripMenuItem";
            this.previsualizacionesToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.previsualizacionesToolStripMenuItem.Text = "Previsualizaciones";
            // 
            // previsualizarImagenAGuardarToolStripMenuItem1
            // 
            this.previsualizarImagenAGuardarToolStripMenuItem1.Name = "previsualizarImagenAGuardarToolStripMenuItem1";
            this.previsualizarImagenAGuardarToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.previsualizarImagenAGuardarToolStripMenuItem1.Text = "Previsualizar imagen a guardar";
            this.previsualizarImagenAGuardarToolStripMenuItem1.Click += new System.EventHandler(this.previsualizarImagenAGuardarToolStripMenuItem1_Click);
            // 
            // previsualizarImagenDeHistorialToolStripMenuItem1
            // 
            this.previsualizarImagenDeHistorialToolStripMenuItem1.Name = "previsualizarImagenDeHistorialToolStripMenuItem1";
            this.previsualizarImagenDeHistorialToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.previsualizarImagenDeHistorialToolStripMenuItem1.Text = "Previsualizar imagen de historial";
            this.previsualizarImagenDeHistorialToolStripMenuItem1.Click += new System.EventHandler(this.previsualizarImagenDeHistorialToolStripMenuItem1_Click);
            // 
            // cerrarPrevisualizaciónToolStripMenuItem1
            // 
            this.cerrarPrevisualizaciónToolStripMenuItem1.Name = "cerrarPrevisualizaciónToolStripMenuItem1";
            this.cerrarPrevisualizaciónToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.cerrarPrevisualizaciónToolStripMenuItem1.Text = "Cerrar previsualización";
            this.cerrarPrevisualizaciónToolStripMenuItem1.Click += new System.EventHandler(this.cerrarPrevisualizaciónToolStripMenuItem1_Click);
            // 
            // guardarHistorialToolStripMenuItem
            // 
            this.guardarHistorialToolStripMenuItem.Name = "guardarHistorialToolStripMenuItem";
            this.guardarHistorialToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.guardarHistorialToolStripMenuItem.Text = "Guardar Historial";
            this.guardarHistorialToolStripMenuItem.Click += new System.EventHandler(this.guardarHistorialToolStripMenuItem_Click);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(12, 63);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(33, 13);
            this.lblRuta.TabIndex = 2;
            this.lblRuta.Text = "Ruta:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(545, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(65, 63);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(545, 20);
            this.txtRuta.TabIndex = 4;
            // 
            // rtxHistorialImagen
            // 
            this.rtxHistorialImagen.Location = new System.Drawing.Point(12, 89);
            this.rtxHistorialImagen.Name = "rtxHistorialImagen";
            this.rtxHistorialImagen.Size = new System.Drawing.Size(598, 175);
            this.rtxHistorialImagen.TabIndex = 6;
            this.rtxHistorialImagen.Text = "";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 267);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(389, 13);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Este es tu historial de imagenes, para borrar un registro borra esa linea y actua" +
    "liza";
            // 
            // lblFondo
            // 
            this.lblFondo.AutoSize = true;
            this.lblFondo.Location = new System.Drawing.Point(625, 31);
            this.lblFondo.Name = "lblFondo";
            this.lblFondo.Size = new System.Drawing.Size(139, 13);
            this.lblFondo.TabIndex = 10;
            this.lblFondo.Text = "Controla donde ver tu fondo";
            // 
            // lblCasillas
            // 
            this.lblCasillas.AutoSize = true;
            this.lblCasillas.Location = new System.Drawing.Point(625, 46);
            this.lblCasillas.Name = "lblCasillas";
            this.lblCasillas.Size = new System.Drawing.Size(220, 13);
            this.lblCasillas.TabIndex = 11;
            this.lblCasillas.Text = "Marca las casillas donde quieres ver tu fondo";
            // 
            // chkReproductor
            // 
            this.chkReproductor.AutoSize = true;
            this.chkReproductor.Location = new System.Drawing.Point(628, 66);
            this.chkReproductor.Name = "chkReproductor";
            this.chkReproductor.Size = new System.Drawing.Size(85, 17);
            this.chkReproductor.TabIndex = 12;
            this.chkReproductor.Text = "Reproductor";
            this.chkReproductor.UseVisualStyleBackColor = true;
            // 
            // chkActualizar
            // 
            this.chkActualizar.AutoSize = true;
            this.chkActualizar.Location = new System.Drawing.Point(628, 89);
            this.chkActualizar.Name = "chkActualizar";
            this.chkActualizar.Size = new System.Drawing.Size(72, 17);
            this.chkActualizar.TabIndex = 13;
            this.chkActualizar.Text = "Actualizar";
            this.chkActualizar.UseVisualStyleBackColor = true;
            // 
            // chkBuscar
            // 
            this.chkBuscar.AutoSize = true;
            this.chkBuscar.Location = new System.Drawing.Point(628, 114);
            this.chkBuscar.Name = "chkBuscar";
            this.chkBuscar.Size = new System.Drawing.Size(59, 17);
            this.chkBuscar.TabIndex = 14;
            this.chkBuscar.Text = "Buscar";
            this.chkBuscar.UseVisualStyleBackColor = true;
            // 
            // chkBusqueda
            // 
            this.chkBusqueda.AutoSize = true;
            this.chkBusqueda.Location = new System.Drawing.Point(628, 137);
            this.chkBusqueda.Name = "chkBusqueda";
            this.chkBusqueda.Size = new System.Drawing.Size(74, 17);
            this.chkBusqueda.TabIndex = 15;
            this.chkBusqueda.Text = "Busqueda";
            this.chkBusqueda.UseVisualStyleBackColor = true;
            // 
            // chkCrearCuenta
            // 
            this.chkCrearCuenta.AutoSize = true;
            this.chkCrearCuenta.Location = new System.Drawing.Point(743, 65);
            this.chkCrearCuenta.Name = "chkCrearCuenta";
            this.chkCrearCuenta.Size = new System.Drawing.Size(88, 17);
            this.chkCrearCuenta.TabIndex = 16;
            this.chkCrearCuenta.Text = "Crear Cuenta";
            this.chkCrearCuenta.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(743, 89);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkEliminar.TabIndex = 17;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkHistorial
            // 
            this.chkHistorial.AutoSize = true;
            this.chkHistorial.Location = new System.Drawing.Point(742, 114);
            this.chkHistorial.Name = "chkHistorial";
            this.chkHistorial.Size = new System.Drawing.Size(63, 17);
            this.chkHistorial.TabIndex = 18;
            this.chkHistorial.Text = "Historial";
            this.chkHistorial.UseVisualStyleBackColor = true;
            // 
            // chkNuevo
            // 
            this.chkNuevo.AutoSize = true;
            this.chkNuevo.Location = new System.Drawing.Point(742, 137);
            this.chkNuevo.Name = "chkNuevo";
            this.chkNuevo.Size = new System.Drawing.Size(58, 17);
            this.chkNuevo.TabIndex = 19;
            this.chkNuevo.Text = "Nuevo";
            this.chkNuevo.UseVisualStyleBackColor = true;
            // 
            // lblInfoFondo
            // 
            this.lblInfoFondo.AutoSize = true;
            this.lblInfoFondo.Location = new System.Drawing.Point(625, 157);
            this.lblInfoFondo.Name = "lblInfoFondo";
            this.lblInfoFondo.Size = new System.Drawing.Size(302, 26);
            this.lblInfoFondo.TabIndex = 20;
            this.lblInfoFondo.Text = "Esta ventana no cuenta con esta opción, puesto que sirve de \r\nverificación al usu" +
    "ario.";
            // 
            // picComprobacion
            // 
            this.picComprobacion.Location = new System.Drawing.Point(12, 89);
            this.picComprobacion.Name = "picComprobacion";
            this.picComprobacion.Size = new System.Drawing.Size(598, 175);
            this.picComprobacion.TabIndex = 21;
            this.picComprobacion.TabStop = false;
            this.picComprobacion.Visible = false;
            // 
            // Imagenes_de_fondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 289);
            this.Controls.Add(this.picComprobacion);
            this.Controls.Add(this.lblInfoFondo);
            this.Controls.Add(this.chkNuevo);
            this.Controls.Add(this.chkHistorial);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.chkCrearCuenta);
            this.Controls.Add(this.chkBusqueda);
            this.Controls.Add(this.chkBuscar);
            this.Controls.Add(this.chkActualizar);
            this.Controls.Add(this.chkReproductor);
            this.Controls.Add(this.lblCasillas);
            this.Controls.Add(this.lblFondo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rtxHistorialImagen);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Imagenes_de_fondo";
            this.Text = "Personalización";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Imagenes_de_fondo_FormClosing);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComprobacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.RichTextBox rtxHistorialImagen;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblFondo;
        private System.Windows.Forms.Label lblCasillas;
        private System.Windows.Forms.CheckBox chkReproductor;
        private System.Windows.Forms.CheckBox chkActualizar;
        private System.Windows.Forms.CheckBox chkBuscar;
        private System.Windows.Forms.CheckBox chkBusqueda;
        private System.Windows.Forms.CheckBox chkCrearCuenta;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.CheckBox chkHistorial;
        private System.Windows.Forms.CheckBox chkNuevo;
        private System.Windows.Forms.Label lblInfoFondo;
        private System.Windows.Forms.PictureBox picComprobacion;
        private System.Windows.Forms.ToolStripMenuItem previsualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previsualizarImagenAGuardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem previsualizarImagenDeHistorialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarPrevisualizaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarHistorialToolStripMenuItem;
    }
}