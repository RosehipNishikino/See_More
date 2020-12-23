namespace See_More
{
    partial class Historial
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
            this.lblHistorial = new System.Windows.Forms.Label();
            this.rtxHistorial = new System.Windows.Forms.RichTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(0, 2);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(92, 13);
            this.lblHistorial.TabIndex = 0;
            this.lblHistorial.Text = "Este es tu historial";
            // 
            // rtxHistorial
            // 
            this.rtxHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxHistorial.Location = new System.Drawing.Point(3, 19);
            this.rtxHistorial.Name = "rtxHistorial";
            this.rtxHistorial.Size = new System.Drawing.Size(636, 231);
            this.rtxHistorial.TabIndex = 1;
            this.rtxHistorial.Text = "";
            this.rtxHistorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(0, 253);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(452, 26);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Para borrar un registro de tu historial, solo borra esa línea y ya esta actualiza" +
    "do\r\nSi no esta seguro de que se haya actualizado su historial, refresque con \"F5" +
    "\" para cerciorarse.";
            this.lblInfo.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 288);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rtxHistorial);
            this.Controls.Add(this.lblHistorial);
            this.KeyPreview = true;
            this.Name = "Historial";
            this.Text = "Historial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Historial_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Historial_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Historial_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.RichTextBox rtxHistorial;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}