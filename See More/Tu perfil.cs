using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MODELOS_SEEMORE;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Tu_perfil : Form
    {
        public Cuenta usuarioActual { get; set; }
        public String Usuario1 { get; set; }
        public String Imagen1 { get; set; }
        public String Sexo1 { get; set; }
        public String Contraseña1 { get; set; }
        Boolean entraSINO = false;
        StreamWriter sw1 = null, sw2 = null;
        String genero = "";
        String usuarioAct;
        String imagenConConexion;
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
                String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + ".txt";
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
            if(Configuracion.existeConexion)
            {
                try
                {
                    if (frm.usuarioSeleccionado != null)
                    {
                        usuarioActual = frm.usuarioSeleccionado;
                        lblSeries.Visible = true;
                        txtSeries.Visible = true;
                        actualizarPerfilToolStripMenuItem.Enabled = false;
                        mostrarAnimesVistosToolStripMenuItem.Enabled = true;
                        cerrarSesiónToolStripMenuItem.Enabled = true;
                        StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                        sw5.Flush(); sw5.Close();
                        StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                        sw6.Flush(); sw6.Close();
                        sw1 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                        string result = string.Empty;
                        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(frm.usuarioSeleccionado.usuario);
                        result = Convert.ToBase64String(encryted);
                        sw1.WriteLine(result);
                        sw1.Close();
                        sw2 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                        string resultado = string.Empty;
                        byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(frm.usuarioSeleccionado.contraseña);
                        resultado = Convert.ToBase64String(encriptar);
                        sw2.WriteLine(resultado);
                        sw2.Close();
                        if (frm.usuarioSeleccionado.genero == "Hombre")
                        {
                            genero = "Hombre";
                            //MessageBox.Show("Bienvenido " + frm.usuarioSeleccionado.usuario);
                            this.Text = "Bienvenido - " + frm.usuarioSeleccionado.usuario;
                        }
                        if (frm.usuarioSeleccionado.genero == "Mujer")
                        {
                            genero = "Mujer";
                            //MessageBox.Show("Bienvenida " + frm.usuarioSeleccionado.usuario);
                            this.Text = "Bienvenida - " + frm.usuarioSeleccionado.usuario;
                        }
                        if (frm.usuarioSeleccionado.genero != "Hombre" && frm.usuarioSeleccionado.genero != "Mujer")
                        {
                            genero = frm.usuarioSeleccionado.genero;
                            //MessageBox.Show("Bienvenido/a " + frm.usuarioSeleccionado.genero);
                            this.Text = "Bienvenido/a - " + frm.usuarioSeleccionado.usuario;
                        }
                        string res = string.Empty;
                        byte[] decryted = Convert.FromBase64String(frm.usuarioSeleccionado.imagen);
                        res = System.Text.Encoding.Unicode.GetString(decryted);
                        picUsuario.Image = Image.FromFile(res);
                        picUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                        lblUsuario.Text = "Este es tu historial de videos - " + frm.usuarioSeleccionado.usuario;
                        String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + ".txt";
                        rtxHistorialUsuario.LoadFile(ruta, RichTextBoxStreamType.PlainText);
                        if (rtxHistorialUsuario.Text == "")
                        {
                            rtxHistorialUsuario.Text = "Vaya, al parecer no has visto un video, aún";
                        }
                        guardarToolStripMenuItem.Enabled = true;
                        agregarImagenDeFondoToolStripMenuItem.Enabled = true;
                        editarPerfilToolStripMenuItem.Enabled = true;
                        iniciarSesiónToolStripMenuItem.Enabled = false;
                        String line; StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Imagen.txt");
                        try
                        {
                            line = rd.ReadLine();
                            this.BackgroundImage = Image.FromFile(line);
                            this.BackgroundImageLayout = ImageLayout.Stretch;
                            rd.Close();
                        }
                        catch (Exception) { rd.Close(); }
                        finally { rd.Close(); }
                    }
                }
                catch (Exception) { }
            }  
            else
            {
                try
                {
                    if (frm.Usuario != null)
                    {
                        Usuario1 = frm.Usuario;
                        usuarioAct = frm.Usuario;
                        Imagen1 = frm.Imagen;
                        Sexo1 = frm.Sexo;
                        Contraseña1 = frm.Contraseña;
                        lblSeries.Visible = true;
                        txtSeries.Visible = true;
                        actualizarPerfilToolStripMenuItem.Enabled = false;
                        mostrarAnimesVistosToolStripMenuItem.Enabled = true;
                        cerrarSesiónToolStripMenuItem.Enabled = true;
                        StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                        sw5.Flush(); sw5.Close();
                        StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                        sw6.Flush(); sw6.Close();
                        sw1 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                        string result = string.Empty;
                        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(frm.Usuario);
                        result = Convert.ToBase64String(encryted);
                        sw1.WriteLine(result);
                        sw1.Close();
                        sw2 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                        string resultado = string.Empty;
                        byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(frm.Contraseña);
                        resultado = Convert.ToBase64String(encriptar);
                        sw2.WriteLine(resultado);
                        sw2.Close();
                        if (frm.Sexo == "Hombre")
                        {
                            genero = "Hombre";
                            //MessageBox.Show("Bienvenido " + frm.Usuario);
                            this.Text = "Bienvenido - " + frm.Usuario;
                        }
                        if (frm.Sexo == "Mujer")
                        {
                            genero = "Mujer";
                            //MessageBox.Show("Bienvenida " + frm.Usuario);
                            this.Text = "Bienvenida - " + frm.Usuario;
                        }
                        if(frm.Sexo != "Hombre" && frm.Sexo != "Mujer")
                        {
                            genero = frm.Sexo;
                            //MessageBox.Show("Bienvenido/a " + frm.Sexo);
                            this.Text = "Bienvenido/a - " + frm.Usuario;
                        }
                        string res = string.Empty;
                        byte[] decryted = Convert.FromBase64String(frm.Imagen);
                        res = System.Text.Encoding.Unicode.GetString(decryted);
                        picUsuario.Image = Image.FromFile(res);
                        picUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                        lblUsuario.Text = "Este es tu historial de videos - " + frm.Usuario;
                        String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + ".txt";
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
                            rd = new StreamReader(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Imagen.txt");
                            line = rd.ReadLine();
                            this.BackgroundImage = Image.FromFile(line);
                            this.BackgroundImageLayout = ImageLayout.Stretch;
                            rd.Close();
                        }
                        catch (Exception) { rd.Close(); }
                        finally { rd.Close(); }
                    }
                }
                catch (Exception) { }
            }           
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void agregarImagenDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rd = new StreamReader(@"C:\Users\" + Configuracion.UsuarioActual + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Imagen.txt"); rd.Close();
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de imagen jpg|*.jpg| Archivos de imagen png|*.png";
            abrir.FileName = "Imagenes";
            abrir.Title = "Imagen";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string direccion = abrir.FileName;
                this.BackgroundImage = Image.FromFile(abrir.FileName);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Imagen.txt");
                escribir.Flush(); escribir.Close();
                StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Imagen.txt");
                sw.WriteLine(direccion);
                sw.Close();
            }
        }
        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comprobar frm = new Comprobar();
            frm.ShowDialog();
            if(frm.usuarioSeleccionado != null)
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
                usuarioActual = frm.usuarioSeleccionado;
                string res = string.Empty;
                byte[] decryted = Convert.FromBase64String(frm.usuarioSeleccionado.imagen);
                res = System.Text.Encoding.Unicode.GetString(decryted);
                picUsuario.Image = Image.FromFile(res);
                picUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                imagenConConexion = frm.usuarioSeleccionado.imagen;
                txtUsuario.Text = frm.usuarioSeleccionado.usuario;
                txtContraseña.Text = frm.usuarioSeleccionado.contraseña;
                txtConfirmarContraseña.Text = frm.usuarioSeleccionado.contraseña;
                if (frm.usuarioSeleccionado.genero == "Hombre")
                {
                    this.Text = "Bienvenido - " + frm.usuarioSeleccionado.usuario; lblUsuario.Text = "";
                }
                if (frm.usuarioSeleccionado.genero == "Mujer")
                {
                    this.Text = "Bienvenida - " + frm.usuarioSeleccionado.usuario; lblUsuario.Text = "";
                }
                if(frm.usuarioSeleccionado.genero != "Hombre" && frm.usuarioSeleccionado.genero != "Mujer")
                {
                    this.Text = "Bienvenido/a - " + frm.usuarioSeleccionado.usuario; lblUsuario.Text = "";
                }
                rtxHistorialUsuario.Text = "";
                actualizarPerfilToolStripMenuItem.Enabled = true;
                editarPerfilToolStripMenuItem.Enabled = false;
                mostrarAnimesVistosToolStripMenuItem.Enabled = false;
                guardarToolStripMenuItem.Enabled = false;
                cerrarSesiónToolStripMenuItem.Enabled = false;
                lblInfoImagen.Visible = true;
            }
            else
            {
                try
                {
                    if (frm.Usuario != null)
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
                        Usuario1 = frm.Usuario;
                        Imagen1 = frm.Imagen;
                        imagenSinConexion = frm.Imagen;
                        Sexo1 = frm.Sexo;
                        Contraseña1 = frm.Contraseña;
                        string imagen = string.Empty;
                        byte[] decryte = Convert.FromBase64String(frm.Imagen);
                        imagen = System.Text.Encoding.Unicode.GetString(decryte);
                        picUsuario.Image = Image.FromFile(imagen);
                        picUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                        txtUsuario.Text = frm.Usuario;
                        txtContraseña.Text = frm.Contraseña;
                        txtConfirmarContraseña.Text = frm.Contraseña;
                        if (frm.Sexo == "Hombre")
                        {
                            this.Text = "Bienvenido - " + frm.Usuario; lblUsuario.Text = "";
                        }
                        if (frm.Sexo == "Mujer")
                        {
                            this.Text = "Bienvenida - " + frm.Usuario; lblUsuario.Text = "";
                        }
                        if (frm.Sexo != "Hombre" && frm.Sexo != "Mujer")
                        {
                            this.Text = "Bienvenido/a - " + frm.Usuario; lblUsuario.Text = "";
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
        }
        private void actualizarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                if(Configuracion.existeConexion)
                {
                    Cuenta cuenta = new Cuenta();
                    cuenta.usuario = txtUsuario.Text.Trim();
                    cuenta.contraseña = txtContraseña.Text.Trim();
                    if (imagenPerfil != "")
                    {
                        string result = string.Empty;
                        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(imagenPerfil);
                        result = Convert.ToBase64String(encryted);
                        cuenta.imagen = result.Trim();
                    }
                    else
                    {
                        cuenta.imagen = imagenConConexion.Trim();
                    }
                    cuenta.genero = genero.Trim();
                    cuenta.ID = usuarioActual.ID;
                    String[] users = File.ReadAllLines(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                    int tamaño = (users.Length * 4) / 4;
                    Configuracion.TempNombre = new string[tamaño];
                    Configuracion.TempContra = new string[tamaño];
                    Configuracion.TempImagen = new string[tamaño];
                    Configuracion.TempSexo = new string[tamaño];
                    int contador = 0;
                    foreach (String linea in users)
                    {
                        Configuracion.Usuarios = linea.Split(';');
                        Configuracion.TempNombre[contador] = Configuracion.Usuarios[0];
                        Configuracion.TempContra[contador] = Configuracion.Usuarios[1];
                        Configuracion.TempImagen[contador] = Configuracion.Usuarios[2];
                        Configuracion.TempSexo[contador] = Configuracion.Usuarios[3];
                        if (usuarioAct != Configuracion.TempNombre[contador])
                        {
                            StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
                            sw.WriteLine(Configuracion.TempNombre[contador] + ";" + Configuracion.TempContra[contador] + ";" + Configuracion.TempImagen[contador] + ";" + Configuracion.TempSexo[contador]);
                            sw.Close();
                        }
                        contador += 1;
                    }
                    string res = string.Empty;
                    byte[] enc = System.Text.Encoding.Unicode.GetBytes(imagenPerfil);
                    res = Convert.ToBase64String(enc);
                    string resul = string.Empty;
                    byte[] encryte = System.Text.Encoding.Unicode.GetBytes(txtContraseña.Text);
                    resul = Convert.ToBase64String(encryte);
                    StreamWriter sw2 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
                    sw2.WriteLine(txtUsuario.Text.Trim() + ";" + resul.Trim() + ";" + res.Trim() + ";" + genero.Trim());
                    sw2.Close();
                    String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + ".txt";
                    String ruta2 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Imagen.txt";
                    String ruta3 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Busqueda.txt";
                    String ruta4 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Animes";
                    String ruta5 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Inte";
                    String ruta6 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Ruta";
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
                    if (CuentaSeeMore.actualizarC(cuenta) > 0)
                    {
                        MessageBox.Show("Se ha actualizado el usuario, por favor ingrese de nuevo");
                        cerrarSesiónToolStripMenuItem.Enabled = true;
                        cerrarSesiónToolStripMenuItem.PerformClick();
                        cerrarSesiónToolStripMenuItem.Enabled = false;
                        iniciarSesiónToolStripMenuItem.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error");
                    }
                }
                else {
                    try
                    {
                        String[] users = File.ReadAllLines(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                        int tamaño = (users.Length * 4) / 4;
                        Configuracion.TempNombre = new string[tamaño];
                        Configuracion.TempContra = new string[tamaño];
                        Configuracion.TempImagen = new string[tamaño];
                        Configuracion.TempSexo = new string[tamaño];
                        int contador = 0;
                        foreach (String linea in users)
                        {
                            Configuracion.Usuarios = linea.Split(';');
                            Configuracion.TempNombre[contador] = Configuracion.Usuarios[0];
                            Configuracion.TempContra[contador] = Configuracion.Usuarios[1];
                            Configuracion.TempImagen[contador] = Configuracion.Usuarios[2];
                            Configuracion.TempSexo[contador] = Configuracion.Usuarios[3];
                            if(usuarioAct != Configuracion.TempNombre[contador])
                            {
                                StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
                                sw.WriteLine(Configuracion.TempNombre[contador] + ";" + Configuracion.TempContra[contador] + ";" + Configuracion.TempImagen[contador] + ";" + Configuracion.TempSexo[contador]);
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
                        String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + ".txt";
                        String ruta2 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Imagen.txt";
                        String ruta3 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Busqueda.txt";
                        String ruta4 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Animes";
                        String ruta5 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Inte";
                        String ruta6 = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Ruta";
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
                    escritor = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.nombre + "Animes.txt");
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
                lblUsuario.Text = "Estos son las series vistas - " + Configuracion.usuario;
                String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt";
                rtxHistorialUsuario.LoadFile(ruta, RichTextBoxStreamType.PlainText);
                guardarToolStripMenuItem.Enabled = false;
                mostrarAnimesVistosToolStripMenuItem.Text = "Regresar al historial";
                regresarHistorial = false;
            }
            else
            {
                lblUsuario.Text = "Este es tu historial de videos - " + Configuracion.usuario;
                String ruta = Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + ".txt";
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
            Configuracion.usuario = "";
            Configuracion.contraseña = "";
            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
            sw.Flush(); sw.Close();
            StreamWriter sw2 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
            sw2.Flush(); sw2.Close();
        }
    }
}
