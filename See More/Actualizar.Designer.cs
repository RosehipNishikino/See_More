namespace See_more
{
    partial class Actualizar
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
            this.buscarArchivoFaltanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblApartado = new System.Windows.Forms.Label();
            this.txtApartado = new System.Windows.Forms.TextBox();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 62);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(465, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(47, 59);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(631, 20);
            this.txtURL.TabIndex = 3;
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarArchivoFaltanteToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(690, 24);
            this.mspMenu.TabIndex = 8;
            this.mspMenu.Text = "menuStrip1";
            // 
            // buscarArchivoFaltanteToolStripMenuItem
            // 
            this.buscarArchivoFaltanteToolStripMenuItem.Name = "buscarArchivoFaltanteToolStripMenuItem";
            this.buscarArchivoFaltanteToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.buscarArchivoFaltanteToolStripMenuItem.Text = "Buscar archivo faltante";
            this.buscarArchivoFaltanteToolStripMenuItem.Click += new System.EventHandler(this.buscarArchivoFaltanteToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 82);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(366, 26);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Si hubo un error con un apartado, ahora puede buscar el dato y actualizarlo,\r\nsol" +
    "o necesitamos el nombre del apartado.";
            // 
            // lblApartado
            // 
            this.lblApartado.AutoSize = true;
            this.lblApartado.Location = new System.Drawing.Point(12, 115);
            this.lblApartado.Name = "lblApartado";
            this.lblApartado.Size = new System.Drawing.Size(109, 13);
            this.lblApartado.TabIndex = 10;
            this.lblApartado.Text = "Nombre del apartado:";
            // 
            // txtApartado
            // 
            this.txtApartado.Location = new System.Drawing.Point(121, 111);
            this.txtApartado.Name = "txtApartado";
            this.txtApartado.Size = new System.Drawing.Size(257, 20);
            this.txtApartado.TabIndex = 11;
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 137);
            this.Controls.Add(this.txtApartado);
            this.Controls.Add(this.lblApartado);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.Actualizar_Load);
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
        private System.Windows.Forms.ToolStripMenuItem buscarArchivoFaltanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.TextBox txtApartado;
    }
}