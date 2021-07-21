namespace See_More
{
    partial class Nuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblApartado = new System.Windows.Forms.Label();
            this.txtApartado = new System.Windows.Forms.TextBox();
            this.chkGeneral = new System.Windows.Forms.CheckBox();
            this.chkApartado = new System.Windows.Forms.CheckBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buscarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 55);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 13);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "URL:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(663, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(49, 55);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(679, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            this.txtURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.txtURL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarArchivoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarListaToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(728, 24);
            this.mspMenu.TabIndex = 9;
            this.mspMenu.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarListaToolStripMenuItem
            // 
            this.guardarListaToolStripMenuItem.Name = "guardarListaToolStripMenuItem";
            this.guardarListaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.guardarListaToolStripMenuItem.Text = "Guardar lista";
            this.guardarListaToolStripMenuItem.Click += new System.EventHandler(this.guardarListaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 75);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(253, 65);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblApartado
            // 
            this.lblApartado.AutoSize = true;
            this.lblApartado.Location = new System.Drawing.Point(260, 81);
            this.lblApartado.Name = "lblApartado";
            this.lblApartado.Size = new System.Drawing.Size(109, 13);
            this.lblApartado.TabIndex = 12;
            this.lblApartado.Text = "Nombre del apartado:";
            // 
            // txtApartado
            // 
            this.txtApartado.Location = new System.Drawing.Point(375, 78);
            this.txtApartado.Name = "txtApartado";
            this.txtApartado.Size = new System.Drawing.Size(133, 20);
            this.txtApartado.TabIndex = 13;
            // 
            // chkGeneral
            // 
            this.chkGeneral.AutoSize = true;
            this.chkGeneral.Location = new System.Drawing.Point(274, 103);
            this.chkGeneral.Name = "chkGeneral";
            this.chkGeneral.Size = new System.Drawing.Size(63, 17);
            this.chkGeneral.TabIndex = 14;
            this.chkGeneral.Text = "General";
            this.chkGeneral.UseVisualStyleBackColor = true;
            // 
            // chkApartado
            // 
            this.chkApartado.AutoSize = true;
            this.chkApartado.Location = new System.Drawing.Point(343, 104);
            this.chkApartado.Name = "chkApartado";
            this.chkApartado.Size = new System.Drawing.Size(84, 17);
            this.chkApartado.TabIndex = 15;
            this.chkApartado.Text = "En apartado";
            this.chkApartado.UseVisualStyleBackColor = true;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(-3, 147);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(297, 13);
            this.lblNota.TabIndex = 16;
            this.lblNota.Text = "Nota: si ninguna casilla esta marcada se guardara en General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(589, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buscarArchivoToolStripMenuItem
            // 
            this.buscarArchivoToolStripMenuItem.Name = "buscarArchivoToolStripMenuItem";
            this.buscarArchivoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.buscarArchivoToolStripMenuItem.Text = "Buscar Archivo";
            this.buscarArchivoToolStripMenuItem.Click += new System.EventHandler(this.buscarArchivoToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Enabled = false;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Enabled = false;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(728, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.chkApartado);
            this.Controls.Add(this.chkGeneral);
            this.Controls.Add(this.txtApartado);
            this.Controls.Add(this.lblApartado);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.mspMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Nuevo";
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.TextBox txtApartado;
        private System.Windows.Forms.CheckBox chkGeneral;
        private System.Windows.Forms.CheckBox chkApartado;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem buscarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}