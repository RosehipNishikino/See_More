using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS_SEEMORE;
using MODELOS_SEEMORE;

namespace See_More
{
    public partial class Actualizar : Form
    {
        public Seemore AnimeAC { get; set; }
        public Actualizar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath+@"\See More\Configuraciones SeeMore\actualizar.txt");
                line = rd.ReadLine();
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
            if (!Configuracion.existeConexion)
            {
                buscarArchivoFaltanteToolStripMenuItem.Enabled = false;
                actualizarToolStripMenuItem.Enabled = false;
                MessageBox.Show("No hay conexión, pero no te preocupes\nSee More es capaz de funcionar sin una conexión, pero no puedes actualizar pues no la necesita", "See More");              
            }
        }
        private void buscarArchivoFaltanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Configuracion.existeConexion)
            { 
                Busqueda frm = new Busqueda();
                frm.ShowDialog();
                if (frm.AnimeSE != null)
                {
                    AnimeAC = frm.AnimeSE;
                    txtNombre.Text = AnimeAC.Nombre;
                    string result = string.Empty;
                    byte[] decryted = Convert.FromBase64String(AnimeAC.URL);
                    result = System.Text.Encoding.Unicode.GetString(decryted);
                    txtURL.Text = result;
                }
            }
            else
            {
                MessageBox.Show("No se puede realizar una busqueda, no se puede usar el respaldo");
            }
        }
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtURL.Text != "")
            {
                if(Configuracion.existeConexion)
                {
                    if (txtURL.Text.EndsWith("mp4") || txtURL.Text.EndsWith("avi") || txtURL.Text.EndsWith("wmv") || txtURL.Text.EndsWith("wpl") || txtURL.Text.EndsWith("mkv"))
                    {
                        if (txtApartado.Text == "")
                        {
                            Seemore pSee = new Seemore();
                            pSee.Nombre = txtNombre.Text.Trim();
                            string result = string.Empty;
                            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtURL.Text);
                            result = Convert.ToBase64String(encryted);
                            pSee.URL = result.Trim();
                            pSee.ID = AnimeAC.ID;
                            if (DatosSeeMore.actualizar(pSee) > 0)
                            {
                                MessageBox.Show("URL ó nombre actualizado", "Información actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("URL ó nombre no actualizado", "Información no actualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            Seemore pSee2 = new Seemore();
                            pSee2.Nombre = txtNombre.Text.Trim();
                            string result = string.Empty;
                            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtURL.Text);
                            result = Convert.ToBase64String(encryted);
                            pSee2.URL = result.Trim();
                            pSee2.ID = AnimeAC.ID;
                            if(ApartadosSeeMore.ActualizarApartado(txtApartado.Text,pSee2) > 0)
                            {
                                MessageBox.Show("URL ó nombre actualizado", "Información actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("URL ó nombre no actualizado", "Información no actualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        String cortada = txtURL.Text;
                        int donde = cortada.Length;
                        String listo = cortada.Substring((donde - 3), 3);
                        MessageBox.Show("Se necesita una extensión valida, su extensión " + listo + " no es aceptada");
                    }
                }
                else
                {
                    MessageBox.Show("La conexion no es estable, no se puede utilizar el respaldo");
                }
            }
            else if (txtNombre.Text == "" && txtURL.Text == "")
            {
                MessageBox.Show("Estan vacios, no ha realizado ninguna busqueda");
            }
            else if (txtNombre.Text != "" && txtURL.Text == "")
            {
                MessageBox.Show("Falta la URL, por favor ingrese la nueva URL");
            }
            else if (txtNombre.Text == "" && txtURL.Text != "")
            {
                MessageBox.Show("Falta el nombre, ¿el episodio o anime cambio de nombre?, bueno, ingrese el nuevo nombre");
            }
        }
        private void Actualizar_Load(object sender, EventArgs e)
        {
            if (!Configuracion.existeConexion)
            {
                this.Close();
            }
        }
    }
}
