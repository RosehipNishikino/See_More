using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DATOS_SEEMORE;
using WMPLib;

namespace See_More
{
    public partial class Buscar : Form
    {
        public IWMPPlaylist datos { get; set; }
        Boolean esUnico = true;
        StreamWriter sw1, sw2, sw3;
        Boolean esApartado = false;
        String oracion = @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos";
        String texto;
        String ultimarutavista = string.Empty;
        String rutaCamino = string.Empty;
        String[] animesVis;
        int tamaño, opcion = 3, left = 0, top = 45, cuentaCarpetas = 0, cuentas = 0;
        Boolean buscar = false, buscarListas = false, buscarApartado = false, hayAnimes = false, seleccion = false, aceptar = false;
        string decision = "";
        Button carpeta, archivo;
        AxWMPLib.AxWindowsMediaPlayer player = new AxWMPLib.AxWindowsMediaPlayer();
        WMPLib.IWMPPlaylist playlist;
        WMPLib.IWMPMedia media;
        public Buscar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            String line, leni;
            player.CreateControl();
            player.settings.setMode("loop", false);
            playlist = player.playlistCollection.newPlaylist("List");
            if (Configuracion.usuario != "" && Configuracion.contraseña != "")
            {
                txtUsuario.Text = Configuracion.usuario;
                txtContraseña.Text = Configuracion.contraseña;
                try
                {
                    StreamReader rdUsuario = new StreamReader(Application.StartupPath+@"\See More\Usuarios SeeMore\" + Configuracion.usuario+"Busqueda.txt");
                    leni = rdUsuario.ReadLine();
                    txtNombreSerie.Text = leni;
                    rdUsuario.Close();
                }
                catch (Exception) { }
            }
            else
            {
                lblUsuario.Visible = true;
                lblContraseña.Visible = true;
                txtUsuario.Visible = true;
                txtContraseña.Visible = true;
                regresarALaCarpetaAnteriorToolStripMenuItem.Enabled = false;
                regresarARaizToolStripMenuItem.Enabled = false;
            }
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath+@"\See More\Configuraciones SeeMore\buscar.txt");
                line = rd.ReadLine(); 
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
                pnlRespaldo.Visible = true;
                regresarARaizToolStripMenuItem.Visible = true;
                regresarALaCarpetaAnteriorToolStripMenuItem.Visible = true;
                lblCreacionApartado.Visible = false;
                lblApartado.Visible = false;
                lblApartadoE.Visible = false;
                lblNombreApar.Visible = false;
                lblSerie.Visible = false;
                lblDatoInfo.Visible = false;
                txtCrearApartado.Visible = false;
                txtBuscarApartado.Visible = false;
                txtNombreApartado.Visible = false;
                txtSerie.Visible = false;
                lblFiltros.Visible = true;
                cboFiltros.Visible = true;
                pnlRespaldo.Controls.Clear();
                pnlRespaldo.AutoScroll = true;
                tmrRefresco.Start();
                try
                {
                    String camino = string.Empty;
                    String[] ruta = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\"+Configuracion.usuario+"Ruta.txt");
                    //Posible eliminacion
                    String[] animesVistos = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                    animesVis = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                    String[] caminos = new string[1]; String[] separar;
                    try
                    {
                        if(animesVistos[0] != null && animesVis[0] != null) { hayAnimes = true; }
                    }
                    catch (Exception) { hayAnimes = false; }
                    foreach(String linea in ruta)
                    {
                        separar = linea.Split(';');
                        caminos[0] = separar[0];
                    }
                    if (caminos[0] == null)
                    {     
                        camino = @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos";
                        rutaCamino = camino;
                    }
                    else
                    {
                        camino = caminos[0];
                        rutaCamino = camino;
                    }
                    ultimarutavista = camino;
                    DirectoryInfo directory = new DirectoryInfo(camino);
                    FileInfo[] files = directory.GetFiles("*.mp4");
                    DirectoryInfo[] directories = directory.GetDirectories();
                    DirectoryInfo[] directorios = RevisarDirectorio(directories);
                    IteracionCarpetas(directorios.Length, directorios);
                    IterarVideos(files.Length, files);
                }
                catch (Exception) { }
        }
        
        private void mousemove(object mouse, MouseEventArgs args)
        {
            ((Button)mouse).BackColor = Color.Silver;
        }
        private void mouseleave(object mouse, EventArgs args)
        {
            ((Button)mouse).BackColor = Color.DarkGray;
        }
        private void click_de_boton(object boton, EventArgs args)
        {
            pnlRespaldo.Controls.Clear();
            animesVis = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
            try
            {
                texto = ((Button)boton).Text;
                for (int j = 0; j < 1; j++)
                {
                        rutaCamino = rutaCamino + @"\" + texto;
                        ultimarutavista = rutaCamino;
                }
                DirectoryInfo directory = new DirectoryInfo(rutaCamino);
                FileInfo[] files = directory.GetFiles("*.mp4");
                DirectoryInfo[] directories = directory.GetDirectories();
                DirectoryInfo[] directorios = RevisarDirectorio(directories);
                IteracionCarpetas(directorios.Length, directorios);
                IterarVideos(files.Length, files);
            }
            catch (Exception) { }
        }
        private void click_de_boton2(object boton, EventArgs args)
        {
            if (seleccion)
            {
                media = player.newMedia(((Button)boton).Name);
                playlist.appendItem(media);
                if (aceptar)
                {
                    Boolean sinCoencidencia = false;
                    for (int j = 0; j < tamaño; j++)
                    {
                        string res = string.Empty;
                        byte[] decryted = Convert.FromBase64String(Configuracion.UsuariosContra[j]);
                        res = System.Text.Encoding.Unicode.GetString(decryted);
                        if (Configuracion.UsuariosNombre[j] == txtUsuario.Text && res == txtContraseña.Text)
                        {
                            sinCoencidencia = true;
                            Configuracion.BuscarAddon.UsuarioRegistrado = Configuracion.UsuariosNombre[j];
                            Configuracion.BuscarAddon.UsuarioImagen = Configuracion.UsuariosImagen[j];
                            datos = playlist;
                            Configuracion.BuscarAddon.IsOnly = false;
                            Configuracion.nombre = txtUsuario.Text;
                            Configuracion.usuario = txtUsuario.Text;
                            Configuracion.contraseña = txtContraseña.Text;
                            string resulta = string.Empty;
                            byte[] desin = Convert.FromBase64String(Configuracion.UsuariosImagen[j]);
                            resulta = System.Text.Encoding.Unicode.GetString(desin);
                            Configuracion.imagen = resulta;
                            StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                            sw5.Flush(); sw5.Close();
                            StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                            sw6.Flush(); sw6.Close();
                            StreamWriter sw7 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
                            sw7.Flush(); sw7.Close();
                            sw1 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                            string result = string.Empty;
                            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtUsuario.Text);
                            result = Convert.ToBase64String(encryted);
                            sw1.WriteLine(result);
                            sw1.Close();
                            sw2 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                            string resultado = string.Empty;
                            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(txtContraseña.Text);
                            resultado = Convert.ToBase64String(encriptar);
                            sw2.WriteLine(resultado);
                            sw2.Close();
                            sw3 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
                            sw3.WriteLine(Configuracion.UsuariosImagen[j]);
                            sw3.Close();
                            StreamWriter ultimaruta = new StreamWriter(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Ruta.txt");
                            ultimaruta.Flush(); ultimaruta.Close();
                            StreamWriter ultimaruta2 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Ruta.txt");
                            ultimaruta2.WriteLine(ultimarutavista + ";"); ultimaruta2.Close();
                            this.Close();
                            break;
                        }
                    }
                    if (sinCoencidencia == false)
                    {
                        MessageBox.Show("El Usuario y/o Contraseña estan mal, intente de nuevo");
                        lblIniciarSesion.Visible = true;
                        lblUsuario.Visible = true;
                        lblContraseña.Visible = true;
                        txtUsuario.Visible = true;
                        txtContraseña.Visible = true;
                    }
                }
            }
            else
            {
                Boolean sinCoencidencia = false;

                for (int j = 0; j < tamaño; j++)
                {
                    string res = string.Empty;
                    byte[] decryted = Convert.FromBase64String(Configuracion.UsuariosContra[j]);
                    res = System.Text.Encoding.Unicode.GetString(decryted);
                    if (Configuracion.UsuariosNombre[j] == txtUsuario.Text && res == txtContraseña.Text)
                    {
                        sinCoencidencia = true;
                        Configuracion.BuscarAddon.UsuarioRegistrado = Configuracion.UsuariosNombre[j];
                        Configuracion.BuscarAddon.UsuarioImagen = Configuracion.UsuariosImagen[j];
                        Configuracion.BuscarAddon.NombreVideo = ((Button)boton).Text;
                        Configuracion.BuscarAddon.RutaVideo = ((Button)boton).Name;
                        Configuracion.BuscarAddon.IsOnly = true;
                        Configuracion.nombre = txtUsuario.Text;
                        Configuracion.usuario = txtUsuario.Text;
                        Configuracion.contraseña = txtContraseña.Text;
                        string resulta = string.Empty;
                        byte[] desin = Convert.FromBase64String(Configuracion.UsuariosImagen[j]);
                        resulta = System.Text.Encoding.Unicode.GetString(desin);
                        Configuracion.imagen = resulta;
                        StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                        sw5.Flush(); sw5.Close();
                        StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                        sw6.Flush(); sw6.Close();
                        StreamWriter sw7 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
                        sw7.Flush(); sw7.Close();
                        sw1 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                        string result = string.Empty;
                        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtUsuario.Text);
                        result = Convert.ToBase64String(encryted);
                        sw1.WriteLine(result);
                        sw1.Close();
                        sw2 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                        string resultado = string.Empty;
                        byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(txtContraseña.Text);
                        resultado = Convert.ToBase64String(encriptar);
                        sw2.WriteLine(resultado);
                        sw2.Close();
                        sw3 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
                        sw3.WriteLine(Configuracion.UsuariosImagen[j]);
                        sw3.Close();
                        StreamWriter ultimaruta = new StreamWriter(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Ruta.txt");
                        ultimaruta.Flush(); ultimaruta.Close();
                        StreamWriter ultimaruta2 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Ruta.txt");
                        ultimaruta2.WriteLine(ultimarutavista + ";"); ultimaruta2.Close();
                        this.Close();
                        break;
                    }
                }
                if (sinCoencidencia == false)
                {
                    MessageBox.Show("El Usuario y/o Contraseña estan mal, intente de nuevo");
                    lblIniciarSesion.Visible = true;
                    lblUsuario.Visible = true;
                    lblContraseña.Visible = true;
                    txtUsuario.Visible = true;
                    txtContraseña.Visible = true;
                }
            }
        }
        private void Buscar_Load(object sender, EventArgs e)
        {
            String[] users = File.ReadAllLines(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
            tamaño = (users.Length * 4) / 4;
            int contador = 0;
            Configuracion.BuscarAddon.hayIntercambio = false;
            Configuracion.BuscarAddon.UsuarioTemporal = "";
            Configuracion.UsuariosNombre = new string[tamaño];
            Configuracion.UsuariosContra = new string[tamaño];
            Configuracion.UsuariosImagen = new string[tamaño];
            Configuracion.UsuariosSexo = new string[tamaño];
            foreach (String linea in users)
            {
                Configuracion.Usuarios = linea.Split(';');
                Configuracion.UsuariosNombre[contador] = Configuracion.Usuarios[0];
                Configuracion.UsuariosContra[contador] = Configuracion.Usuarios[1];
                Configuracion.UsuariosImagen[contador] = Configuracion.Usuarios[2];
                Configuracion.UsuariosSexo[contador] = Configuracion.Usuarios[3];
                contador += 1;
            }
        } 
        public void CargarDatos()
        {
            lblUsuario.Visible = false;
            lblContraseña.Visible = false;
            txtUsuario.Visible = false;
            txtContraseña.Visible = false;
            regresarALaCarpetaAnteriorToolStripMenuItem.Enabled = true;
            regresarARaizToolStripMenuItem.Enabled = true;
            StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
            sw5.Flush(); sw5.Close();
            StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
            sw6.Flush(); sw6.Close();
            StreamWriter sw7 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
            sw7.Flush(); sw7.Close();
            sw1 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(Configuracion.BuscarAddon.Usuario);
            result = Convert.ToBase64String(encryted);
            sw1.WriteLine(result);
            sw1.Close();
            sw2 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
            string resultado = string.Empty;
            byte[] encriptar = System.Text.Encoding.Unicode.GetBytes(Configuracion.BuscarAddon.Contraseña);
            resultado = Convert.ToBase64String(encriptar);
            sw2.WriteLine(resultado);
            sw2.Close();
            sw3 = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
            sw3.WriteLine(Configuracion.BuscarAddon.Imagen);
            sw3.Close();
            try
            {
                String camino = string.Empty;
                String[] ruta = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Ruta.txt");
                String[] animesVistos = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                animesVis = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                String[] caminos = new string[1]; String[] separar;
                try
                {
                    if (animesVistos[0] != null && animesVis[0] != null) { hayAnimes = true; }
                }
                catch (Exception) { hayAnimes = false; }
                foreach (String linea in ruta)
                {
                    separar = linea.Split(';');
                    caminos[0] = separar[0];
                }
                if (caminos[0] == null)
                {
                    camino = @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos";
                    rutaCamino = camino;
                }
                else
                {
                    camino = caminos[0];
                    rutaCamino = camino;
                }
                ultimarutavista = camino;
                DirectoryInfo directory = new DirectoryInfo(camino);
                FileInfo[] files = directory.GetFiles("*.mp4");
                DirectoryInfo[] directories = directory.GetDirectories();
                DirectoryInfo[] directorios = RevisarDirectorio(directories);
                IteracionCarpetas(directorios.Length, directorios);
                IterarVideos(files.Length, files);
            }
            catch (Exception) { }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Boolean sinCoencidencia = false;
                    for (int j = 0; j < tamaño; j++)
                    {
                        string res = string.Empty;
                        byte[] decryted = Convert.FromBase64String(Configuracion.UsuariosContra[j]);
                        res = System.Text.Encoding.Unicode.GetString(decryted);
                        if (Configuracion.UsuariosNombre[j] == txtUsuario.Text && res == txtContraseña.Text)
                        {
                            sinCoencidencia = true;
                            Configuracion.BuscarAddon.Usuario = Configuracion.UsuariosNombre[j];
                            Configuracion.BuscarAddon.Contraseña = res;
                            Configuracion.BuscarAddon.Imagen = Configuracion.UsuariosImagen[j];
                            Configuracion.BuscarAddon.Sexo = Configuracion.UsuariosSexo[j];
                            Configuracion.nombre = txtUsuario.Text;
                            Configuracion.usuario = txtUsuario.Text;
                            Configuracion.contraseña = txtContraseña.Text;
                            string resulta = string.Empty;
                            byte[] desin = Convert.FromBase64String(Configuracion.BuscarAddon.Imagen);
                            resulta = System.Text.Encoding.Unicode.GetString(desin);
                            Configuracion.imagen = resulta;
                            Configuracion.loCerroelUsuario = false;
                            CargarDatos();
                            break;
                        }
                    }
                    if (sinCoencidencia == false)
                    {
                        MessageBox.Show("El Usuario y/o Contraseña estan mal, intente de nuevo");
                    }
                }
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Boolean sinCoencidencia = false;
                    for (int j = 0; j < tamaño; j++)
                    {
                        string res = string.Empty;
                        byte[] decryted = Convert.FromBase64String(Configuracion.UsuariosContra[j]);
                        res = System.Text.Encoding.Unicode.GetString(decryted);
                        if (Configuracion.UsuariosNombre[j] == txtUsuario.Text && res == txtContraseña.Text)
                        {
                            sinCoencidencia = true;
                            Configuracion.BuscarAddon.Usuario = Configuracion.UsuariosNombre[j];
                            Configuracion.BuscarAddon.Contraseña = res;
                            Configuracion.BuscarAddon.Imagen = Configuracion.UsuariosImagen[j];
                            Configuracion.BuscarAddon.Sexo = Configuracion.UsuariosSexo[j];
                            Configuracion.nombre = txtUsuario.Text;
                            Configuracion.usuario = txtUsuario.Text;
                            Configuracion.contraseña = txtContraseña.Text;
                            string resulta = string.Empty;
                            byte[] desin = Convert.FromBase64String(Configuracion.BuscarAddon.Imagen);
                            resulta = System.Text.Encoding.Unicode.GetString(desin);
                            Configuracion.imagen = resulta;
                            Configuracion.loCerroelUsuario = false;
                            CargarDatos();
                            break;
                        }
                    }
                    if (sinCoencidencia == false)
                    {
                        MessageBox.Show("El Usuario y/o Contraseña estan mal, intente de nuevo");
                    }
                }
            }
        }

        private void regresarALaCarpetaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rutaCamino != @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos")
            {
                pnlRespaldo.Controls.Clear();
                animesVis = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                try
                {
                    String[] rutaCambio = rutaCamino.Split(new string[] { @"\" }, StringSplitOptions.None);
                    int vueltas = rutaCambio.Length;
                    String rutaTemp = "C:";
                    foreach (String rutas in rutaCambio)
                    {
                        if (rutas != "C:")
                            if (vueltas - 1 != 0)
                                rutaTemp += @"\" + rutas;
                        vueltas -= 1;
                    }
                    rutaCamino = rutaTemp;
                    DirectoryInfo directory = new DirectoryInfo(rutaCamino);
                    FileInfo[] files = directory.GetFiles("*.mp4");
                    DirectoryInfo[] directories = directory.GetDirectories();
                    DirectoryInfo[] directorios = RevisarDirectorio(directories);
                    IteracionCarpetas(directorios.Length, directorios);
                    IterarVideos(files.Length, files);

                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("Ya ha llegado a la carpeta raíz de los videos", "No se puede regresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void regresarARaizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRespaldo.Controls.Clear();
            rutaCamino = @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos";
            animesVis = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
            try
            {
                DirectoryInfo directory = new DirectoryInfo(@"C:\Users\" + Configuracion.UsuarioActual + @"\Videos");
                FileInfo[] files = directory.GetFiles("*.mp4");
                DirectoryInfo[] directories = directory.GetDirectories();
                DirectoryInfo[] directorios = RevisarDirectorio(directories);
                IteracionCarpetas(directorios.Length, directorios);
                IterarVideos(files.Length, files);
            }
            catch (Exception) { }
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            Configuracion.BuscarAddon.hayIntercambio = false;
                String[] users = File.ReadAllLines(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                tamaño = (users.Length * 4) / 4;
                int contador = 0;
                Configuracion.UsuariosNombre = new string[tamaño];
                Configuracion.UsuariosContra = new string[tamaño];
                Configuracion.UsuariosImagen = new string[tamaño];
                Configuracion.UsuariosSexo = new string[tamaño];
                foreach (String linea in users)
                {
                    //Aqui hay un error, tratar de no reescribir sobre el arreglo
                    Configuracion.Usuarios = linea.Split(';');
                    Configuracion.UsuariosNombre[contador] = Configuracion.Usuarios[0];
                    Configuracion.UsuariosContra[contador] = Configuracion.Usuarios[1];
                    Configuracion.UsuariosImagen[contador] = Configuracion.Usuarios[2];
                    Configuracion.UsuariosSexo[contador] = Configuracion.Usuarios[3];
                    contador += 1;
                }
                Boolean sinCoencidencia = false;
                for (int j = 0; j < tamaño; j++)
                {
                    string res = string.Empty;
                    byte[] decryted = Convert.FromBase64String(Configuracion.UsuariosContra[j]);
                    res = System.Text.Encoding.Unicode.GetString(decryted);
                    if (Configuracion.UsuariosNombre[j] == textBox2.Text && res == textBox1.Text)
                    {
                        sinCoencidencia = true;
                        MessageBox.Show("Procediendo a intercambio de información, puede continuar viendo videos");
                        Configuracion.BuscarAddon.UsuarioTemporal = textBox2.Text;
                        Configuracion.BuscarAddon.hayIntercambio = true;
                        break;
                    }
                }
                if (sinCoencidencia == false)
                {
                    MessageBox.Show("El Usuario y/o Contraseña estan mal, intente de nuevo");
                }
        }
        private void comoFuncionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La ventana Busca de See More cuenta con las siguientes opciones\n" +
                "1.- Busca todo el contenido escribiendo {all}\n" +
                "2.- Busca las series no vistas por el usuario escribiendo {s-n}\n" +
                "3.- Busca el nombre de una serie escribiendo {s} y luego escribiendo la serie a buscar\n" +
                "4.- Busca el último video guardado escribiendo {b-u}\n" +
                "5.- Busca todo el contenido, pero de forma ordenada escribiendo {o}\n" +
                "-----------------------------------------------\n" +
                "6.- Busca todas las listas escribiendo {all-l}\n" +
                "7.- Busca el nombre de la lista escribiendo {l-n} y luego escribiendo la lista a buscar\n" +
                "8.- Busca la última lista escribiendo {u-l}\n" +
                "-----------------------------------------------\n" +
                "9.- Para seleccionar varios videos oprima {t} luego oprima {r} para aceptar la lista\n" +
                "10.- Para deseleccionar los videos oprima {n}\n" + 
                "Para salir de los comandos presione {ESC}\n" +
                "                                                                                    See More.", "Ayuda de See More al usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }
        private void tmrRefresco_Tick(object sender, EventArgs e)
        {
            //pnlRespaldo.Refresh();
        }
        private void pnlRespaldo_Scroll(object sender, ScrollEventArgs e)
        {
            pnlRespaldo.BackColor = Color.Transparent;
        }
        private void txtNombreSerie_KeyUp(object sender, KeyEventArgs e)
        {
            if((e.KeyCode) == Keys.Enter)
            {
                decision = txtNombreSerie.Text;
                if(decision == "all")
                {
                        pnlRespaldo.Controls.Clear();
                        oracion = @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos";
                        animesVis = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                        try
                        {
                            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\" + Configuracion.UsuarioActual + @"\Videos");
                            FileInfo[] files = directory.GetFiles("*.mp4");
                            DirectoryInfo[] directories = directory.GetDirectories();
                            DirectoryInfo[] directorios = RevisarDirectorio(directories);
                            IteracionCarpetas(directorios.Length, directorios);
                            IterarVideos(files.Length, files);
                        }
                        catch (Exception) { }
                }
                if (decision == "open")
                {
                    OpenFileDialog abrir = new OpenFileDialog();
                    abrir.ValidateNames = false;
                    abrir.CheckFileExists = false;
                    abrir.CheckPathExists = true;
                    abrir.FileName = "Seleccionar carpeta videos";
                    DialogResult result = abrir.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        rutaCamino = Path.GetDirectoryName(abrir.FileName);
                        ultimarutavista = rutaCamino;
                        pnlRespaldo.Controls.Clear();
                        animesVis = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                        try
                        {
                            DirectoryInfo directory = new DirectoryInfo(rutaCamino);
                            FileInfo[] files = directory.GetFiles("*.mp4");
                            DirectoryInfo[] directories = directory.GetDirectories();
                            DirectoryInfo[] directorios = RevisarDirectorio(directories);
                            IteracionCarpetas(directorios.Length, directorios);
                            IterarVideos(files.Length, files);
                        }
                        catch (Exception) { }
                    }
                }
                if (decision == "s-n")
                {
                    MessageBox.Show("No es necesario efectuar este comando pues See More lo hace de forma automatica", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(decision == "b-u")
                {
                        MessageBox.Show("No podemos mostrarte la información del comando Buscar Último", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(decision == "o")
                {
                        MessageBox.Show("No puede mostrarte la información del comando Buscar por Orden", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(decision == "all-l")
                {
                        MessageBox.Show("SeeMore no puede mostrarte la información del comando Buscar Todas las Listas", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(decision == "u-l")
                {
                        MessageBox.Show("SeeMore no puede mostrarte la información del comando Buscar Última Lista", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(decision == "t")
                {
                    seleccion = true;
                }
                if(decision == "n")
                {
                    seleccion = false;
                }
                if(decision == "r")
                {
                    aceptar = true;
                }
                txtNombreSerie.Clear();
            }
            if ((e.KeyCode) == Keys.Escape)
            {
                decision = "";
                txtNombreSerie.Clear();
            } 
            else if(decision == "s")
            {
                    MessageBox.Show("No podemos mostrar información del comando Buscar Series", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscar = true;
                buscarListas = false;
                buscarApartado = false;
            } 
            if(decision == "l-n")
            {
                    MessageBox.Show("SeeMore no puede mostrar información del comando Buscar Nombre Lista", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlRespaldo.Controls.Clear();
            animesVis = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
            try
            {
                DirectoryInfo directory = new DirectoryInfo(rutaCamino);
                FileInfo[] files = directory.GetFiles("*."+cboFiltros.SelectedItem.ToString());
                DirectoryInfo[] directories = directory.GetDirectories();
                DirectoryInfo[] directorios = RevisarDirectorio(directories);
                IteracionCarpetas(directorios.Length, directorios);
                IterarVideos(files.Length, files);
            }
            catch (Exception) { }
        }
        //METODOS NUEVOS
        public DirectoryInfo[] RevisarDirectorio(DirectoryInfo[] directories)
        {
            int indice = 0, suma = 0;
            DirectoryInfo[] infos;
            try
            {
                for (int i = 0; i < directories.Length; i++)
                {
                    if (hayAnimes)
                    {
                        foreach (String linea in animesVis)
                        {
                            if (!((DirectoryInfo)directories[i]).Name.Contains(linea))
                            {
                                if (opcion == 3)
                                    opcion = 2;
                            }
                            else
                            {
                                if (opcion == 3)
                                    opcion = 1;
                                if (opcion == 2)
                                    opcion = 1;
                            }
                        }
                        if (opcion == 2)
                        {
                            suma += 1;
                        }
                        opcion = 3;
                    }
                }
                infos = new DirectoryInfo[suma];
                for (int i = 0; i < directories.Length; i++)
                {
                    if (hayAnimes)
                    {
                        foreach (String linea in animesVis)
                        {
                            if (!((DirectoryInfo)directories[i]).Name.Contains(linea))
                            {
                                if (opcion == 3)
                                    opcion = 2;
                            }
                            else
                            {
                                if (opcion == 3)
                                    opcion = 1;
                                if (opcion == 2)
                                    opcion = 1;
                            }
                        }
                        if (opcion == 2)
                        {
                            infos[indice] = directories[i];
                            indice += 1;
                        }
                        opcion = 3;
                    }
                }
                return infos;
            }
            catch (Exception) { }
            return null;
        }
        public void IteracionCarpetas(int n, DirectoryInfo[] directorios)
        {
            if (n != 0)
            {
                MostrarCarpetas(4, directorios);
                left = 0; top += 45;
                IteracionCarpetas(directorios.Length - cuentaCarpetas, directorios);
            }
            else
            {
                left = 0; top += 45; cuentaCarpetas = 0;
                return;
            }
        }
        public void MostrarCarpetas(int n, DirectoryInfo[] directorios)
        {
            if (n != 0)
            {
                try
                {
                    carpeta = new Button();
                    carpeta.Width = 228;
                    carpeta.Height = 20;
                    carpeta.Text = ((DirectoryInfo)directorios[cuentaCarpetas]).Name;
                    carpeta.Top = top;
                    carpeta.Left = left;
                    carpeta.FlatStyle = FlatStyle.Popup;
                    carpeta.BackColor = Color.DarkGray;
                    carpeta.MouseMove += new MouseEventHandler(mousemove);
                    carpeta.MouseLeave += new EventHandler(mouseleave);
                    carpeta.Click += new EventHandler(click_de_boton);
                    pnlRespaldo.Controls.Add(carpeta);
                    left += 228;
                    if (n != 0)
                        cuentaCarpetas += 1;

                }
                catch (Exception) { }
                MostrarCarpetas(n - 1, directorios);
            }
            else
                return;
        }
        public void IterarVideos(int n, FileInfo[] archivos)
        {
            if (n != 0)
            {
                MostrarVideos(4, archivos);
                top += 45; left = 0;
                IterarVideos(archivos.Length - cuentas, archivos);
            }
            else
            {
                top = 45; left = 0; cuentas = 0;
                return;
            }
        }
        public void MostrarVideos(int n, FileInfo[] archivos)
        {
            if (n != 0)
            {
                try
                {
                    archivo = new Button();
                    archivo.Width = 228;
                    archivo.Height = 20;
                    archivo.Name = ((FileInfo)archivos[cuentas]).FullName;
                    archivo.Text = ((FileInfo)archivos[cuentas]).Name.Substring(0, ((FileInfo)archivos[cuentas]).Name.Length - 4);
                    archivo.Top = top;
                    archivo.Left = left;
                    archivo.FlatStyle = FlatStyle.Popup;
                    archivo.BackColor = Color.DarkGray;
                    archivo.MouseMove += new MouseEventHandler(mousemove);
                    archivo.MouseLeave += new EventHandler(mouseleave);
                    archivo.Click += new EventHandler(click_de_boton2);
                    pnlRespaldo.Controls.Add(archivo);
                    //t += 45;
                    left += 228;
                    if (n != 0)
                        cuentas += 1;
                }
                catch (Exception) { }
                MostrarVideos(n - 1, archivos);
            }
            else
            {
                return;
            }
        }
    }
}
