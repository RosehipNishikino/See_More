namespace See_More
{
    partial class Eliminar
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
            this.lblURL = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.buscarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtApartado = new System.Windows.Forms.TextBox();
            this.lblApartado = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 70);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(454, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(47, 67);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(621, 20);
            this.txtURL.TabIndex = 3;
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarArchivoToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(700, 24);
            this.mspMenu.TabIndex = 6;
            this.mspMenu.Text = "menuStrip1";
            // 
            // buscarArchivoToolStripMenuItem
            // 
            this.buscarArchivoToolStripMenuItem.Name = "buscarArchivoToolStripMenuItem";
            this.buscarArchivoToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.buscarArchivoToolStripMenuItem.Text = "Buscar Archivo";
            this.buscarArchivoToolStripMenuItem.Click += new System.EventHandler(this.buscarArchivoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // txtApartado
            // 
            this.txtApartado.Location = new System.Drawing.Point(121, 119);
            this.txtApartado.Name = "txtApartado";
            this.txtApartado.Size = new System.Drawing.Size(257, 20);
            this.txtApartado.TabIndex = 14;
            // 
            // lblApartado
            // 
            this.lblApartado.AutoSize = true;
            this.lblApartado.Location = new System.Drawing.Point(12, 123);
            this.lblApartado.Name = "lblApartado";
            this.lblApartado.Size = new System.Drawing.Size(109, 13);
            this.lblApartado.TabIndex = 13;
            this.lblApartado.Text = "Nombre del apartado:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 90);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(356, 26);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Si hubo un error con un apartado, ahora puede buscar el dato y eliminarlo,\r\nsolo " +
    "necesitamos el nombre del apartado.";
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 150);
            this.Controls.Add(this.txtApartado);
            this.Controls.Add(this.lblApartado);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem buscarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtApartado;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.Label lblInfo;
    }
}