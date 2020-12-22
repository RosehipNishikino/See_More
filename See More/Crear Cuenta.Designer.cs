namespace See_more
{
    partial class Crear_Cuenta
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRepetirContraseña = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.lblComprobacion = new System.Windows.Forms.Label();
            this.ofdImagen = new System.Windows.Forms.OpenFileDialog();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.txtEliminarUser = new System.Windows.Forms.TextBox();
            this.lblEliminarUsuario = new System.Windows.Forms.Label();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.crearUsuarioNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUnUsuarioCreadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarElUsuarioCreadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxSinUso = new System.Windows.Forms.RichTextBox();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.rdoHombre = new System.Windows.Forms.RadioButton();
            this.rdoMujer = new System.Windows.Forms.RadioButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rdoOtro = new System.Windows.Forms.RadioButton();
            this.txtOtro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(12, 61);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblRepetirContraseña
            // 
            this.lblRepetirContraseña.AutoSize = true;
            this.lblRepetirContraseña.Location = new System.Drawing.Point(12, 87);
            this.lblRepetirContraseña.Name = "lblRepetirContraseña";
            this.lblRepetirContraseña.Size = new System.Drawing.Size(100, 13);
            this.lblRepetirContraseña.TabIndex = 2;
            this.lblRepetirContraseña.Text = "Repetir contraseña:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 102);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(64, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(263, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(73, 58);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(254, 20);
            this.txtContraseña.TabIndex = 8;
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.Location = new System.Drawing.Point(118, 82);
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.PasswordChar = '*';
            this.txtRepetirContraseña.Size = new System.Drawing.Size(209, 20);
            this.txtRepetirContraseña.TabIndex = 9;
            this.txtRepetirContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.txtRepetirContraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // lblComprobacion
            // 
            this.lblComprobacion.AutoSize = true;
            this.lblComprobacion.Location = new System.Drawing.Point(159, 103);
            this.lblComprobacion.Name = "lblComprobacion";
            this.lblComprobacion.Size = new System.Drawing.Size(0, 13);
            this.lblComprobacion.TabIndex = 10;
            // 
            // ofdImagen
            // 
            this.ofdImagen.FileName = "openFileDialog1";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Location = new System.Drawing.Point(12, 161);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(140, 13);
            this.lblEliminar.TabIndex = 15;
            this.lblEliminar.Text = "Elimina tus usuarios creados";
            // 
            // txtEliminarUser
            // 
            this.txtEliminarUser.Enabled = false;
            this.txtEliminarUser.Location = new System.Drawing.Point(64, 177);
            this.txtEliminarUser.Name = "txtEliminarUser";
            this.txtEliminarUser.Size = new System.Drawing.Size(224, 20);
            this.txtEliminarUser.TabIndex = 16;
            // 
            // lblEliminarUsuario
            // 
            this.lblEliminarUsuario.AutoSize = true;
            this.lblEliminarUsuario.Location = new System.Drawing.Point(12, 184);
            this.lblEliminarUsuario.Name = "lblEliminarUsuario";
            this.lblEliminarUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblEliminarUsuario.TabIndex = 17;
            this.lblEliminarUsuario.Text = "Usuario:";
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picImagen.Location = new System.Drawing.Point(333, 27);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(198, 137);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 6;
            this.picImagen.TabStop = false;
            this.picImagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioNuevoToolStripMenuItem,
            this.buscarUnUsuarioCreadoToolStripMenuItem,
            this.eliminarElUsuarioCreadoToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(531, 24);
            this.mspMenu.TabIndex = 20;
            this.mspMenu.Text = "menuStrip1";
            // 
            // crearUsuarioNuevoToolStripMenuItem
            // 
            this.crearUsuarioNuevoToolStripMenuItem.Name = "crearUsuarioNuevoToolStripMenuItem";
            this.crearUsuarioNuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.crearUsuarioNuevoToolStripMenuItem.Text = "Crear usuario nuevo";
            this.crearUsuarioNuevoToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioNuevoToolStripMenuItem_Click);
            // 
            // buscarUnUsuarioCreadoToolStripMenuItem
            // 
            this.buscarUnUsuarioCreadoToolStripMenuItem.Name = "buscarUnUsuarioCreadoToolStripMenuItem";
            this.buscarUnUsuarioCreadoToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.buscarUnUsuarioCreadoToolStripMenuItem.Text = "Buscar un usuario creado";
            this.buscarUnUsuarioCreadoToolStripMenuItem.Click += new System.EventHandler(this.buscarUnUsuarioCreadoToolStripMenuItem_Click);
            // 
            // eliminarElUsuarioCreadoToolStripMenuItem
            // 
            this.eliminarElUsuarioCreadoToolStripMenuItem.Name = "eliminarElUsuarioCreadoToolStripMenuItem";
            this.eliminarElUsuarioCreadoToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.eliminarElUsuarioCreadoToolStripMenuItem.Text = "Eliminar el usuario creado";
            this.eliminarElUsuarioCreadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarElUsuarioCreadoToolStripMenuItem_Click);
            // 
            // rtxSinUso
            // 
            this.rtxSinUso.Location = new System.Drawing.Point(354, 167);
            this.rtxSinUso.Name = "rtxSinUso";
            this.rtxSinUso.Size = new System.Drawing.Size(100, 34);
            this.rtxSinUso.TabIndex = 21;
            this.rtxSinUso.Text = "";
            this.rtxSinUso.Visible = false;
            // 
            // rdoHombre
            // 
            this.rdoHombre.AutoSize = true;
            this.rdoHombre.Location = new System.Drawing.Point(12, 118);
            this.rdoHombre.Name = "rdoHombre";
            this.rdoHombre.Size = new System.Drawing.Size(62, 17);
            this.rdoHombre.TabIndex = 22;
            this.rdoHombre.TabStop = true;
            this.rdoHombre.Text = "Hombre";
            this.rdoHombre.UseVisualStyleBackColor = true;
            this.rdoHombre.CheckedChanged += new System.EventHandler(this.rdoHombre_CheckedChanged);
            // 
            // rdoMujer
            // 
            this.rdoMujer.AutoSize = true;
            this.rdoMujer.Location = new System.Drawing.Point(89, 118);
            this.rdoMujer.Name = "rdoMujer";
            this.rdoMujer.Size = new System.Drawing.Size(51, 17);
            this.rdoMujer.TabIndex = 23;
            this.rdoMujer.TabStop = true;
            this.rdoMujer.Text = "Mujer";
            this.rdoMujer.UseVisualStyleBackColor = true;
            this.rdoMujer.CheckedChanged += new System.EventHandler(this.rdoMujer_CheckedChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(351, 167);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(158, 26);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Para buscar una imagen\r\nhaz clic sobre el recuadro negro";
            // 
            // rdoOtro
            // 
            this.rdoOtro.AutoSize = true;
            this.rdoOtro.Location = new System.Drawing.Point(146, 119);
            this.rdoOtro.Name = "rdoOtro";
            this.rdoOtro.Size = new System.Drawing.Size(109, 17);
            this.rdoOtro.TabIndex = 25;
            this.rdoOtro.TabStop = true;
            this.rdoOtro.Text = "Otro (Especifique)";
            this.rdoOtro.UseVisualStyleBackColor = true;
            this.rdoOtro.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtOtro
            // 
            this.txtOtro.Enabled = false;
            this.txtOtro.Location = new System.Drawing.Point(146, 138);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(142, 20);
            this.txtOtro.TabIndex = 26;
            // 
            // Crear_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 202);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.rdoOtro);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rdoMujer);
            this.Controls.Add(this.rdoHombre);
            this.Controls.Add(this.rtxSinUso);
            this.Controls.Add(this.lblEliminarUsuario);
            this.Controls.Add(this.txtEliminarUser);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblComprobacion);
            this.Controls.Add(this.txtRepetirContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblRepetirContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Crear_Cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRepetirContraseña;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtRepetirContraseña;
        private System.Windows.Forms.Label lblComprobacion;
        private System.Windows.Forms.OpenFileDialog ofdImagen;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtEliminarUser;
        private System.Windows.Forms.Label lblEliminarUsuario;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUnUsuarioCreadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarElUsuarioCreadoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxSinUso;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.RadioButton rdoHombre;
        private System.Windows.Forms.RadioButton rdoMujer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton rdoOtro;
        private System.Windows.Forms.TextBox txtOtro;
    }
}