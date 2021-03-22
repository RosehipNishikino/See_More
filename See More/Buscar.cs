using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MODELOS_SEEMORE;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Buscar : Form
    {
        public Seemore AnimeSeleccionado { get; set; }
        public Cuenta cuentaSeleccionado { get; set; }
        public String respaldo { get; set; }
        public String respa { get; set; }
        public String NombreVideo { get; set; }
        public String RutaVideo { get; set; }
        public String UsuarioRegistrado { get; set; }
        public String UsuarioImagen { get; set; }
        public Boolean hayIntercambio { get; set; }
        public String UsuarioTemporal { get; set; }
        Boolean esUnico = true;
        StreamWriter sw1, sw2;
        Boolean esApartado = false;
        String oracion = @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos";
        String texto;
        String ultimarutavista = string.Empty;
        String rutaCamino = string.Empty;
        int tamaño, opcion = 3;
        Boolean buscar = false, buscarListas = false, buscarApartado = false, hayAnimes = false;
        string decision = "";
        public Buscar()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            String line, leni;
            if(Configuracion.usuario != "" && Configuracion.contraseña != "")
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
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath+@"\See More\Configuraciones SeeMore\buscar.txt");
                line = rd.ReadLine(); 
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
            lblSinUso.Text = "";
            if(Configuracion.existeConexion)
            {
                dgvCuenta.DataSource = CuentaSeeMore.BuscarTC();
                pnlRespaldo.Visible = false;
                regresarARaizToolStripMenuItem.Visible = false;
            }
            else {
                pnlRespaldo.Visible = true;
                regresarARaizToolStripMenuItem.Visible = true;
                lblCreacionApartado.Visible = false;
                lblApartado.Visible = false;
                lblApartadoE.Visible = false;
                lblNombreApar.Visible = false;
                lblSerie.Visible = false;
                lblDatoInfo.Visible = false;
                txtCrearApartado.Visible = false;
                txtBuscarApartado.Visible = false;
                txtNombreApartado.Visible = false;
                apartadosToolStripMenuItem.Visible = false;
                reproducirToolStripMenuItem.Visible = false;
                txtSerie.Visible = false;
                lblFiltros.Visible = true;
                cboFiltros.Visible = true;
                pnlRespaldo.Controls.Clear();
                pnlRespaldo.AutoScroll = true;
                tmrRefresco.Start();
                try
                {
                    int t = 45, l = 0; String camino = string.Empty;
                    String[] ruta = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\"+Configuracion.usuario+"Ruta.txt");
                    String[] animesVistos = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                    String[] caminos = new string[1]; String[] separar;
                    try
                    {
                        if(animesVistos[0] != null) { hayAnimes = true; }
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
                    Button button, button2;
                    for (int i = 0; i < directories.Length; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            try
                            {
                                if (hayAnimes)
                                {
                                    foreach (String linea in animesVistos)
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
                                    if(opcion == 2)
                                    {
                                        button = new Button();
                                        button.Width = 200;
                                        button.Height = 20;
                                        button.Text = ((DirectoryInfo)directories[i]).Name;
                                        button.Top = t;
                                        button.Left = l;
                                        button.FlatStyle = FlatStyle.Popup;
                                        button.BackColor = Color.DarkGray;
                                        button.MouseMove += new MouseEventHandler(mousemove);
                                        button.MouseLeave += new EventHandler(mouseleave);
                                        button.Click += new EventHandler(click_de_boton);
                                        pnlRespaldo.Controls.Add(button);
                                        //t += 45;
                                        l += 200;
                                        if (j != 3)
                                            i += 1;
                                    }
                                    if(opcion == 1)
                                    {
                                        j -= 1;
                                        i += 1;
                                    }
                                    opcion = 3;
                                }
                                else
                                {
                                    button = new Button();
                                    button.Width = 200;
                                    button.Height = 20;
                                    button.Text = ((DirectoryInfo)directories[i]).Name;
                                    button.Top = t;
                                    button.Left = l;
                                    button.FlatStyle = FlatStyle.Popup;
                                    button.BackColor = Color.DarkGray;
                                    button.MouseMove += new MouseEventHandler(mousemove);
                                    button.MouseLeave += new EventHandler(mouseleave);
                                    button.Click += new EventHandler(click_de_boton);
                                    pnlRespaldo.Controls.Add(button);
                                    l += 200;
                                    if (j != 3)
                                        i += 1;
                                }
                            }
                            catch (Exception) { }
                        }
                        l = 0;
                        t += 45;
                    }
                    l = 0;
                    t += 45;
                    for (int i = 0; i < files.Length; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            try
                            {
                                button2 = new Button();
                                button2.Width = 200;
                                button2.Height = 20;
                                button2.Name = ((FileInfo)files[i]).FullName;
                                button2.Text = ((FileInfo)files[i]).Name;
                                button2.Top = t;
                                button2.Left = l;
                                button2.FlatStyle = FlatStyle.Popup;
                                button2.BackColor = Color.DarkGray;
                                button2.MouseMove += new MouseEventHandler(mousemove);
                                button2.MouseLeave += new EventHandler(mouseleave);
                                button2.Click += new EventHandler(click_de_boton2);
                                pnlRespaldo.Controls.Add(button2);
                                //t += 45;
                                l += 200;
                                if (j != 3)
                                    i += 1;
                            }
                            catch (Exception) { }
                        }
                        l = 0;
                        t += 45;
                    }
                }
                catch (Exception) { }
            }
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
            String[] animesVistos = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
            try
            {
                texto = ((Button)boton).Text;

                for (int j = 0; j < 1; j++)
                {
                        rutaCamino = rutaCamino + @"\" + texto;
                        ultimarutavista = rutaCamino;
                }
                int t = 45, l = 0;
                DirectoryInfo directory = new DirectoryInfo(rutaCamino);
                FileInfo[] files = directory.GetFiles("*.mp4");
                DirectoryInfo[] directories = directory.GetDirectories();
                Button button, button2;
                for (int i = 0; i < directories.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        try {
                            if (hayAnimes)
                            {
                                foreach (String linea in animesVistos)
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
                                if(opcion == 2)
                                {
                                    button = new Button();
                                    button.Width = 200;
                                    button.Height = 20;
                                    button.Text = ((DirectoryInfo)directories[i]).Name;
                                    button.Top = t;
                                    button.Left = l;
                                    button.BackColor = Color.DarkGray;
                                    button.FlatStyle = FlatStyle.Popup;
                                    button.MouseMove += new MouseEventHandler(mousemove);
                                    button.MouseLeave += new EventHandler(mouseleave);
                                    button.Click += new EventHandler(click_de_boton);
                                    pnlRespaldo.Controls.Add(button);
                                    //t += 45;
                                    l += 200;
                                    if (j != 3)
                                        i += 1;
                                }
                                if(opcion == 1)
                                {
                                    j -= 1;
                                    i += 1;
                                }
                                opcion = 3;
                            }
                            else
                            {
                                button = new Button();
                                button.Width = 200;
                                button.Height = 20;
                                button.Text = ((DirectoryInfo)directories[i]).Name;
                                button.Top = t;
                                button.Left = l;
                                button.BackColor = Color.DarkGray;
                                button.FlatStyle = FlatStyle.Popup;
                                button.MouseMove += new MouseEventHandler(mousemove);
                                button.MouseLeave += new EventHandler(mouseleave);
                                button.Click += new EventHandler(click_de_boton);
                                pnlRespaldo.Controls.Add(button);
                                //t += 45;
                                l += 200;
                                if (j != 3)
                                    i += 1;
                            }
                        }
                        catch (Exception) { }
                    }
                    l = 0;
                    t += 45;
                }
                l = 0;
                t += 45;
                for (int i = 0; i < files.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        try { 
                            button2 = new Button();
                            button2.Width = 200;
                            button2.Height = 20;
                            button2.Name = ((FileInfo)files[i]).FullName;
                            button2.Text = ((FileInfo)files[i]).Name;
                            button2.Top = t;
                            button2.Left = l;
                            button2.BackColor = Color.DarkGray;
                            button2.FlatStyle = FlatStyle.Popup;
                            button2.MouseMove += new MouseEventHandler(mousemove);
                            button2.MouseLeave += new EventHandler(mouseleave);
                            button2.Click += new EventHandler(click_de_boton2);
                            pnlRespaldo.Controls.Add(button2);
                            //t += 45;
                            l += 200;
                            if(j!=3)
                              i += 1;
                        }
                        catch (Exception) { }
                    }
                    l = 0;
                    t += 45;
                }
            }
            catch (Exception) { }
        }
        private void click_de_boton2(object boton, EventArgs args)
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
                    UsuarioRegistrado = Configuracion.UsuariosNombre[j];
                    UsuarioImagen = Configuracion.UsuariosImagen[j];
                    NombreVideo = ((Button)boton).Text;
                    RutaVideo = ((Button)boton).Name;
                    Configuracion.nombre = txtUsuario.Text;
                    Configuracion.usuario = txtUsuario.Text;
                    Configuracion.contraseña = txtContraseña.Text;
                    StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                    sw5.Flush(); sw5.Close();
                    StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                    sw6.Flush(); sw6.Close();
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
                    StreamWriter ultimaruta = new StreamWriter(Application.StartupPath + @"\See More\Usuarios SeeMore\"+Configuracion.usuario+"Ruta.txt");
                    ultimaruta.Flush(); ultimaruta.Close();
                    StreamWriter ultimaruta2 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\"+Configuracion.usuario+"Ruta.txt");
                    ultimaruta2.WriteLine(ultimarutavista+";"); ultimaruta2.Close();
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
        private void Buscar_Load(object sender, EventArgs e)
        {
            String[] users = File.ReadAllLines(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
            tamaño = (users.Length * 4) / 4;
            int contador = 0;
            hayIntercambio = false;
            UsuarioTemporal = "";
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
        } 
        private void buscarEnElApartadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Configuracion.existeConexion)
            {
                if (txtBuscarApartado.Text != "")
                {
                    esUnico = true;
                    esApartado = true;
                    buscar = false;
                    buscarListas = false;
                    buscarApartado = true;
                    Configuracion.nombreApartado = txtBuscarApartado.Text;
                    dgvDatos.DataSource = ApartadosSeeMore.BuscarEnElApartado(txtBuscarApartado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede buscar el nombre sin datos");
                }
            }
        }
        private void crearApartadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Configuracion.existeConexion)
            {
                if (txtCrearApartado.Text != "")
                {
                    String nombre;
                    nombre = txtCrearApartado.Text.Trim();
                    int resultado = ApartadosSeeMore.CrearApartado(nombre);
                    if (resultado == 0)
                    {
                        MessageBox.Show("Exito al crear el apartado");
                    }
                    else
                    {
                        MessageBox.Show("No se creo el apartado");
                    }
                }
                else
                {
                    MessageBox.Show("Esta vacio, no se puede crear un apartado");
                }
            }
        }
        private void moverAlApartadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Configuracion.existeConexion)
            {
                if (txtNombreApartado.Text != "" && txtSerie.Text != "")
                {
                    String nombre, nameSerie;
                    nombre = txtNombreApartado.Text.Trim();
                    nameSerie = txtSerie.Text.Trim();
                    int resultado = ApartadosSeeMore.MoverAlApartado(nombre, nameSerie);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se movieron exitosamente los archivos al apartado");
                    }
                    else
                    {
                        MessageBox.Show("No se movieron los archivos al apartado");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede mover sin los datos");
                }
            }
        }
        private void regresarARaizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlRespaldo.Controls.Clear();
            rutaCamino = @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos";
            String[] animesVistos = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
            try
            {
                int t = 45, l = 0;
                DirectoryInfo directory = new DirectoryInfo(@"C:\Users\" + Configuracion.UsuarioActual + @"\Videos");
                FileInfo[] files = directory.GetFiles("*.mp4");
                DirectoryInfo[] directories = directory.GetDirectories();
                Button button, button2;
                for (int i = 0; i < directories.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        try
                        {
                            if (hayAnimes)
                            {
                                foreach (String linea in animesVistos)
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
                                if(opcion == 2)
                                {
                                    button = new Button();
                                    button.Width = 200;
                                    button.Height = 20;
                                    button.Text = ((DirectoryInfo)directories[i]).Name;
                                    button.Top = t;
                                    button.Left = l;
                                    button.BackColor = Color.DarkGray;
                                    button.FlatStyle = FlatStyle.Popup;
                                    button.MouseMove += new MouseEventHandler(mousemove);
                                    button.MouseLeave += new EventHandler(mouseleave);
                                    button.Click += new EventHandler(click_de_boton);
                                    pnlRespaldo.Controls.Add(button);
                                    //t += 45;
                                    l += 200;
                                    if (j != 3)
                                        i += 1;
                                }
                                if(opcion == 1)
                                {
                                    j -= 1;
                                    i += 1;
                                }
                                opcion = 3;
                            }
                            else
                            {
                                button = new Button();
                                button.Width = 200;
                                button.Height = 20;
                                button.Text = ((DirectoryInfo)directories[i]).Name;
                                button.Top = t;
                                button.Left = l;
                                button.BackColor = Color.DarkGray;
                                button.FlatStyle = FlatStyle.Popup;
                                button.MouseMove += new MouseEventHandler(mousemove);
                                button.MouseLeave += new EventHandler(mouseleave);
                                button.Click += new EventHandler(click_de_boton);
                                pnlRespaldo.Controls.Add(button);
                                //t += 45;
                                l += 200;
                                if (j != 3)
                                    i += 1;
                            }
                        }
                        catch (Exception) { }
                    }
                    l = 0;
                    t += 45;
                }
                l = 0;
                t += 45;
                for (int j = 0; j < files.Length; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        try
                        {
                            button2 = new Button();
                            button2.Width = 200;
                            button2.Height = 20;
                            button2.Name = ((FileInfo)files[j]).FullName;
                            button2.Text = ((FileInfo)files[j]).Name;
                            button2.Top = t;
                            button2.Left = l;
                            button2.BackColor = Color.DarkGray;
                            button2.FlatStyle = FlatStyle.Popup;
                            button2.MouseMove += new MouseEventHandler(mousemove);
                            button2.MouseLeave += new EventHandler(mouseleave);
                            button2.Click += new EventHandler(click_de_boton2);
                            pnlRespaldo.Controls.Add(button2);
                            //t += 45;
                            l += 200;
                            if (k != 3)
                                j += 1;
                        }
                        catch (Exception) { }
                    }
                    l = 0;
                    t += 45;
                }
            }
            catch (Exception) { }
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            hayIntercambio = false;
            if(Configuracion.existeConexion)
            {
                if (CuentaSeeMore.CompartirInformacion(textBox2.Text,textBox1.Text))
                {
                    dgvCuenta.DataSource = CuentaSeeMore.BuscarImagen(textBox2.Text);
                    dgvCuenta.Rows[0].Selected = true;
                    dgvCuenta.CurrentCell = dgvCuenta.Rows[0].Cells[0];
                    if (dgvCuenta.SelectedRows.Count == 1)
                    {
                        UsuarioTemporal = textBox2.Text;
                        MessageBox.Show("El usuario existe, procediendo a intercambio de información, puede continuar viendo videos");
                        hayIntercambio = true;
                    }
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña estan mal, intente de nuevo");
                    hayIntercambio = false;
                }
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
                    if (Configuracion.existeConexion)
                    {
                        dgvDatos.DataSource = DatosSeeMore.BuscarT();
                        esUnico = true;
                        esApartado = false;
                        buscar = true;
                        buscarListas = false;
                        buscarApartado = false;
                    }
                    else
                    {
                        pnlRespaldo.Controls.Clear();
                        oracion = @"C:\Users\" + Configuracion.UsuarioActual + @"\Videos";
                        String[] animesVistos = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                        try
                        {
                            int t = 45, l = 0;
                            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\" + Configuracion.UsuarioActual + @"\Videos");
                            FileInfo[] files = directory.GetFiles("*.mp4");
                            DirectoryInfo[] directories = directory.GetDirectories();
                            Button button, button2;
                            for (int i = 0; i < directories.Length; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    try
                                    {
                                        if (hayAnimes)
                                        {
                                            foreach (String linea in animesVistos)
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
                                            if(opcion == 2)
                                            {
                                                button = new Button();
                                                button.Width = 200;
                                                button.Height = 20;
                                                button.Text = ((DirectoryInfo)directories[i]).Name;
                                                button.Top = t;
                                                button.Left = l;
                                                button.BackColor = Color.DarkGray;
                                                button.FlatStyle = FlatStyle.Popup;
                                                button.MouseMove += new MouseEventHandler(mousemove);
                                                button.MouseLeave += new EventHandler(mouseleave);
                                                button.Click += new EventHandler(click_de_boton);
                                                pnlRespaldo.Controls.Add(button);
                                                //t += 45;
                                                l += 200;
                                                if (j != 3)
                                                    i += 1;
                                            }
                                            if(opcion == 1)
                                            {
                                                j -= 1;
                                                i += 1;
                                            }
                                            opcion = 3;
                                        }
                                        else
                                        {
                                            button = new Button();
                                            button.Width = 200;
                                            button.Height = 20;
                                            button.Text = ((DirectoryInfo)directories[i]).Name;
                                            button.Top = t;
                                            button.Left = l;
                                            button.BackColor = Color.DarkGray;
                                            button.FlatStyle = FlatStyle.Popup;
                                            button.MouseMove += new MouseEventHandler(mousemove);
                                            button.MouseLeave += new EventHandler(mouseleave);
                                            button.Click += new EventHandler(click_de_boton);
                                            pnlRespaldo.Controls.Add(button);
                                            //t += 45;
                                            l += 200;
                                            if (j != 3)
                                                i += 1;
                                        }
                                    }
                                    catch (Exception) { }
                                }
                                l = 0;
                                t += 45;
                            }
                            l = 0;
                            t += 45;
                            for (int i = 0; i < files.Length; i++)
                            {
                                for (int j = 0; j < 4; j++)
                                {
                                    try
                                    {
                                        button2 = new Button();
                                        button2.Width = 200;
                                        button2.Height = 20;
                                        button2.Name = ((FileInfo)files[i]).FullName;
                                        button2.Text = ((FileInfo)files[i]).Name;
                                        button2.Top = t;
                                        button2.Left = l;
                                        button2.BackColor = Color.DarkGray;
                                        button2.FlatStyle = FlatStyle.Popup;
                                        button2.MouseMove += new MouseEventHandler(mousemove);
                                        button2.MouseLeave += new EventHandler(mouseleave);
                                        button2.Click += new EventHandler(click_de_boton2);
                                        pnlRespaldo.Controls.Add(button2);
                                        //t += 45;
                                        l += 200;
                                        if (j != 3)
                                            i += 1;
                                    }
                                    catch (Exception) { }
                                }
                                l = 0;
                                t += 45;
                            }
                        }
                        catch (Exception) { }
                    }
                }
                if(decision == "s-n")
                {
                    if(Configuracion.existeConexion)
                    {
                        Configuracion.totales = 0;
                        String linea;
                        try
                        {
                            StreamReader sr = new StreamReader(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                            linea = sr.ReadLine();
                            while (linea != null)
                            {
                                linea = sr.ReadLine();
                                Configuracion.totales += 1;
                            }
                            sr.Close();
                        }
                        catch (Exception)
                        {
                        }
                        Configuracion.Animes = new string[Configuracion.totales]; int k = 0;
                        String linea2;
                        try
                        {
                            StreamReader sr = new StreamReader(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
                            linea2 = sr.ReadLine();
                            while (linea2 != null)
                            {
                                Configuracion.Animes[k] = linea2;
                                linea2 = sr.ReadLine();
                                k += 1;
                            }
                            sr.Close();
                        }
                        catch (Exception)
                        {
                        }
                            dgvDatos.DataSource = DatosSeeMore.BusquedaContraria();
                            if (dgvDatos.DataSource == null)
                            {
                                dgvDatos.DataSource = DatosSeeMore.BuscarT();
                            }
                        
                        buscar = true;
                        buscarListas = false;
                        buscarApartado = false;
                    }
                    else
                    {
                        MessageBox.Show("No es necesario efectuar este comando pues See More lo hace de forma automatica", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(decision == "b-u")
                {
                    if (Configuracion.existeConexion)
                    {
                        dgvDatos.DataSource = DatosSeeMore.BuscarUltimo();
                        esUnico = true;
                        esApartado = false;
                        buscar = true;
                        buscarListas = false;
                        buscarApartado = false;
                    }
                    else
                    {
                        MessageBox.Show("No podemos mostrarte la información del comando Buscar Último", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(decision == "o")
                {
                    if (Configuracion.existeConexion)
                    {
                        dgvDatos.DataSource = DatosSeeMore.BuscarPorOrden();
                    }
                    else
                    {
                        MessageBox.Show("No puede mostrarte la información del comando Buscar por Orden", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(decision == "all-l")
                {
                    if (Configuracion.existeConexion)
                    {
                        dgvDatos.DataSource = ListasSeeMore.BuscarTL();
                        esUnico = false;
                        buscar = false;
                        buscarListas = true;
                        buscarApartado = false;
                    }
                    else
                    {
                        MessageBox.Show("SeeMore no puede mostrarte la información del comando Buscar Todas las Listas", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if(decision == "u-l")
                {
                    if (Configuracion.existeConexion)
                    {
                        dgvDatos.DataSource = ListasSeeMore.BuscarUltimaLista();
                        esUnico = false;
                        buscar = false;
                        buscarListas = true;
                        buscarApartado = false;
                    }
                    else
                    {
                        MessageBox.Show("SeeMore no puede mostrarte la información del comando Buscar Última Lista", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                if (Configuracion.existeConexion)
                {
                    if (txtNombreSerie.Text != "")
                    {                    
                            dgvDatos.DataSource = DatosSeeMore.BuscarNombre(txtNombreSerie.Text);
                            esUnico = true;
                            esApartado = false;
                            if (File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Busqueda.txt"))
                            {
                                StreamWriter swParaUsuario = new StreamWriter(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Busqueda.txt");
                                swParaUsuario.Flush(); swParaUsuario.Close();
                                StreamWriter swEscribir = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text + "Busqueda.txt");
                                swEscribir.WriteLine(txtNombreSerie.Text); swEscribir.Close();
                            }
                            else
                            {
                                MessageBox.Show("No hemos encontrado a un usuario con el nombre " + txtUsuario.Text + ", ingrese con uno existente");
                            }                      
                    }
                }
                else
                {
                    MessageBox.Show("No podemos mostrar información del comando Buscar Series", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                buscar = true;
                buscarListas = false;
                buscarApartado = false;
            } 
            if(decision == "l-n")
            {
                if (Configuracion.existeConexion)
                {
                    if (txtNombreSerie.Text != "")
                    {
                        dgvDatos.DataSource = ListasSeeMore.BuscarNombreLista(txtNombreSerie.Text);
                        esUnico = false;
                        buscar = false;
                        buscarListas = true;
                        buscarApartado = false;
                    }
                }
                else
                {
                    MessageBox.Show("SeeMore no puede mostrar información del comando Buscar Nombre Lista", "SeeMore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlRespaldo.Controls.Clear();
            String[] animesVistos = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.usuario + "Animes.txt");
            try
            {
                int t = 45, l = 0;
                DirectoryInfo directory = new DirectoryInfo(rutaCamino);
                FileInfo[] files = directory.GetFiles("*."+cboFiltros.SelectedItem.ToString());
                DirectoryInfo[] directories = directory.GetDirectories();
                Button button, button2;
                for (int i = 0; i < directories.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        try
                        {
                            if (hayAnimes)
                            {
                                foreach (String linea in animesVistos)
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
                                if(opcion == 2)
                                {
                                    button = new Button();
                                    button.Width = 200;
                                    button.Height = 20;
                                    button.Text = ((DirectoryInfo)directories[i]).Name;
                                    button.Top = t;
                                    button.Left = l;
                                    button.BackColor = Color.DarkGray;
                                    button.FlatStyle = FlatStyle.Popup;
                                    button.MouseMove += new MouseEventHandler(mousemove);
                                    button.MouseLeave += new EventHandler(mouseleave);
                                    button.Click += new EventHandler(click_de_boton);
                                    pnlRespaldo.Controls.Add(button);
                                    //t += 45;
                                    l += 200;
                                    if (j != 3)
                                        i += 1;
                                }
                                if(opcion == 1)
                                {
                                    j -= 1;
                                    i += 1;
                                }
                                opcion = 3;
                            }
                            else
                            {
                                button = new Button();
                                button.Width = 200;
                                button.Height = 20;
                                button.Text = ((DirectoryInfo)directories[i]).Name;
                                button.Top = t;
                                button.Left = l;
                                button.BackColor = Color.DarkGray;
                                button.FlatStyle = FlatStyle.Popup;
                                button.MouseMove += new MouseEventHandler(mousemove);
                                button.MouseLeave += new EventHandler(mouseleave);
                                button.Click += new EventHandler(click_de_boton);
                                pnlRespaldo.Controls.Add(button);
                                //t += 45;
                                l += 200;
                                if (j != 3)
                                    i += 1;
                            }
                        }
                        catch (Exception) { }
                    }
                    l = 0;
                    t += 45;
                }
                l = 0;
                t += 45;
                for (int i = 0; i < files.Length; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        try
                        {
                            button2 = new Button();
                            button2.Width = 200;
                            button2.Height = 20;
                            button2.Name = ((FileInfo)files[i]).FullName;
                            button2.Text = ((FileInfo)files[i]).Name;
                            button2.Top = t;
                            button2.Left = l;
                            button2.BackColor = Color.DarkGray;
                            button2.FlatStyle = FlatStyle.Popup;
                            button2.MouseMove += new MouseEventHandler(mousemove);
                            button2.MouseLeave += new EventHandler(mouseleave);
                            button2.Click += new EventHandler(click_de_boton2);
                            pnlRespaldo.Controls.Add(button2);
                            //t += 45;
                            l += 200;
                            if (j != 3)
                                i += 1;
                        }
                        catch (Exception) { }
                    }
                    l = 0;
                    t += 45;
                }
            }
            catch (Exception) { }
        }
        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hayIntercambio == true)
                hayIntercambio = true;
            else
                hayIntercambio = false;
            if(Configuracion.existeConexion) { 
                if (Configuracion.existeConexion)
                {
                    if (CuentaSeeMore.InicioSesion(txtUsuario.Text,txtContraseña.Text))
                    {
                        if (esUnico == true)
                        {
                            if (esApartado == true)
                            {
                                if(buscarApartado == true)
                                {
                                    dgvCuenta.DataSource = CuentaSeeMore.BuscarImagen(txtUsuario.Text);
                                    dgvCuenta.Rows[0].Selected = true;
                                    dgvCuenta.CurrentCell = dgvDatos.Rows[0].Cells[0];
                                    if (dgvDatos.SelectedRows.Count == 1 && dgvCuenta.SelectedRows.Count == 1)
                                    {
                                        int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                                        int id2 = Convert.ToInt32(dgvCuenta.CurrentRow.Cells[0].Value);
                                        AnimeSeleccionado = ApartadosSeeMore.ObtenerApartado(txtBuscarApartado.Text, id);
                                        cuentaSeleccionado = CuentaSeeMore.ObtenerC(id2);
                                        Configuracion.usuario = txtUsuario.Text;
                                        Configuracion.contraseña = txtContraseña.Text;
                                        StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                                        sw5.Flush(); sw5.Close();
                                        StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                                        sw6.Flush(); sw6.Close();
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
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione un video del apartado y inicie sesión con un usuario");
                                    }
                                }
                                else { MessageBox.Show("No se ha buscado nada para la reproduccion"); }
                            }
                            else
                            {
                                if(buscar == true)
                                {
                                    dgvCuenta.DataSource = CuentaSeeMore.BuscarImagen(txtUsuario.Text);
                                    dgvCuenta.Rows[0].Selected = true;
                                    dgvCuenta.CurrentCell = dgvDatos.Rows[0].Cells[0];
                                    if (dgvDatos.SelectedRows.Count == 1 && dgvCuenta.SelectedRows.Count == 1)
                                    {
                                        int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                                        int id2 = Convert.ToInt32(dgvCuenta.CurrentRow.Cells[0].Value);
                                        AnimeSeleccionado = DatosSeeMore.Obtener(id);
                                        cuentaSeleccionado = CuentaSeeMore.ObtenerC(id2);
                                        Configuracion.usuario = txtUsuario.Text;
                                        Configuracion.contraseña = txtContraseña.Text;
                                        StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                                        sw5.Flush(); sw5.Close();
                                        StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                                        sw6.Flush(); sw6.Close();
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
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione un video o el video buscado exacto con un usuario");
                                    }
                                }
                                else { MessageBox.Show("No se ha buscado nada para la reproduccion"); }
                            }
                        }
                        else
                        {
                            if(buscarListas == true)
                            {
                                dgvCuenta.DataSource = CuentaSeeMore.BuscarImagen(txtUsuario.Text);
                                dgvCuenta.Rows[0].Selected = true;
                                dgvCuenta.CurrentCell = dgvDatos.Rows[0].Cells[0];
                                if (dgvDatos.SelectedRows.Count == 1 && dgvCuenta.SelectedRows.Count == 1)
                                {
                                    int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                                    int id2 = Convert.ToInt32(dgvCuenta.CurrentRow.Cells[0].Value);
                                    AnimeSeleccionado = ListasSeeMore.ObtenerLista(id);
                                    cuentaSeleccionado = CuentaSeeMore.ObtenerC(id2);
                                    Configuracion.usuario = txtUsuario.Text;
                                    Configuracion.contraseña = txtContraseña.Text;
                                    StreamWriter sw5 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                                    sw5.Flush(); sw5.Close();
                                    StreamWriter sw6 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                                    sw6.Flush(); sw6.Close();
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
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione una lista o la lista buscada exacta con un usuario");
                                }
                            }
                            else { MessageBox.Show("No se ha buscado nada para la reproduccion"); }
                        }
                    }
                }
            }
        }
    }
}
