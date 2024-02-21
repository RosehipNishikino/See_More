using System;
using System.Windows.Forms;
using System.IO;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Comprobar : Form
    {
        int tamaño;
        public Comprobar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private void inicioDeComprabacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == Configuracion.DatosUsuario.Usuario && txtContraseña.Text == Configuracion.DatosUsuario.Contraseña)
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
                            Configuracion.Informacion.loCerroelUsuario = false;
                            MessageBox.Show("Usuario " + txtUsuario.Text + " Comprobado");
                            this.Close();
                            break;
                        }
                    }
                    if (sinCoencidencia == false)
                    {
                        MessageBox.Show("El Usuario y/o Contraseña estan mal, intente de nuevo");
                    }
            }
            else
            {
                MessageBox.Show("Hay un error en la comprobación del usuario, datos incorrectos");
            }
        }
        private void Comprobar_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
