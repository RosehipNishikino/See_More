﻿using System;
using System.Drawing;
using System.Windows.Forms;
using AxWMPLib;
using System.IO;
using DATOS_SEEMORE;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Linq;

namespace See_More
{
    public partial class Reproductor : Form
    {
        int volumen = 50;
        public WMPLib.IWMPPlaylist infoDatos { get; set; }
        StreamWriter sw;
        StreamWriter sw2; String todo; String usuario;
        StreamWriter sw3;
        StreamWriter sw4;
        int contador = 1;
        int opcion = 3;
        bool entra = true;
        bool nombre = true; String ruta = string.Empty;
        Boolean pantallaCompleta = true;
        Boolean autopausa = false;
        Boolean autorepetir = false;
        String auxiliarNombre = string.Empty;
        String duracionFinal = string.Empty;
        String VideoNombreActual = string.Empty;
        Boolean cerro = false;
        Boolean primerAviso = false, ultimoAviso = false;
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNORMAL = 1;
        public Reproductor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                volumen -= 2;
            else
            {
                volumen += 2;
            }
            if (volumen >= 0 && volumen <= 100)
            {
                wmpCentral.settings.volume = volumen;
                lblVolumen.Text = "Volumen: " + volumen;
            }
            else if (volumen < 0)
            {
                volumen = 0;
            }
            else if (volumen > 100)
            {
                volumen = 100;
            }
            else { }
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagenes_de_fondo frm = new Imagenes_de_fondo();
            frm.ShowDialog();
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\reproductor.txt");
                line = rd.ReadLine();
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
        }
        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (entra == true)
                {
                    if (!Configuracion.DatosReproductor.IsOnly)
                    {
                        this.Text = "En pausa - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    }
                    else
                    {
                        this.Text = "En pausa - " + todo;
                    }
                }
                else
                {
                    this.Text = "En pausa - " + wmpCentral.currentMedia.name;
                }
                wmpCentral.Ctlcontrols.pause();
            }
            else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                tmrProgreso.Start();
                if (entra == true)
                {
                    if (!Configuracion.DatosReproductor.IsOnly)
                    {
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    }
                    else
                    {
                        this.Text = "Viendo - " + todo;
                    }
                }
                else
                {
                    this.Text = "Viendo - " + wmpCentral.currentMedia.name;
                }
                wmpCentral.Ctlcontrols.play();
            }
            else { }
        }
        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, _WMPOCXEvents_KeyPressEvent e)
        {
            if ((e.nKeyAscii) == (char)(Keys.Space))
            {
                if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    if (entra == true)
                    {
                        if (!Configuracion.DatosReproductor.IsOnly)
                        {
                            this.Text = "En pausa - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                        }
                        else
                        {
                            this.Text = "En pausa - " + todo;
                        }
                    }
                    else
                    {
                        this.Text = "En pausa - " + wmpCentral.currentMedia.name;
                    }
                    wmpCentral.Ctlcontrols.pause();
                }
                else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    tmrProgreso.Start();
                    if (entra == true)
                    {
                        if (!Configuracion.DatosReproductor.IsOnly)
                        {
                            this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                        }
                        else
                        {
                            this.Text = "Viendo - " + todo;
                        }
                    }
                    else
                    {
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name;
                    }
                    wmpCentral.Ctlcontrols.play();
                }
                else { }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Historial frm = new Historial();
            frm.ShowDialog();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String c = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de video mp4|*.mp4|Archivos de video avi|*.avi|Archivos de video wmv|*.wmv|Archivos de video mkv|*.mkv|Archivos de reproduccion wpl|*.wpl|Archivo de audio mp3|*.mp3";
            abrir.FileName = "Reproductor video/lista";
            abrir.Title = "Video/Lista";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                wmpCentral.URL = abrir.FileName;
                ruta = abrir.FileName;
                tmrProgreso.Start();
                StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                escribir.Flush(); escribir.Close();
                sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                sw2 = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt");
                sw.WriteLine(wmpCentral.currentMedia.name + " Video no guardado");
                sw2.WriteLine(wmpCentral.currentMedia.name + " " + c + " Video no guardado");
                sw.Close();
                sw2.Close();
                entra = false;
                nombre = false;
                todo = wmpCentral.currentMedia.name;
                this.Text = "Viendo - " + todo;
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                if (this.Width <= 900)
                {
                    toolStripMenuItem1.Visible = false;
                    toolStripMenuItem3.Visible = true;
                }
                if (this.Width > 900)
                {
                    toolStripMenuItem1.Visible = true;
                    toolStripMenuItem3.Visible = false;
                }
                if (this.Width <= 800)
                {
                    cerrarToolStripMenuItem.Visible = false;
                    personalizaciónToolStripMenuItem.Visible = true;
                }
                if (this.Width > 800)
                {
                    cerrarToolStripMenuItem.Visible = true;
                    personalizaciónToolStripMenuItem.Visible = false;
                }
                if (this.Width <= 700)
                {
                    iniciarSesiónToolStripMenuItem.Visible = false;
                    iniciarSesiónToolStripMenuItem1.Visible = true;
                }
                if (this.Width > 700)
                {
                    iniciarSesiónToolStripMenuItem.Visible = true;
                    iniciarSesiónToolStripMenuItem1.Visible = false;
                }
                if (this.Width <= 650)
                    this.Width = 650;
                if (this.Height <= 380)
                    this.Height = 380;
            }
            if (!autopausa)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        if (entra == true)
                        {
                            if (!Configuracion.DatosReproductor.IsOnly)
                            {
                                this.Text = "En pausa - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                            }
                            else
                            {
                                this.Text = "En pausa - " + todo;
                            }
                        }
                        else
                        {
                            this.Text = "En pausa - " + wmpCentral.currentMedia.name;
                        }
                        wmpCentral.Ctlcontrols.pause();
                    }
                }
                else if (this.WindowState == FormWindowState.Normal)
                {
                    if (wmpCentral.playState != WMPLib.WMPPlayState.wmppsStopped && wmpCentral.playState != WMPLib.WMPPlayState.wmppsUndefined)
                    {
                        if (entra == true)
                        {
                            if (!Configuracion.DatosReproductor.IsOnly)
                            {
                                this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                            }
                            else
                            {
                                this.Text = "Viendo - " + todo;
                            }
                        }
                        else
                        {
                            this.Text = "Viendo - " + wmpCentral.currentMedia.name;
                        }
                        wmpCentral.Ctlcontrols.play();
                    }
                }
                else if (this.WindowState == FormWindowState.Maximized)
                {
                    if (wmpCentral.playState != WMPLib.WMPPlayState.wmppsStopped && wmpCentral.playState != WMPLib.WMPPlayState.wmppsUndefined)
                    {
                        if (entra == true)
                        {
                            if (!Configuracion.DatosReproductor.IsOnly)
                            {
                                this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                            }
                            else
                            {
                                this.Text = "Viendo - " + todo;
                            }
                        }
                        else
                        {
                            this.Text = "Viendo - " + wmpCentral.currentMedia.name;
                        }
                        wmpCentral.Ctlcontrols.play();
                    }
                }
                else { }
            }
        }
        public void DirectoriosExistentes()
        {
            if (!Directory.Exists(Application.StartupPath + @"\See More"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\See More");
            }
            if (!Directory.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\See More\Configuraciones SeeMore");
            }
            if (!Directory.Exists(Application.StartupPath + @"\See More\Inicios SeeMore"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\See More\Inicios SeeMore");
            }
            if (!Directory.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore"))
            {
                Directory.CreateDirectory(Application.StartupPath + @"\See More\Usuarios SeeMore");
            }
        }
        public void ArchivosExistentes()
        {
            if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\actualizar.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\actualizar.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\buscar.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\buscar.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\busqueda.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\busqueda.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\crearcuenta.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\crearcuenta.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\eliminar.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\eliminar.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\history.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\history.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\Imagen.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\nuevo.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\nuevo.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\reproductor.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\reproductor.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\respaldo.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\respaldo.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\actuaTemp.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\actuaTemp.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\creaTemp.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\creaTemp.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\creaciones.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\creaciones.txt");
            }
            if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\actualizaciones.txt"))
            {
                File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\actualizaciones.txt");
            }
        }
        public void Verificar()
        {
            int dia = DateTime.Now.Day, mes = DateTime.Now.Month, año = DateTime.Now.Year;
            if (dia == 1 && mes == 1)
            {
                String[] lines = File.ReadAllLines(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt");
                foreach (String lineas in lines)
                {
                    año -= 1;
                    String fecha = año + "/" + mes + "/" + dia;
                    if (fecha.Contains(lineas))
                    {

                    }
                }
            }
        }
        public Boolean Instacia()
        {
            Process currentProcess = Process.GetCurrentProcess();

            var runningProcess =
                (
                    from process in Process.GetProcesses()
                    where process.Id != currentProcess.Id
                        && process.ProcessName.Equals(currentProcess.ProcessName, StringComparison.Ordinal)
                    select process
                ).FirstOrDefault();
            if (runningProcess != null)
            {
                ShowWindow(runningProcess.MainWindowHandle, SW_SHOWNORMAL);
                SetForegroundWindow(runningProcess.MainWindowHandle);

                return false;
            }

            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            wmpCentral.CreateControl();
            if (Instacia())
            {
                DirectoriosExistentes();
                ArchivosExistentes();
                tmrEstadoActual.Start();
                tmrVerificacion.Start();
                string result = string.Empty;
                string resultado = string.Empty;
                string resul = string.Empty;
                String linea;
                String linea2;
                String linea3;
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                StreamReader rd2 = new StreamReader(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                StreamReader rd3 = new StreamReader(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
                linea = rd.ReadLine();
                linea2 = rd2.ReadLine();
                linea3 = rd3.ReadLine();
                if(linea != null && linea2 != null && linea3 != null)
                {
                    byte[] decryted = Convert.FromBase64String(linea);
                    result = System.Text.Encoding.Unicode.GetString(decryted);
                    Configuracion.DatosUsuario.Usuario = result;
                    byte[] decryted2 = Convert.FromBase64String(linea2);
                    resultado = System.Text.Encoding.Unicode.GetString(decryted2);
                    Configuracion.DatosUsuario.Contraseña = resultado;
                    byte[] decryted3 = Convert.FromBase64String(linea3);
                    resul = System.Text.Encoding.Unicode.GetString(decryted3);
                    Configuracion.DatosUsuario.Imagen = resul;
                }
                wmpCentral.settings.volume = 50;
                wmpCentral.uiMode = "none";
                wmpCentral.stretchToFit = true;
                lblVolumen.Text = "Volumen: " + volumen;
                tmrBateria.Start();
                if (Configuracion.DatosUsuario.Usuario != null)
                {
                    iniciarSesiónToolStripMenuItem.Text = Configuracion.DatosUsuario.Usuario;
                    menuToolStripMenuItem.Text = "Ir a perfil de " + Configuracion.DatosUsuario.Usuario;
                    iniciarSesiónToolStripMenuItem1.Text = Configuracion.DatosUsuario.Usuario;
                    menuToolStripMenuItem1.Text = "Ir a perfil de " + Configuracion.DatosUsuario.Usuario;
                    picUsuario.Image = Image.FromFile(Configuracion.DatosUsuario.Imagen);
                    picUsuario.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
                    menuToolStripMenuItem.Text = "Iniciar Sesión";
                    iniciarSesiónToolStripMenuItem1.Text = "Iniciar Sesión";
                    menuToolStripMenuItem1.Text = "Iniciar Sesión";
                    if (picUsuario.Image != null)
                    {
                        picUsuario.Image.Dispose();
                        picUsuario.Image = null;
                    }
                }
                this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
                String line; String line2;
                StreamReader read = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                StreamReader read2 = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\reproductor.txt");
                line = read.ReadLine();
                line2 = read2.ReadLine();
                if (line == null)
                    this.Text = "See More";
                else
                    this.Text = "Ultimo video visto: " + line;
                if(line2 != null)
                {
                    this.BackgroundImage = Image.FromFile(line2);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                read.Close(); read2.Close();
            }
            else
            {
                MessageBox.Show("Ya se ha abierto una instancia del reproductor", "Cerrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void axWindowsMediaPlayer1_KeyUpEvent(object sender, _WMPOCXEvents_KeyUpEvent e)
        {
            if ((e.nKeyCode) == (char)(Keys.Right))
            {
                if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    wmpCentral.Ctlcontrols.fastForward();
                }
                else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    wmpCentral.Ctlcontrols.fastForward();
                }
                else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsScanReverse)
                {
                    wmpCentral.Ctlcontrols.play();
                }
            }
            if ((e.nKeyCode) == (char)(Keys.Left))
            {
                if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    wmpCentral.Ctlcontrols.fastReverse();
                }
                else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    wmpCentral.Ctlcontrols.fastReverse();
                }
                else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsScanForward)
                {
                    wmpCentral.Ctlcontrols.play();
                }
            }
            if ((e.nKeyCode) == (char)(Keys.S))
            {
                if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    if (entra == true)
                    {
                        if (!Configuracion.DatosReproductor.IsOnly)
                        {
                            this.Text = "Detenido - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                        }
                        else
                        {
                            this.Text = "Detenido - " + todo;
                        }
                    }
                    else
                    {
                        this.Text = "Detenido - " + wmpCentral.currentMedia.name;
                    }
                    wmpCentral.Ctlcontrols.stop();
                    lblSinUso.Text = "";
                    tmrProgreso.Stop();
                }
                else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    if (entra == true)
                    {
                        if (!Configuracion.DatosReproductor.IsOnly)
                        {
                            this.Text = "Detenido - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                        }
                        else
                        {
                            this.Text = "Detenido - " + todo;
                        }
                    }
                    else
                    {
                        this.Text = "Detenido - " + wmpCentral.currentMedia.name;
                    }
                    wmpCentral.Ctlcontrols.stop();
                    lblSinUso.Text = "";
                }
                else
                {
                    notifyIcon1.Icon = new Icon(Path.GetFullPath(@"seemore.ico"));
                    notifyIcon1.Text = "No hay video";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "No puede detener";
                    notifyIcon1.BalloonTipText = "Se necesita de un video para la función STOP";
                    notifyIcon1.ShowBalloonTip(100);
                }
            }
            if ((e.nKeyCode) == (char)(Keys.Add))
            {
                volumen += 2;
                if (volumen >= 0 && volumen <= 100)
                {
                    wmpCentral.settings.volume = volumen;

                    lblVolumen.Text = "Volumen: " + volumen;
                }
                else if (volumen > 100)
                {
                    volumen = 100;
                }
            }
            if ((e.nKeyCode) == (char)(Keys.Subtract))
            {
                volumen -= 2;
                if (volumen >= 0 && volumen <= 100)
                {
                    wmpCentral.settings.volume = volumen;
                    lblVolumen.Text = "Volumen: " + volumen;
                }
                else if (volumen < 0)
                {
                    volumen = 0;
                }
            }
            if ((e.nKeyCode) == (char)(Keys.F))
            {
                if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    if (pantallaCompleta == true)
                    {
                        pantallaCompleta = false;
                        wmpCentral.fullScreen = true;
                    }
                    else
                    {
                        pantallaCompleta = true;
                        wmpCentral.fullScreen = false;
                    }
                }
                else
                {
                    notifyIcon1.Icon = new Icon(Path.GetFullPath(@"seemore.ico"));
                    notifyIcon1.Text = "No hay video";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "No puede ajustar a pantalla completa";
                    notifyIcon1.BalloonTipText = "Se necesita de un video para la función FULLSCREEN";
                    notifyIcon1.ShowBalloonTip(100);
                }
            }
            if ((e.nKeyCode) == (char)(Keys.P))
            {
                if (autopausa == false)
                {
                    autopausa = true;
                    lblAutoPausa.Text = "Se ha desactivado el auto-pausa";
                }
                else
                {
                    autopausa = false;
                    lblAutoPausa.Text = "Se ha activado el auto-pausa";
                }
                tmrProceso.Start();
            }
            if ((e.nKeyCode) == (char)(Keys.R))
            {
                if (autorepetir == false)
                {
                    autorepetir = true;
                    wmpCentral.settings.setMode("loop", true);
                    lblAutoRepetir.Text = "Se ha activado el auto-repetir";
                }
                else
                {
                    autorepetir = false;
                    wmpCentral.settings.setMode("loop", false);
                    lblAutoRepetir.Text = "Se ha desactivado el auto-repetir";
                }
                tmrProceso.Start();
            }
            if ((e.nKeyCode) == (char)(Keys.N))
            {
                contador++;
                if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    wmpCentral.Ctlcontrols.next();
                    if (nombre == true)
                    {
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    }
                    else
                    {
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name;
                    }
                }
                else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    wmpCentral.Ctlcontrols.next();
                    if (nombre == true)
                    {
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    }
                    else
                    {
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name;
                    }
                }
                else
                {
                    notifyIcon1.Icon = new Icon(Path.GetFullPath(@"seemore.ico"));
                    notifyIcon1.Text = "No hay lista";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "No puede adelantar";
                    notifyIcon1.BalloonTipText = "Se necesita de una lista para la función NEXT";
                    notifyIcon1.ShowBalloonTip(100);
                }
            }
            if ((e.nKeyCode) == (char)(Keys.B))
            {
                contador--;
                if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    wmpCentral.Ctlcontrols.previous();
                    if (nombre == true)
                    {
                        if (contador < 1)
                        {
                            contador = 1;
                        }
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    }
                    else
                    {
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name;
                    }
                }
                else if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    wmpCentral.Ctlcontrols.previous();
                    if (nombre == true)
                    {
                        if (contador < 1)
                        {
                            contador = 1;
                        }
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    }
                    else
                    {
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name;
                    }
                }
                else
                {
                    notifyIcon1.Icon = new Icon(Path.GetFullPath(@"seemore.ico"));
                    notifyIcon1.Text = "No hay lista";
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "No puede regresar";
                    notifyIcon1.BalloonTipText = "Se necesita de una lista para la función BACK";
                    notifyIcon1.ShowBalloonTip(100);
                }
            }
            /*if(e.nKeyCode == (char)(Keys.T))
            {
                
            }*/
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrGuardarAuto.Stop();
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (usuario != "")
                {
                    StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    sw.WriteLine(auxiliarNombre + "{" + wmpCentral.Ctlcontrols.currentPosition);
                    sw.Close();
                    wmpCentral.Ctlcontrols.stop();
                }
            }
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                if (usuario != "")
                {
                    StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    sw.WriteLine(auxiliarNombre + "{" + wmpCentral.Ctlcontrols.currentPosition);
                    sw.Close();
                    wmpCentral.Ctlcontrols.stop();
                }
            }
            Application.Exit();
        }
        /* public void HabilitarUsoCompleto()
         {
             wmpCentral.Size = new Size(wmpCentral.Width, wmpCentral.Height);
         }*/
        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Buscar frm = new Buscar();
            frm.ShowDialog();
            try
            {
                if (frm.datos != null)
                {
                    wmpCentral.currentPlaylist = frm.datos;
                    wmpCentral.Ctlcontrols.play();
                    this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    Configuracion.DatosReproductor.NombreVideo = wmpCentral.currentMedia.name;
                    auxiliarNombre = Configuracion.DatosReproductor.NombreVideo;
                    VideoNombreActual = wmpCentral.currentMedia.name;
                    tmrProgreso.Start();
                    tmrLista.Start();
                    String[] porVer = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    String[] vacio;
                    foreach (String linea in porVer)
                    {
                        vacio = linea.Split('{');
                        if (vacio[0] == auxiliarNombre)
                        {
                            wmpCentral.Ctlcontrols.currentPosition = double.Parse(vacio[1]);
                            // axvlcControl.input.time = double.Parse(vacio[1]);
                        }
                        else
                        {
                            StreamWriter escribir = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt");
                            escribir.WriteLine(vacio[0] + "{" + vacio[1]);
                            escribir.Close();
                        }
                    }
                    File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    File.Move(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt", Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt"))
                    {
                        File.CreateText(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt");
                    }
                    picUsuario.Image = Image.FromFile(Configuracion.DatosUsuario.Imagen);
                    entra = true;
                    nombre = true;
                    ruta = string.Empty;
                    try
                    {
                        StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                        escribir.Flush(); escribir.Close();
                        sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                        sw2 = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt");
                        sw.WriteLine(Configuracion.DatosReproductor.NombreVideo + "");
                        String b = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                        sw2.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                        sw.Close();
                        sw2.Close();
                        if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt"))
                        {
                            if (Configuracion.DatosReproductor.hayIntercambio)
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                sw3.Close();
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosReproductor.UsuarioTemporal + ".txt");
                                sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                sw3.Close();
                            }
                            else
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                sw3.Close();
                            }
                        }
                        else
                        {
                            if (Configuracion.DatosReproductor.hayIntercambio)
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                sw3.Close();
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosReproductor.UsuarioTemporal + ".txt");
                                sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                sw3.Close();
                            }
                            else
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                sw3.Close();
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                if (Configuracion.DatosReproductor.NombreVideo != null && Configuracion.DatosReproductor.RutaVideo != null)
                {
                    if (wmpCentral.URL != Configuracion.DatosReproductor.RutaVideo)
                    {
                        todo = "" + Configuracion.DatosReproductor.NombreVideo + " - " + Configuracion.DatosUsuario.Usuario;
                        auxiliarNombre = Configuracion.DatosReproductor.NombreVideo;
                        usuario = "" + Configuracion.DatosUsuario.Usuario;
                        wmpCentral.URL = Configuracion.DatosReproductor.RutaVideo;
                        this.Text = "Viendo - " + todo;
                        tmrProgreso.Start();
                        String[] porVer = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                        String[] vacio;
                        foreach (String linea in porVer)
                        {
                            vacio = linea.Split('{');
                            if (vacio[0] == auxiliarNombre)
                            {
                                wmpCentral.Ctlcontrols.currentPosition = double.Parse(vacio[1]);
                            }
                            else
                            {
                                StreamWriter escribir = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt");
                                escribir.WriteLine(vacio[0] + "{" + vacio[1]);
                                escribir.Close();
                            }
                        }
                        File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                        File.Move(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt", Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                        if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt"))
                        {
                            File.CreateText(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt");
                        }
                        picUsuario.Image = Image.FromFile(Configuracion.DatosUsuario.Imagen);
                        entra = true;
                        nombre = true;
                        ruta = string.Empty;
                        try
                        {
                            StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                            escribir.Flush(); escribir.Close();
                            sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                            sw2 = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt");
                            sw.WriteLine(Configuracion.DatosReproductor.NombreVideo + "");
                            String b = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                            sw2.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                            sw.Close();
                            sw2.Close();
                            if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt"))
                            {
                                if (Configuracion.DatosReproductor.hayIntercambio)
                                {
                                    sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                    sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                    sw3.Close();
                                    sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosReproductor.UsuarioTemporal + ".txt");
                                    sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                    sw3.Close();
                                }
                                else
                                {
                                    sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                    sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                    sw3.Close();
                                }
                            }
                            else
                            {
                                if (Configuracion.DatosReproductor.hayIntercambio)
                                {
                                    sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                    sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                    sw3.Close();
                                    sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosReproductor.UsuarioTemporal + ".txt");
                                    sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                    sw3.Close();
                                }
                                else
                                {
                                    sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                    sw3.WriteLine(Configuracion.DatosReproductor.NombreVideo + " " + b);
                                    sw3.Close();
                                }
                            }
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void crearCuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Crear_Cuenta frm = new Crear_Cuenta();
            if (frm.cerrar == true)
            {
                Configuracion.Informacion.respuesta = frm.cerrar;
                Configuracion.Informacion.respuesta = true;
            }
            else
            {
                frm.Show();
            }
        }
        private void comoFuncionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Reproductor See More cuenta con las siguientes opciones\n" +
                "1.- Haz Pausa y Continuar con solo un espacio o un clic\n" +
                "2.- Deten el video con oprimir S una sola vez\n" +
                "3.- Sube y baja el volumen con + y -, ó usa la rueda del ratón\n" +
                "4.- Entra al modo pantalla completa con F y sal con la misma\n" +
                "5.- Haz siguiente con N y regreso con B mientras haya una lista.\n" +
                "6.- Activa y desactiva el auto-pausa con P\n" +
                "7.- Activa y desactiva el auto-repetir con R\n" +
                "8.- Proxima función (Habilita el uso completo de la pantalla con T)" +
                "                                                                                               See More.", "Ayuda de See More al usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Tu_perfil().Show();
            Evento();
            cerro = false;
        }
        private void cerrarLaSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }
        public void CerrarSesion()
        {
            if (cerro == false)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Usuario.txt");
                sw.Flush(); sw.Close();
                StreamWriter sw2 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Contraseña.txt");
                sw2.Flush(); sw2.Close();
                StreamWriter sw3 = new StreamWriter(Application.StartupPath + @"\See More\Inicios SeeMore\Imagen.txt");
                sw3.Flush(); sw3.Close();
                Configuracion.DatosUsuario.Usuario = "";
                Configuracion.DatosUsuario.Contraseña = "";
                Configuracion.DatosUsuario.Imagen = "";
                iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
                menuToolStripMenuItem.Text = "Iniciar Sesión";
                iniciarSesiónToolStripMenuItem1.Text = "Iniciar Sesión";
                menuToolStripMenuItem1.Text = "Iniciar Sesión";
                Evento();
                cerro = true;
            }
        }
        public void Evento()
        {
            if (Configuracion.DatosUsuario.Usuario != null)
            {
                iniciarSesiónToolStripMenuItem.Text = Configuracion.DatosUsuario.Usuario;
                menuToolStripMenuItem.Text = "Ir a perfil de " + Configuracion.DatosUsuario.Usuario;
                iniciarSesiónToolStripMenuItem1.Text = Configuracion.DatosUsuario.Usuario;
                menuToolStripMenuItem1.Text = "Ir a perfil de " + Configuracion.DatosUsuario.Usuario;
                picUsuario.Image = Image.FromFile(Configuracion.DatosUsuario.Imagen);
                picUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
                menuToolStripMenuItem.Text = "Iniciar Sesión";
                iniciarSesiónToolStripMenuItem1.Text = "Iniciar Sesión";
                menuToolStripMenuItem1.Text = "Iniciar Sesión";
                if (picUsuario.Image != null)
                {
                    picUsuario.Image.Dispose();
                    picUsuario.Image = null;
                }
            }
        }
        public void PerfilDe()
        {
            new Tu_perfil().Show();
            Evento();
            cerro = false;
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfilDe();
        }
        private void tmrProceso_Tick(object sender, EventArgs e)
        {
            tmrProceso.Stop();
            lblAutoPausa.Text = "";
            lblAutoRepetir.Text = "";
        }
        private void wmpCentral_Enter(object sender, EventArgs e)
        {

        }
        private void tmrEstadoActual_Tick(object sender, EventArgs e)
        {
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (entra == true)
                {
                    if (!Configuracion.DatosReproductor.IsOnly)
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    else
                        this.Text = "Viendo - " + todo;
                }
                else
                {
                    if (!Configuracion.DatosReproductor.IsOnly)
                        this.Text = "Viendo - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    else
                        this.Text = "Viendo - " + todo;
                }
            }
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (entra == true)
                {
                    if (!Configuracion.DatosReproductor.IsOnly)
                        this.Text = "Detenido - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    else
                        this.Text = "Detenido - " + todo;
                }
                else
                {
                    if (!Configuracion.DatosReproductor.IsOnly)
                        this.Text = "Detenido - " + wmpCentral.currentMedia.name + " - " + Configuracion.DatosUsuario.Usuario;
                    else
                        this.Text = "Detenido - " + todo;
                }
            }
        }
        private void wmpCentral_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
        }
        private void tmrProgreso_Tick(object sender, EventArgs e)
        {
            duracionFinal = wmpCentral.currentMedia.durationString;
            lblFinal.Text = duracionFinal;

            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lblInicio.Text = wmpCentral.Ctlcontrols.currentPositionString;
            }
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                lblInicio.Text = wmpCentral.Ctlcontrols.currentPositionString;
            }
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                tmrProgreso.Stop();
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
        }
        private void tmrBateria_Tick(object sender, EventArgs e)
        {
            String strBateria; float Bateria = 0;
            Bateria = 100 * SystemInformation.PowerStatus.BatteryLifePercent;

            if (SystemInformation.PowerStatus.BatteryChargeStatus
                 == BatteryChargeStatus.Charging)
            {
                strBateria = "Cargando " + Bateria + "%";

                lblSinUso.Text = strBateria;
            }
            else
            {
                strBateria = "Bateria al " + Bateria + "%";

                lblSinUso.Text = strBateria;
                if (Bateria == 30)
                {
                    if (opcion == 3)
                    {
                        notifyIcon1.Icon = new Icon(Path.GetFullPath(@"seemore.ico"));
                        notifyIcon1.Text = "Aviso de Bateria";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = "Primer aviso de Bateria";
                        notifyIcon1.BalloonTipText = "La bateria se encuentra en " + Bateria + "%";
                        notifyIcon1.ShowBalloonTip(100);
                        opcion = 2;
                    }
                }
                if (Bateria == 15)
                {
                    if (opcion == 2)
                    {
                        notifyIcon1.Icon = new Icon(Path.GetFullPath(@"seemore.ico"));
                        notifyIcon1.Text = "Aviso de Bateria";
                        notifyIcon1.Visible = true;
                        notifyIcon1.BalloonTipTitle = "Último aviso de Bateria";
                        notifyIcon1.BalloonTipText = "La bateria se encuentra en " + Bateria + "%";
                        notifyIcon1.ShowBalloonTip(100);
                        opcion = 1;
                    }
                }
                if (Bateria > 30)
                {
                    opcion = 3;
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Historial frm = new Historial();
            frm.ShowDialog();
        }

        private void personalizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imagenes_de_fondo frm = new Imagenes_de_fondo();
            frm.ShowDialog();
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\reproductor.txt");
                line = rd.ReadLine();
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PerfilDe();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarSesion();
        }

        private void tmrVerificacion_Tick(object sender, EventArgs e)
        {
            Evento();
        }

        private void tmrLista_Tick(object sender, EventArgs e)
        {
            if (!Configuracion.DatosReproductor.IsOnly)
            {
                if (VideoNombreActual != wmpCentral.currentMedia.name)
                {
                    VideoNombreActual = wmpCentral.currentMedia.name;
                    auxiliarNombre = VideoNombreActual;
                    String[] porVer = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    String[] vacio;
                    foreach (String linea in porVer)
                    {
                        vacio = linea.Split('{');
                        if (vacio[0] == auxiliarNombre)
                        {
                            wmpCentral.Ctlcontrols.currentPosition = double.Parse(vacio[1]);
                            // axvlcControl.input.time = double.Parse(vacio[1]);
                        }
                        else
                        {
                            StreamWriter escribir = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt");
                            escribir.WriteLine(vacio[0] + "{" + vacio[1]);
                            escribir.Close();
                        }
                    }
                    File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    File.Move(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt", Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt"))
                    {
                        File.CreateText(Application.StartupPath + @"\See More\Usuarios SeeMore\temp.txt");
                    }
                    entra = true;
                    nombre = true;
                    ruta = string.Empty;
                    try
                    {
                        StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                        escribir.Flush(); escribir.Close();
                        sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                        sw2 = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt");
                        sw.WriteLine(VideoNombreActual + "");
                        String b = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                        sw2.WriteLine(VideoNombreActual + " " + b);
                        sw.Close();
                        sw2.Close();
                        if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt"))
                        {
                            if (Configuracion.DatosReproductor.hayIntercambio)
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(VideoNombreActual + " " + b);
                                sw3.Close();
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosReproductor.UsuarioTemporal + ".txt");
                                sw3.WriteLine(VideoNombreActual + " " + b);
                                sw3.Close();
                            }
                            else
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(VideoNombreActual + " " + b);
                                sw3.Close();
                            }
                        }
                        else
                        {
                            if (Configuracion.DatosReproductor.hayIntercambio)
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(VideoNombreActual + " " + b);
                                sw3.Close();
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + Configuracion.DatosReproductor.UsuarioTemporal + ".txt");
                                sw3.WriteLine(VideoNombreActual + " " + b);
                                sw3.Close();
                            }
                            else
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(VideoNombreActual + " " + b);
                                sw3.Close();
                            }
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void tmrGuardarAuto_Tick(object sender, EventArgs e)
        {
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

            }
            if (wmpCentral.playState == WMPLib.WMPPlayState.wmppsPaused)
            {

            }
        }
    }
}