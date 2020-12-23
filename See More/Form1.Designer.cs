
namespace See_More
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHistorial = new FontAwesome.Sharp.IconButton();
            this.btnPersonalizacion = new FontAwesome.Sharp.IconButton();
            this.btnInicioSesion = new FontAwesome.Sharp.IconButton();
            this.btnCrearCuenta = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.btnCurrentChildForm = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.wmpCentral = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmrProgreso = new System.Windows.Forms.Timer(this.components);
            this.tmrGuardarAuto = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpCentral)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Navy;
            this.panelMenu.Controls.Add(this.btnHistorial);
            this.panelMenu.Controls.Add(this.btnPersonalizacion);
            this.panelMenu.Controls.Add(this.btnInicioSesion);
            this.panelMenu.Controls.Add(this.btnCrearCuenta);
            this.panelMenu.Controls.Add(this.btnBuscar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 516);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnHistorial.IconColor = System.Drawing.Color.Silver;
            this.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(0, 380);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHistorial.Size = new System.Drawing.Size(220, 60);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnPersonalizacion
            // 
            this.btnPersonalizacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonalizacion.FlatAppearance.BorderSize = 0;
            this.btnPersonalizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalizacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalizacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonalizacion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnPersonalizacion.IconColor = System.Drawing.Color.Silver;
            this.btnPersonalizacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPersonalizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalizacion.Location = new System.Drawing.Point(0, 320);
            this.btnPersonalizacion.Name = "btnPersonalizacion";
            this.btnPersonalizacion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPersonalizacion.Size = new System.Drawing.Size(220, 60);
            this.btnPersonalizacion.TabIndex = 4;
            this.btnPersonalizacion.Text = "Personalización";
            this.btnPersonalizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonalizacion.UseVisualStyleBackColor = true;
            this.btnPersonalizacion.Click += new System.EventHandler(this.btnPersonalizacion_Click);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicioSesion.FlatAppearance.BorderSize = 0;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInicioSesion.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnInicioSesion.IconColor = System.Drawing.Color.Silver;
            this.btnInicioSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicioSesion.Location = new System.Drawing.Point(0, 260);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInicioSesion.Size = new System.Drawing.Size(220, 60);
            this.btnInicioSesion.TabIndex = 3;
            this.btnInicioSesion.Text = "Iniciar sesión";
            this.btnInicioSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicioSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearCuenta.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnCrearCuenta.IconColor = System.Drawing.Color.Silver;
            this.btnCrearCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCuenta.Location = new System.Drawing.Point(0, 200);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCrearCuenta.Size = new System.Drawing.Size(220, 60);
            this.btnCrearCuenta.TabIndex = 2;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Silver;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(0, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuscar.Size = new System.Drawing.Size(220, 60);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::See_More.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(12, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(187, 89);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Navy;
            this.panelTitle.Controls.Add(this.btnMin);
            this.panelTitle.Controls.Add(this.btnMax);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Controls.Add(this.lblTitleChildForm);
            this.panelTitle.Controls.Add(this.btnCurrentChildForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(659, 80);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Navy;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.Silver;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 30;
            this.btnMin.Location = new System.Drawing.Point(572, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 23);
            this.btnMin.TabIndex = 6;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Navy;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.Silver;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 30;
            this.btnMax.Location = new System.Drawing.Point(600, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(31, 23);
            this.btnMax.TabIndex = 5;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Navy;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Silver;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(628, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(87, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(77, 18);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "See More";
            // 
            // btnCurrentChildForm
            // 
            this.btnCurrentChildForm.FlatAppearance.BorderSize = 0;
            this.btnCurrentChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnCurrentChildForm.IconColor = System.Drawing.Color.Silver;
            this.btnCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCurrentChildForm.IconSize = 64;
            this.btnCurrentChildForm.Location = new System.Drawing.Point(24, 12);
            this.btnCurrentChildForm.Name = "btnCurrentChildForm";
            this.btnCurrentChildForm.Size = new System.Drawing.Size(57, 59);
            this.btnCurrentChildForm.TabIndex = 0;
            this.btnCurrentChildForm.UseVisualStyleBackColor = true;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Navy;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(659, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Navy;
            this.panelDesktop.Controls.Add(this.wmpCentral);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(659, 427);
            this.panelDesktop.TabIndex = 3;
            // 
            // wmpCentral
            // 
            this.wmpCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpCentral.Enabled = true;
            this.wmpCentral.Location = new System.Drawing.Point(0, 0);
            this.wmpCentral.Name = "wmpCentral";
            this.wmpCentral.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpCentral.OcxState")));
            this.wmpCentral.Size = new System.Drawing.Size(659, 427);
            this.wmpCentral.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 516);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpCentral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnPersonalizacion;
        private FontAwesome.Sharp.IconButton btnInicioSesion;
        private FontAwesome.Sharp.IconButton btnCrearCuenta;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMin;
        private AxWMPLib.AxWindowsMediaPlayer wmpCentral;
        private System.Windows.Forms.Timer tmrProgreso;
        private System.Windows.Forms.Timer tmrGuardarAuto;
    }
}

