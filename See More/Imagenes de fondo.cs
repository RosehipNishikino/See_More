using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace See_More
{
    public partial class Imagenes_de_fondo : Form
    {
        public Imagenes_de_fondo()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rtxHistorialImagen.LoadFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt", RichTextBoxStreamType.PlainText);
            String[] lineas = File.ReadAllLines(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt");
            try
            {


                this.BackgroundImage = Image.FromFile(lineas[lineas.Length - 1]);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        StreamWriter sw;
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de imagen jpg|*.jpg| Archivos de imagen png|*.png";
            abrir.FileName = "Imagenes";
            abrir.Title = "Imagen";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string direccion = abrir.FileName;
                txtRuta.Text = direccion;
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtRuta.Text != "")
            {
                if (txtRuta.Text.EndsWith("jpg") || txtRuta.Text.EndsWith("png"))
                {
                    
                    sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt");
                    sw.WriteLine(txtRuta.Text);
                    sw.Close();
                    Comprobar();
                    rtxHistorialImagen.LoadFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt", RichTextBoxStreamType.PlainText);
                    String line;
                    try
                    {
                        StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt");
                        line = rd.ReadLine();
                        while ((line = rd.ReadLine()) != null)
                        {
                            if (line == null)
                            {
                                this.Text = "Imagenes de fondo - No se ha encontrado una imagen";
                            }
                            else
                            {
                                if (rd.EndOfStream)
                                {
                                    this.BackgroundImage = Image.FromFile(line);
                                    this.BackgroundImageLayout = ImageLayout.Stretch;
                                }
                            }
                        }
                        rd.Close();

                    }
                    catch (Exception) { }
                    MessageBox.Show("URL de la imagen " + txtNombre.Text + " almacenado", "Guadado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La extensión ingresada no es valida");
                }
            }else if(txtNombre.Text == "" && txtRuta.Text != "")
            {
                MessageBox.Show("Hay un campo vacio, llenelo");
            }else if (txtNombre.Text != "" && txtRuta.Text == "")
            {
                MessageBox.Show("No se ha buscado una imagen o ingresado una ruta");
            }else if(txtNombre.Text == "" && txtRuta.Text == "")
            {
                MessageBox.Show("No se ha ingresado ningún dato");
            }
        }  
        public void Comprobar()
        {
            if (chkReproductor.Checked)
            {
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\reproductor.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\reproductor.txt");
                sw.WriteLine(txtRuta.Text);
                sw.Close();
            }
            if (chkActualizar.Checked)
            {
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\actualizar.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\actualizar.txt");
                sw.WriteLine(txtRuta.Text);
                sw.Close();
            }
            if (chkBuscar.Checked)
            {
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\buscar.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\buscar.txt");
                sw.WriteLine(txtRuta.Text);
                sw.Close();
            }
            if (chkBusqueda.Checked)
            {
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\busqueda.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\busqueda.txt");
                sw.WriteLine(txtRuta.Text);
                sw.Close();
            }
            if (chkCrearCuenta.Checked)
            {
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\crearcuenta.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\crearcuenta.txt");
                sw.WriteLine(txtRuta.Text);
                sw.Close();
            }
            if (chkEliminar.Checked)
            {
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\eliminar.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\eliminar.txt");
                sw.WriteLine(txtRuta.Text);
                sw.Close();
            }
            if (chkHistorial.Checked)
            {
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\history.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\history.txt");
                sw.WriteLine(txtRuta.Text);
                sw.Close();
            }
            if (chkNuevo.Checked)
            {
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\nuevo.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\nuevo.txt");
                sw.WriteLine(txtRuta.Text);
                sw.Close();
            }
        }
        private void Imagenes_de_fondo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void previsualizarImagenAGuardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtRuta.Text != "")
            {
                picComprobacion.Visible = true;
                picComprobacion.BackgroundImage = Image.FromFile(txtRuta.Text);
                picComprobacion.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
            }
        }
        private void previsualizarImagenDeHistorialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            picComprobacion.Visible = true;
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt");
                line = rd.ReadLine();
                while ((line = rd.ReadLine()) != null)
                {
                    if (line == null)
                    {
                    }
                    else
                    {
                        if (rd.EndOfStream)
                        {
                            picComprobacion.BackgroundImage = Image.FromFile(line);
                            picComprobacion.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                }
                rd.Close();
            }
            catch (Exception) { }
        }
        private void cerrarPrevisualizaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            picComprobacion.Visible = false;
        }

        private void guardarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxHistorialImagen.SaveFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt", RichTextBoxStreamType.PlainText);
            rtxHistorialImagen.LoadFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt", RichTextBoxStreamType.PlainText);
        }
    }
}
