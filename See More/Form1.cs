using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.IO;
using MODELOS_SEEMORE;

namespace See_More
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        StreamWriter sw;
        StreamWriter sw2; String todo; String extension = string.Empty; String usuario;
        StreamWriter sw3;
        int contador = 1;
        bool entra = true;
        bool nombre = true; String ruta;
        String auxiliarNombre = string.Empty;
        String duracionFinal = string.Empty;
        public Seemore AnimeActual { get; set; }
        public Boolean respuesta { get; set; }
        public String NombreVideo1 { get; set; }
        public String RutaVideo1 { get; set; }
        public String UsuarioRegistrado1 { get; set; }
        public String UsuarioImagen1 { get; set; }
        public Boolean intercambio { get; set; }
        public String UserTemp { get; set; }
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
        }
        private void ActivateButton(Object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //leftborder
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                btnCurrentChildForm.IconChar = currentBtn.IconChar;
                btnCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.Navy;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Buscar frm = new Buscar();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(frm);
            panelDesktop.Tag = frm;
            frm.BringToFront();
            frm.ShowDialog();
            //OpenChildForm( new Buscar());
            try
            {
                if (frm.AnimeSeleccionado != null)
                {
                    AnimeActual = frm.AnimeSeleccionado;
                    todo = "" + frm.AnimeSeleccionado.Nombre + " - " + frm.cuentaSeleccionado.usuario;
                    auxiliarNombre = frm.AnimeSeleccionado.Nombre;
                    usuario = "" + frm.cuentaSeleccionado.usuario;
                    intercambio = frm.hayIntercambio;
                    UserTemp = frm.UsuarioTemporal;
                    string result = string.Empty;
                    byte[] decryted = Convert.FromBase64String(frm.AnimeSeleccionado.URL);
                    result = System.Text.Encoding.Unicode.GetString(decryted);
                    extension = result;
                    String[] porVer = File.ReadAllLines(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + "Inte.txt");
                    String[] vacio;
                    if (extension.EndsWith("wpl"))
                    {
                        wmpCentral.URL = result;
                        this.Text = "Viendo - " + todo + " Capitulo: " + contador;
                    }
                    else if (extension.EndsWith("avi"))
                    {
                        wmpCentral.URL = result;
                        this.Text = "Viendo - " + todo;
                    }
                    else
                    {
                        wmpCentral.URL = result;
                        this.Text = "Viendo - " + todo;
                    }
                    tmrProgreso.Start();
                    tmrGuardarAuto.Start();
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
                    string resulta = string.Empty;
                    byte[] decrytede = Convert.FromBase64String(frm.cuentaSeleccionado.imagen);
                    resulta = System.Text.Encoding.Unicode.GetString(decrytede);
                    //picUsuario.Image = Image.FromFile(resulta);
                    entra = true;
                    nombre = true;
                    ruta = string.Empty;
                    try
                    {
                        StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                        escribir.Flush(); escribir.Close();
                        sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                        sw2 = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt");
                        sw.WriteLine(frm.AnimeSeleccionado.Nombre + "");
                        String b = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                        sw2.WriteLine(frm.AnimeSeleccionado.Nombre + " " + b);
                        sw.Close();
                        sw2.Close();
                        if (intercambio == true)
                        {
                            if (File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt"))
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(frm.AnimeSeleccionado.Nombre + " " + b);
                                sw3.Close();
                            }
                            if (File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + UserTemp + ".txt"))
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + UserTemp + ".txt");
                                sw3.WriteLine(frm.AnimeSeleccionado.Nombre + " " + b);
                                sw3.Close();
                            }
                        }
                        else
                        {
                            if (File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt"))
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(frm.AnimeSeleccionado.Nombre + " " + b);
                                sw3.Close();
                            }
                        }
                    }

                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                }
                else
                {
                    if (frm.NombreVideo != null && frm.RutaVideo != null)
                    {
                        NombreVideo1 = frm.NombreVideo;
                        RutaVideo1 = frm.RutaVideo;
                        UsuarioRegistrado1 = frm.UsuarioRegistrado;
                        UsuarioImagen1 = frm.UsuarioImagen;
                        todo = "" + frm.NombreVideo + " - " + frm.UsuarioRegistrado;
                        auxiliarNombre = frm.NombreVideo;
                        usuario = "" + frm.UsuarioRegistrado;
                        extension = frm.RutaVideo;
                        if (extension.EndsWith("wpl"))
                        {
                            wmpCentral.URL = frm.RutaVideo;
                            this.Text = "Viendo - " + todo + " Capitulo: " + contador;
                        }
                        else
                        {
                            wmpCentral.URL = frm.RutaVideo;
                            this.Text = "Viendo - " + todo;
                        }
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
                        string resulta = string.Empty;
                        byte[] decrytede = Convert.FromBase64String(frm.UsuarioImagen);
                        resulta = System.Text.Encoding.Unicode.GetString(decrytede);
                        //picUsuario.Image = Image.FromFile(resulta);
                        entra = true;
                        nombre = true;
                        ruta = string.Empty;
                        try
                        {
                            StreamWriter escribir = new StreamWriter(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                            escribir.Flush(); escribir.Close();
                            sw = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\visto.txt");
                            sw2 = File.AppendText(Application.StartupPath + @"\See More\Configuraciones SeeMore\historial.txt");
                            sw.WriteLine(frm.NombreVideo + "");
                            String b = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                            sw2.WriteLine(frm.NombreVideo + " " + b);
                            sw.Close();
                            sw2.Close();
                            if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt"))
                            {

                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(frm.NombreVideo + " " + b);
                                sw3.Close();
                            }
                            else
                            {
                                sw3 = File.AppendText(Application.StartupPath + @"\See More\Usuarios SeeMore\" + usuario + ".txt");
                                sw3.WriteLine(frm.NombreVideo + " " + b);
                                sw3.Close();
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

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Crear_Cuenta());
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Iniciar_Sesion());
        }

        private void btnPersonalizacion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Imagenes_de_fondo());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Historial());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            btnCurrentChildForm.IconChar = IconChar.Home;
            btnCurrentChildForm.IconColor = Color.Silver;
            lblTitleChildForm.Text = "See More";
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
