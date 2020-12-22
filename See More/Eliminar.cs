using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MODELOS_SEEMORE;
using DATOS_SEEMORE;

namespace See_more
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\eliminar.txt");
                line = rd.ReadLine();
                            this.BackgroundImage = Image.FromFile(line);
                            this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
            if(!Configuracion.existeConexion)
            {
                buscarArchivoToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
                MessageBox.Show("No hay conexión, pero See More puede funcionar, pero no necesita eliminar","See More");

            }
        }
        public Seemore eliminar { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Configuracion.existeConexion)
            {
                Busqueda frm = new Busqueda();
                frm.ShowDialog();
                if (frm.AnimeSE != null)
                {
                    eliminar = frm.AnimeSE;
                    txtNombre.Text = frm.AnimeSE.Nombre;
                    string result = string.Empty;
                    byte[] decryted = Convert.FromBase64String(frm.AnimeSE.URL);
                    result = System.Text.Encoding.Unicode.GetString(decryted);
                    txtURL.Text = result;
                }
            }
            else
            {
                MessageBox.Show("No hay conexion estable");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtURL.Text != "")
            {
                if(Configuracion.existeConexion)
                {
                    
                    if (txtApartado.Text == "")
                    {
                        if (MessageBox.Show("¿Desea eliminar la siguiente URL?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (DatosSeeMore.Eliminar(eliminar.ID) > 0)
                            {
                                MessageBox.Show("Se ha eliminado la URL exitosamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al eliminar la URL", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se cancelo la eliminacion de la URL", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Desea eliminar la siguiente URL?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (ApartadosSeeMore.EliminarApartado(txtApartado.Text, eliminar.ID) > 0)
                            {
                                MessageBox.Show("Se ha eliminado la URL exitosamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al eliminar la URL", "Eliminacion fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se cancelo la eliminacion de la URL", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha establecido una conexion, intente mas tarde");
                }
            }
            else if (txtNombre.Text == "" && txtURL.Text == "")
            {
                MessageBox.Show("Estan vacios, no ha realizado ninguna busqueda");
            }
            else if (txtNombre.Text != "" && txtURL.Text == "")
            {
                MessageBox.Show("Tengo dos posibles, ¿Estas intentando eliminar la URL directa? ó los datos no llegaron bien");
            }
            else if (txtNombre.Text == "" && txtURL.Text != "")
            {
                MessageBox.Show("Tengo dos posibles, ¿Estas intentando eliminar el nombre directo? ó los datos no llegaron bien");
            }
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            if (!Configuracion.existeConexion)
            {
                this.Close();
            }
        }
    }
}
