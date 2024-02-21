using System;
using System.Windows.Forms;
using System.IO;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Iniciar_Sesion : Form
    {
        int tamaño;
        public Iniciar_Sesion()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 393;
            this.Height = 136;
            String[] users = File.ReadAllLines(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
            tamaño = (users.Length * 4) / 4;
            int contador = 0;
            Configuracion.DatosInicioSesionAuto.UsuariosNombre = new string[tamaño];
            Configuracion.DatosInicioSesionAuto.UsuariosContra = new string[tamaño];
            Configuracion.DatosInicioSesionAuto.UsuariosImagen = new string[tamaño];
            Configuracion.DatosInicioSesionAuto.UsuariosSexo = new string[tamaño];
            foreach (String linea in users)
            {
                //Aqui hay un error, tratar de no reescribir sobre el arreglo
                Configuracion.DatosInicioSesionAuto.Usuarios = linea.Split(';');
                Configuracion.DatosInicioSesionAuto.UsuariosNombre[contador] = Configuracion.DatosInicioSesionAuto.Usuarios[0];
                Configuracion.DatosInicioSesionAuto.UsuariosContra[contador] = Configuracion.DatosInicioSesionAuto.Usuarios[1];
                Configuracion.DatosInicioSesionAuto.UsuariosImagen[contador] = Configuracion.DatosInicioSesionAuto.Usuarios[2];
                Configuracion.DatosInicioSesionAuto.UsuariosSexo[contador] = Configuracion.DatosInicioSesionAuto.Usuarios[3];
                contador += 1;
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Boolean sinCoencidencia = false;
                for (int j = 0; j < tamaño; j++)
                {
                    string res = string.Empty;
                    byte[] decryted = Convert.FromBase64String(Configuracion.DatosInicioSesionAuto.UsuariosContra[j]);
                    res = System.Text.Encoding.Unicode.GetString(decryted);
                    if (Configuracion.DatosInicioSesionAuto.UsuariosNombre[j] == txtUsuario.Text && res == txtContraseña.Text)
                    {
                        sinCoencidencia = true;
                        Configuracion.DatosUsuario.Usuario = Configuracion.DatosInicioSesionAuto.UsuariosNombre[j];
                        Configuracion.DatosUsuario.Contraseña = res;
                        Configuracion.DatosUsuario.Imagen = Configuracion.DatosInicioSesionAuto.UsuariosImagen[j];
                        Configuracion.DatosUsuario.Sexo = Configuracion.DatosInicioSesionAuto.UsuariosSexo[j];
                        string resulta = string.Empty;
                        byte[] desin = Convert.FromBase64String(Configuracion.DatosUsuario.Imagen);
                        resulta = System.Text.Encoding.Unicode.GetString(desin);
                        Configuracion.Informacion.ImagenUsable = resulta;
                        Configuracion.Informacion.loCerroelUsuario = false;
                        this.Close();
                        break;
                    }
                }
                if (sinCoencidencia == false)
                {
                    MessageBox.Show("El Usuario y/o Contraseña estan mal, intente de nuevo");
                }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
        }
        private void Iniciar_Sesion_Load(object sender, EventArgs e)
        {
            if (Configuracion.DatosUsuario.Usuario != "" && Configuracion.DatosUsuario.Contraseña != "")
            {
                txtUsuario.Text = Configuracion.DatosUsuario.Usuario;
                txtContraseña.Text = Configuracion.DatosUsuario.Contraseña;
                iniciarSesiónToolStripMenuItem.PerformClick();
            }
        }
        private void Iniciar_Sesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tu_perfil fmr = new Tu_perfil();
            fmr.Close();
        }
        private void Iniciar_Sesion_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                iniciarSesiónToolStripMenuItem.PerformClick();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                iniciarSesiónToolStripMenuItem.PerformClick();
        }
    }
}
