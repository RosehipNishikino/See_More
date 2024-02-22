using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Tu_perfil : Form
    {
        Boolean entraSINO = false;
        StreamWriter sw1 = null, sw2 = null, sw3 = null;
        String genero = "";
        String usuarioAct;
        String imagenSinConexion;
        String rutadeImagen;
        Boolean regresarHistorial = true;
        String imagenPerfil = string.Empty;
        public Tu_perfil()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Tu_perfil_Load(object sender, EventArgs e)
        {
            iniciarSesiónToolStripMenuItem.PerformClick();
            FileInfo fileInfo = new FileInfo(Application.StartupPath+@"\See More\Inicios SeeMore\creaciones.txt");
            long b = fileInfo.Length;
            if(b >= 10485760)
            {
                if (MessageBox.Show("Se ha encontrado que el archivo donde creo usuarios ha superado su tamaño, ¿Desea Borrar?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    StreamWriter creador = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\creaciones.txt");
                    creador.Flush(); creador.Close();
                }
                else
                {
                    MessageBox.Show("Ha cancelado la operación", "Cancelo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + ".txt";
                rtxHistorialUsuario.SaveFile(ruta, RichTextBoxStreamType.PlainText);
                rtxHistorialUsuario.LoadFile(ruta, RichTextBoxStreamType.PlainText);          
        }
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entraSINO = false;
            lblInfoImagen.Visible = false;
            lblNombreUsuario.Visible = false;
            lblContraseña.Visible = false;
            txtUsuario.Visible = false;
            txtContraseña.Visible = false;
            txtConfirmarContraseña.Visible = false;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmarContraseña.Text = "";
            Iniciar_Sesion frm = new Iniciar_Sesion();
            frm.ShowDialog(); 
                try
                {
                    if (Configuracion.DatosUsuario.Usuario != null)
                    {
                        lblSeries.Visible = true;
                        txtSeries.Visible = true;
                        actualizarPerfilToolStripMenuItem.Enabled = false;
                        mostrarAnimesVistosToolStripMenuItem.Enabled = true;
                        cerrarSesiónToolStripMenuItem.Enabled = true;
                        StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                        sw5.Flush(); sw5.Close();
                        StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                        sw6.Flush(); sw6.Close();
                        StreamWriter sw7 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
                        sw7.Flush(); sw7.Close();
                        sw1 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                        string result = string.Empty;
                        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(Configuracion.DatosUsuario.Usuario);
                        result = Convert.ToBase64String(encryted);
                        sw1.WriteLine(result);
                        sw1.Close();
                        sw2 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                        string resultado = string.Empty;
                        byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(Configuracion.DatosUsuario.Contraseña);
                        resultado = Convert.ToBase64String(encriptar);
                        sw2.WriteLine(resultado);
                        sw2.Close();
                        sw3 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
                        sw3.WriteLine(Configuracion.DatosUsuario.Imagen);
                        sw3.Close();
                        if (Configuracion.DatosUsuario.Sexo == "Hombre")
                        {
                            genero = "Hombre";
                            this.Text = "Bienvenido - " + Configuracion.DatosUsuario.Usuario;
                        }
                        if (Configuracion.DatosUsuario.Sexo == "Mujer")
                        {
                            genero = "Mujer";
                            this.Text = "Bienvenida - " + Configuracion.DatosUsuario.Usuario;
                        }
                        if(Configuracion.DatosUsuario.Sexo != "Hombre" && Configuracion.DatosUsuario.Sexo != "Mujer")
                        {
                            genero = Configuracion.DatosUsuario.Sexo;
                            this.Text = "Bienvenido/a - " + Configuracion.DatosUsuario.Usuario;
                        }
                        string res = string.Empty;
                        byte[] decryted = Convert.FromBase64String(Configuracion.DatosUsuario.Imagen);
                        res = System.Text.Encoding.Unicode.GetString(decryted);
                        picUsuario.Image = Image.FromFile(res);
                        picUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                        lblUsuario.Text = "Este es tu historial de videos - " + Configuracion.DatosUsuario.Usuario;
                        String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + ".txt";
                        rtxHistorialUsuario.LoadFile(ruta, RichTextBoxStreamType.PlainText);
                        if (rtxHistorialUsuario.Text == "")
                        {
                            rtxHistorialUsuario.Text = "Vaya, al parecer no has visto un video, aún";
                        }
                        guardarToolStripMenuItem.Enabled = true;
                        agregarImagenDeFondoToolStripMenuItem.Enabled = true;
                        editarPerfilToolStripMenuItem.Enabled = true;
                        iniciarSesiónToolStripMenuItem.Enabled = false;
                        String line;
                        StreamReader rd = null;
                        try
                        {
                            rd = new StreamReader(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Imagen.txt");
                            line = rd.ReadLine();
                            this.BackgroundImage = Image.FromFile(line);
                            this.BackgroundImageLayout = ImageLayout.Stretch;
                            rd.Close();
                        }
                        catch (Exception) { rd.Close(); }
                        finally { rd.Close(); }
                    }else
                        this.Close();
                }
                catch (Exception) { }         
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void agregarImagenDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de imagen jpg|*.jpg| Archivos de imagen png|*.png";
            abrir.FileName = "Imagenes";
            abrir.Title = "Imagen";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string direccion = abrir.FileName;
                this.BackgroundImage = Image.FromFile(abrir.FileName);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Imagen.txt");
                escribir.Flush(); escribir.Close();
                StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Imagen.txt");
                sw.WriteLine(direccion);
                sw.Close();
            }
        }
        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comprobar frm = new Comprobar();
            frm.ShowDialog();
                try
                {
                    if (Configuracion.DatosUsuario.Usuario != null)
                    {
                        entraSINO = true;
                        lblContraseña.Visible = true;
                        lblNombreUsuario.Visible = true;
                        lblConfirmarContraseña.Visible = true;
                        lblComprobacion.Text = "";
                        lblComprobacion.Visible = true;
                        txtUsuario.Visible = true;
                        txtContraseña.Visible = true;
                        txtConfirmarContraseña.Visible = true;
                        string imagen = string.Empty;
                        byte[] decryte = Convert.FromBase64String(Configuracion.DatosUsuario.Imagen);
                        imagen = System.Text.Encoding.Unicode.GetString(decryte);
                        picUsuario.Image = Image.FromFile(imagen);
                        picUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                        txtUsuario.Text = Configuracion.DatosUsuario.Usuario;
                        txtContraseña.Text = Configuracion.DatosUsuario.Contraseña;
                        txtConfirmarContraseña.Text = Configuracion.DatosUsuario.Contraseña;
                        if (Configuracion.DatosUsuario.Sexo == "Hombre")
                        {
                            this.Text = "Bienvenido - " + Configuracion.DatosUsuario.Usuario; lblUsuario.Text = "";
                        }
                        if (Configuracion.DatosUsuario.Sexo == "Mujer")
                        {
                            this.Text = "Bienvenida - " + Configuracion.DatosUsuario.Usuario; lblUsuario.Text = "";
                        }
                        if (Configuracion.DatosUsuario.Sexo != "Hombre" && Configuracion.DatosUsuario.Sexo != "Mujer")
                        {
                            this.Text = "Bienvenido/a - " + Configuracion.DatosUsuario.Usuario; lblUsuario.Text = "";
                        }
                        rtxHistorialUsuario.Text = "";
                        actualizarPerfilToolStripMenuItem.Enabled = true;
                        editarPerfilToolStripMenuItem.Enabled = false;
                        mostrarAnimesVistosToolStripMenuItem.Enabled = false;
                        guardarToolStripMenuItem.Enabled = false;
                        cerrarSesiónToolStripMenuItem.Enabled = false;
                        lblInfoImagen.Visible = true;
                    }
                }
                catch (Exception) { }          
        }
        private void actualizarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                try
                {
                    String[] users = File.ReadAllLines(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                    int tamaño = (users.Length * 4) / 4;
                    Configuracion.DatosInicioSesionTemp.TempNombre = new string[tamaño];
                    Configuracion.DatosInicioSesionTemp.TempContra = new string[tamaño];
                    Configuracion.DatosInicioSesionTemp.TempImagen = new string[tamaño];
                    Configuracion.DatosInicioSesionTemp.TempSexo = new string[tamaño];
                    int contador = 0;
                    foreach (String linea in users)
                    {
                        Configuracion.DatosInicioSesionAuto.Usuarios = linea.Split(';');
                        Configuracion.DatosInicioSesionTemp.TempNombre[contador] = Configuracion.DatosInicioSesionAuto.Usuarios[0];
                        Configuracion.DatosInicioSesionTemp.TempContra[contador] = Configuracion.DatosInicioSesionAuto.Usuarios[1];
                        Configuracion.DatosInicioSesionTemp.TempImagen[contador] = Configuracion.DatosInicioSesionAuto.Usuarios[2];
                        Configuracion.DatosInicioSesionTemp.TempSexo[contador] = Configuracion.DatosInicioSesionAuto.Usuarios[3];
                        if (usuarioAct != Configuracion.DatosInicioSesionTemp.TempNombre[contador])
                        {
                            StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
                            sw.WriteLine(Configuracion.DatosInicioSesionTemp.TempNombre[contador] + ";" + Configuracion.DatosInicioSesionTemp.TempContra[contador] + ";" + Configuracion.DatosInicioSesionTemp.TempImagen[contador] + ";" + Configuracion.DatosInicioSesionTemp.TempSexo[contador]);
                            sw.Close();
                        }
                        contador += 1;
                    }
                    string result = string.Empty;
                    if (imagenPerfil != "")
                    {
                        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(imagenPerfil);
                        result = Convert.ToBase64String(encryted);
                    }
                    else
                    {
                        result = imagenSinConexion.Trim();
                    }
                    string resul = string.Empty;
                    byte[] encryte = System.Text.Encoding.Unicode.GetBytes(txtContraseña.Text);
                    resul = Convert.ToBase64String(encryte);
                    StreamWriter sw2 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
                    sw2.WriteLine(txtUsuario.Text.Trim() + ";" + resul.Trim() + ";" + result.Trim() + ";" + genero.Trim());
                    sw2.Close();
                    StreamWriter sw3 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\actualizaciones.txt");
                    sw3.WriteLine(txtUsuario.Text.Trim() + ";" + txtContraseña.Text.Trim() + ";" + result.Trim() + ";" + genero.Trim());
                    sw3.Close();
                    String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + ".txt";
                        String ruta2 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Imagen.txt";
                        String ruta3 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Busqueda.txt";
                        String ruta4 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Animes.txt";
                        String ruta5 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Inte.txt";
                        String ruta6 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Ruta.txt";
                        if (File.Exists(ruta) && File.Exists(ruta2) && File.Exists(ruta3) && File.Exists(ruta4) && File.Exists(ruta5) && File.Exists(ruta6))
                        {
                            if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + ".txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Imagen.txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Busqueda.txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Animes.txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Inte.txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Ruta.txt"))
                            {
                                File.Move(ruta, Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + ".txt");
                                File.Move(ruta2, Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Imagen.txt");
                                File.Move(ruta3, Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Busqueda.txt");
                                File.Move(ruta4, Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Animes.txt");
                                File.Move(ruta5, Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Inte.txt");
                                File.Move(ruta6, Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Ruta.txt");
                            }
                        }
                        File.Delete(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                        File.Move(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt", Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                        if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt"))
                        {
                            File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
                        }
                        MessageBox.Show("Se ha actualizado el usuario, ingrese sesión de nuevo");
                        cerrarSesiónToolStripMenuItem.Enabled = true;
                        cerrarSesiónToolStripMenuItem.PerformClick();
                        cerrarSesiónToolStripMenuItem.Enabled = false;
                        iniciarSesiónToolStripMenuItem.PerformClick();
                    }
                    catch (Exception) {
                        MessageBox.Show("Ha ocurrido un error al intentar actualizar el usuario");
                    }
            }           
        }
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
        }
        StreamWriter escritor;
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)(Keys.Enter))
            {
                if (txtSeries.Text != "")
                {
                    Program.Displaynotify(txtSeries.Text);
                    escritor = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Animes.txt");
                    escritor.WriteLine(txtSeries.Text);
                    escritor.Close();
                    txtSeries.Clear();
                }
            }   
        }
        private void mostrarAnimesVistosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (regresarHistorial == true)
            {
                lblUsuario.Text = "Estos son las series vistas - " + Configuracion.DatosUsuario.Usuario;
                String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + "Animes.txt";
                rtxHistorialUsuario.LoadFile(ruta, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false;
                mostrarAnimesVistosToolStripMenuItem.Text = "Regresar al historial";
                regresarHistorial = false;
            }
            else
            {
                lblUsuario.Text = "Este es tu historial de videos - " + Configuracion.DatosUsuario.Usuario;
                String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosUsuario.Usuario + ".txt";
                rtxHistorialUsuario.LoadFile(ruta, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = true;
                mostrarAnimesVistosToolStripMenuItem.Text = "Mostrar Animes vistos";
                regresarHistorial = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (entraSINO == true)
            {
                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "Archivos de imagen jpg|*.jpg| Archivos de imagen png|*.png";
                abrir.FileName = "Imagenes";
                abrir.Title = "Imagen";
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    rutadeImagen = abrir.FileName;
                    imagenPerfil = rutadeImagen;
                    picUsuario.Image = Image.FromFile(rutadeImagen);
                    //pictureBox1.ImageLayout = ImageLayout.Stretch;
                }
            }
        }
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                lblComprobacion.Text = "La contraseña es igual";
            }
            else
            {
                lblComprobacion.Text = "La contraseña no es igual";
            }
        }
        private void rtxHistorialUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarToolStripMenuItem.Enabled = false;
            agregarImagenDeFondoToolStripMenuItem.Enabled = false;
            editarPerfilToolStripMenuItem.Enabled = false;
            actualizarPerfilToolStripMenuItem.Enabled = false;
            mostrarAnimesVistosToolStripMenuItem.Enabled = false;
            cerrarSesiónToolStripMenuItem.Enabled = false;
            iniciarSesiónToolStripMenuItem.Enabled = true;
            if (picUsuario.Image != null)
            {
                picUsuario.Image.Dispose();
                picUsuario.Image = null;
            }
            lblUsuario.Text = "";
            this.Text = "";
            rtxHistorialUsuario.Text = "";
            lblInfoImagen.Visible = false;
            lblNombreUsuario.Visible = false;
            lblContraseña.Visible = false;
            lblSeries.Visible = false;
            lblConfirmarContraseña.Visible = false;
            lblComprobacion.Visible = false;
            txtUsuario.Visible = false;
            txtContraseña.Visible = false;
            txtConfirmarContraseña.Visible = false;
            txtSeries.Visible = false;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmarContraseña.Text = "";
            this.BackgroundImage = null;
            Configuracion.DatosUsuario.Usuario = "";
            Configuracion.DatosUsuario.Contraseña = "";
            Configuracion.DatosUsuario.Sexo = "";
            Configuracion.DatosUsuario.Imagen = "";
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
            sw.Flush(); sw.Close();
            StreamWriter sw2 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
            sw2.Flush(); sw2.Close();
            StreamWriter sw3 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
            sw3.Flush(); sw3.Close();
        }
    }
}
