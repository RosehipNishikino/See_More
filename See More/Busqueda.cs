using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MODELOS_SEEMORE;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Busqueda : Form
    {
        public Seemore AnimeSE { get; set; }
        Boolean esApartado = false;
        public Busqueda()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\busqueda.txt");
                line = rd.ReadLine();
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
            if(Configuracion.existeConexion)
            {
                dgvDatos.DataSource = DatosSeeMore.BuscarT();
            }
        }
        private void aceptarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Configuracion.existeConexion)
            {
                if (esApartado == false)
                {
                    if (dgvDatos.SelectedRows.Count == 1)
                    {
                        int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                        AnimeSE = DatosSeeMore.Obtener(id);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Se debe seleccionar un video para su actualización o eliminación");
                    }
                }
                else
                {
                    if (dgvDatos.SelectedRows.Count == 1)
                    {
                        int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                        AnimeSE = ApartadosSeeMore.ObtenerApartado(txtApartado.Text, id);
                        this.Close();
                    }
                }
            }
        }
        private void buscarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Configuracion.existeConexion)
            {
                esApartado = false;
                dgvDatos.DataSource = DatosSeeMore.BuscarNombre(txtNombre.Text);
            }
        }
        private void buscarApartadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Configuracion.existeConexion)
            {
                esApartado = true;
                dgvDatos.DataSource = ApartadosSeeMore.BuscarEnElApartado(txtApartado.Text);
            }
        }
    }
}
