using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using MODELOS_SEEMORE;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Nuevo : Form
    {
        WindowsMediaPlayer sonido = new WindowsMediaPlayer();
        public Nuevo()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Width = 744;
            this.Height = 200;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\nuevo.txt");
                line = rd.ReadLine();
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
            if(!Configuracion.existeConexion) {
                guardarToolStripMenuItem.Enabled = false;
                guardarListaToolStripMenuItem.Enabled = false;
                abrirToolStripMenuItem.Enabled = false;
                txtNombre.Enabled = false;
                txtURL.Enabled = false;
                txtApartado.Enabled = false;
                chkGeneral.Enabled = false;
                chkApartado.Enabled = false;
                MessageBox.Show("No hay una conexión a la BD, esto no es impedimento\n See More puede funcionar sin necesidad de guardar elementos a un respaldo","See More");               
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtURL.Text != "")
            {
                if (txtURL.Text.EndsWith(".mp4") || txtURL.Text.EndsWith(".avi") || txtURL.Text.EndsWith(".wmv") || txtURL.Text.EndsWith(".mkv"))
                {
                    if (txtURL.Text.StartsWith(@"C:\") || txtURL.Text.StartsWith(@"D:\"))
                    {
                        if (Configuracion.existeConexion)
                        {
                            if (chkGeneral.Checked == true)
                            {
                                Seemore see = new Seemore();
                                see.Nombre = txtNombre.Text.Trim();
                                string result = string.Empty;
                                byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtURL.Text);
                                result = Convert.ToBase64String(encryted);
                                see.URL = result.Trim();
                                int resultado = DatosSeeMore.Agregar(see);
                                if (resultado > 0)
                                {
                                    MessageBox.Show("URL del video " + txtNombre.Text + " almacenado", "Guadado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("URL del video no almacenado", "Guardado fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            if (chkApartado.Checked == true)
                            {
                                if (txtApartado.Text != "")
                                {
                                    Seemore see = new Seemore();
                                    see.Nombre = txtNombre.Text.Trim();
                                    string result = string.Empty;
                                    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtURL.Text);
                                    result = Convert.ToBase64String(encryted);
                                    see.URL = result.Trim();
                                    int resultado = ApartadosSeeMore.AgregarEnApartado(txtApartado.Text, see);
                                    if (resultado > 0)
                                    {
                                        MessageBox.Show("URL del video " + txtNombre.Text + " almacenado", "Guadado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("URL del video no almacenado", "Guardado fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Se necesita el nombre del apartado a guardar", "Error en guardar apartado");
                                }
                            }
                            if (chkGeneral.Checked == false && chkApartado.Checked == false)
                            {
                                Seemore see = new Seemore();
                                see.Nombre = txtNombre.Text.Trim();
                                string result = string.Empty;
                                byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtURL.Text);
                                result = Convert.ToBase64String(encryted);
                                see.URL = result.Trim();
                                int resultado = DatosSeeMore.Agregar(see);
                                if (resultado > 0)
                                {
                                    MessageBox.Show("URL del video " + txtNombre.Text + " almacenado", "Guadado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("URL del video no almacenado", "Guardado fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontro una conexion estable, se comenzara el guardado de respaldo");
                            try
                            {//File.AppendText(@"C:\mvFiles\SQLReport.txt");
                             // StreamWriter sw = new StreamWriter("C:\\respaldo.txt",true);
                                StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\respaldo.txt");
                                sw.WriteLine(txtNombre.Text + " " + txtURL.Text);
                                sw.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                            }
                            finally
                            {
                                //MessageBox.Show("Respaldo guardado");
                            }
                        }  
                    }
                    else
                    {
                        MessageBox.Show("La ruta del video no empieza con una ruta aceptable", "Error en la ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Se necesita una extensión valida, su extensión no es aceptada");
                }
            }
            else if (txtNombre.Text != "" && txtURL.Text == "")
            {
                MessageBox.Show("Solo se ha ingresado el nombre, por favor ingrese la URL");
            }
            else if (txtNombre.Text == "" && txtURL.Text != "")
            {
                MessageBox.Show("Solo se ha ingresado la URL, por favor ingrese el nombre");
            }
            else if (txtNombre.Text == "" && txtURL.Text == "")
            {
                MessageBox.Show("URL y nombre estan vacios, por favor llenelos");
            }
        }
        private void guardarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtURL.Text != "")
            {             
                   if (txtURL.Text.EndsWith(".wpl"))
                    {
                        if (txtURL.Text.StartsWith(@"C:\"))
                        {         
                            if(Configuracion.existeConexion)
                            {
                                if (chkGeneral.Checked == true)
                                {
                                    Seemore see = new Seemore();
                                    see.Nombre = txtNombre.Text.Trim();
                                    string result = string.Empty;
                                    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtURL.Text);
                                    result = Convert.ToBase64String(encryted);
                                    see.URL = result.Trim();
                                    int resultado = ListasSeeMore.AgregarLista(see);
                                    if (resultado > 0)
                                    {
                                        MessageBox.Show("URL de la lista " + txtNombre.Text + " almacenada", "Guadado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("URL de la lista no almacenada", "Guardado fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                if(chkApartado.Checked == true)
                                {
                                    if (txtApartado.Text != "")
                                    {
                                        Seemore see = new Seemore();
                                        see.Nombre = txtNombre.Text.Trim();
                                        string result = string.Empty;
                                        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtURL.Text);
                                        result = Convert.ToBase64String(encryted);
                                        see.URL = result.Trim();
                                        int resultado = ApartadosSeeMore.AgregarEnApartado(txtApartado.Text, see);
                                        if (resultado > 0)
                                        {
                                            MessageBox.Show("URL de la lista " + txtNombre.Text + " almacenada", "Guadado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("URL de la lista no almacenada", "Guardado fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Se necesita el nombre del apartado a guardar", "Error en guardar apartado");
                                    }
                                }
                                if(chkGeneral.Checked == false && chkApartado.Checked == false)
                                {
                                    Seemore see = new Seemore();
                                    see.Nombre = txtNombre.Text.Trim();
                                    string result = string.Empty;
                                    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtURL.Text);
                                    result = Convert.ToBase64String(encryted);
                                    see.URL = result.Trim();
                                    int resultado = ListasSeeMore.AgregarLista(see);
                                    if (resultado > 0)
                                    {
                                        MessageBox.Show("URL de la lista " + txtNombre.Text + " almacenada", "Guadado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("URL de la lista no almacenada", "Guardado fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontro una conexion estable, se comenzara el guardado de respaldo");
                                try
                                {//File.AppendText(@"C:\mvFiles\SQLReport.txt");
                                 // StreamWriter sw = new StreamWriter("C:\\respaldo.txt",true);
                                    StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\respaldo.txt");
                                    sw.WriteLine(txtNombre.Text + " " + txtURL.Text);
                                    sw.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                                }
                                finally
                                {
                                    //MessageBox.Show("Respaldo guardado");
                                }
                            }                        
                        }
                        else
                        {
                            MessageBox.Show("Se necesita una ruta valida para la lista");
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
            else if (txtNombre.Text != "" && txtURL.Text == "")
            {
                MessageBox.Show("Solo se ha ingresado el nombre, por favor ingrese la URL");
            }
            else if (txtNombre.Text == "" && txtURL.Text != "")
            {
                MessageBox.Show("Solo se ha ingresado la URL, por favor ingrese el nombre");
            }
            else if (txtNombre.Text == "" && txtURL.Text == "")
            {
                MessageBox.Show("URL y nombre estan vacios, por favor llenelos");
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtURL.Text.StartsWith(@"C:\"))
            {
                if (txtURL.Text.EndsWith(".mp4") || txtURL.Text.EndsWith(".avi") || txtURL.Text.EndsWith(".wmv") || txtURL.Text.EndsWith(".mkv"))
                {
                    sonido.URL = txtURL.Text;
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\cargando.gif");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    timer1.Start();
                }
                else if (txtURL.Text.EndsWith(".wpl"))
                {
                    sonido.URL = txtURL.Text;
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\cargando.gif");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    timer1.Start();
                }
                else
                {
                    guardarListaToolStripMenuItem.Enabled = false;
                    guardarToolStripMenuItem.Enabled = false;
                    e.Handled = false;
                }
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de video mp4|*.mp4|Archivos de video avi|*.avi|Archivos de video wmv|*.wmv|Archivos de pelicula mkv|*.mkv|Archivos de lista wpl|*.wpl";
            abrir.FileName = "Videos";
            abrir.Title = "Video";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string direccion = abrir.FileName;
                if (direccion.EndsWith(".mp4") || direccion.EndsWith(".avi") || direccion.EndsWith(".wmv") || direccion.EndsWith(".mkv"))
                {
                    sonido.URL = txtURL.Text;
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\cargando.gif");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    timer1.Start();
                }
                else if (direccion.EndsWith(".wpl"))
                {
                    sonido.URL = txtURL.Text;
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\cargando.gif");
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    timer1.Start();
                }
                else
                {
                    guardarListaToolStripMenuItem.Enabled = false;
                    guardarToolStripMenuItem.Enabled = false;
                }
                    //axWindowsMediaPlayer1.URL = direccion;
                    txtURL.Text = direccion;              
            }
        }
        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Buscando el video";
            sonido.settings.volume = 0;
            sonido.settings.mute = true;
            if (sonido.playState == WMPPlayState.wmppsPlaying)
            {
                if (txtURL.Text.EndsWith(".mp4") || txtURL.Text.EndsWith(".avi") || txtURL.Text.EndsWith(".wmv") || txtURL.Text.EndsWith(".mkv"))
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\paloma.png");
                    label2.Text = "Video encontrado";
                    timer1.Stop();
                    guardarListaToolStripMenuItem.Enabled = false;
                    guardarToolStripMenuItem.Enabled = true;
                }
                else if (txtURL.Text.EndsWith(".wpl"))
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\paloma.png");
                    label2.Text = "Lista encontrada";
                    timer1.Stop();
                    guardarListaToolStripMenuItem.Enabled = true;
                    guardarToolStripMenuItem.Enabled = false;
                }
            }
            if (sonido.playState == WMPPlayState.wmppsReady)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\See More\Configuraciones SeeMore\tache.png");
                label2.Text = "Video/Lista no encontrado";
                timer1.Stop();
                guardarListaToolStripMenuItem.Enabled = false;
                guardarToolStripMenuItem.Enabled = false;
            }
        }
        private void Nuevo_Load(object sender, EventArgs e)
        {
            if (!Configuracion.existeConexion)
            {
                this.Close();
            }
        }
    }
}
