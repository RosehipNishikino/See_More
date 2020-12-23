namespace See_More
{
    partial class Busqueda
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.aceptarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarApartadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblApartado = new System.Windows.Forms.Label();
            this.txtApartado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(1, 26);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(487, 191);
            this.dgvDatos.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(-3, 223);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(104, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Busca por el nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 223);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(390, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aceptarToolStripMenuItem,
            this.buscarNombreToolStripMenuItem,
            this.buscarApartadoToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(488, 24);
            this.mspMenu.TabIndex = 5;
            this.mspMenu.Text = "menuStrip1";
            // 
            // aceptarToolStripMenuItem
            // 
            this.aceptarToolStripMenuItem.Name = "aceptarToolStripMenuItem";
            this.aceptarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aceptarToolStripMenuItem.Text = "Aceptar";
            this.aceptarToolStripMenuItem.Click += new System.EventHandler(this.aceptarToolStripMenuItem_Click);
            // 
            // buscarNombreToolStripMenuItem
            // 
            this.buscarNombreToolStripMenuItem.Name = "buscarNombreToolStripMenuItem";
            this.buscarNombreToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.buscarNombreToolStripMenuItem.Text = "Buscar nombre";
            this.buscarNombreToolStripMenuItem.Click += new System.EventHandler(this.buscarNombreToolStripMenuItem_Click);
            // 
            // buscarApartadoToolStripMenuItem
            // 
            this.buscarApartadoToolStripMenuItem.Name = "buscarApartadoToolStripMenuItem";
            this.buscarApartadoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.buscarApartadoToolStripMenuItem.Text = "Buscar Apartado";
            this.buscarApartadoToolStripMenuItem.Click += new System.EventHandler(this.buscarApartadoToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(-2, 247);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(397, 13);
            this.lblDatos.TabIndex = 6;
            this.lblDatos.Text = "Si la busqueda se realizó por un apartado, escriba el nombre del apartado a busca" +
    "r";
            // 
            // lblApartado
            // 
            this.lblApartado.AutoSize = true;
            this.lblApartado.Location = new System.Drawing.Point(-2, 270);
            this.lblApartado.Name = "lblApartado";
            this.lblApartado.Size = new System.Drawing.Size(109, 13);
            this.lblApartado.TabIndex = 7;
            this.lblApartado.Text = "Nombre del apartado:";
            // 
            // txtApartado
            // 
            this.txtApartado.Location = new System.Drawing.Point(106, 268);
            this.txtApartado.Name = "txtApartado";
            this.txtApartado.Size = new System.Drawing.Size(275, 20);
            this.txtApartado.TabIndex = 8;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 291);
            this.Controls.Add(this.txtApartado);
            this.Controls.Add(this.lblApartado);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.mspMenu);
            this.MainMenuStrip = this.mspMenu;
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem aceptarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarApartadoToolStripMenuItem;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblApartado;
        private System.Windows.Forms.TextBox txtApartado;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
    }
}