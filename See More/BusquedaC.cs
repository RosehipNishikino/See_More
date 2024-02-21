using System;
using System.IO;
using System.Windows.Forms;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class BusquedaC : Form
    {
        public String NombreUsuario { get; set; }
        int tamaño;
        public BusquedaC()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
                dgvDatos.Visible = false;
                lblNombre.Visible = true;
                lblDatos.Visible = true;
                txtUsuario.Visible = true;
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
        private void button1_Click(object sender, EventArgs e)
        {
                Boolean sinCoencidencia = false;
                for (int j = 0; j < tamaño; j++)
                {
                    if (Configuracion.DatosInicioSesionAuto.UsuariosNombre[j]==txtUsuario.Text.Trim())
                    {
                        sinCoencidencia = true;
                        NombreUsuario = Configuracion.DatosInicioSesionAuto.UsuariosNombre[j];
                        this.Close();
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
