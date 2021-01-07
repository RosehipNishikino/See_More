using System;
using System.IO;
using System.Windows.Forms;
using MODELOS_SEEMORE;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class BusquedaC : Form
    {
        public Cuenta cuentaseleccionada { get; set; }
        public String NombreUsuario { get; set; }
        int tamaño;
        public BusquedaC()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            if(Configuracion.existeConexion)
            {
                dgvDatos.DataSource = CuentaSeeMore.BuscarTC();
            }
            else {
                dgvDatos.Visible = false;
                lblNombre.Visible = true;
                lblDatos.Visible = true;
                txtUsuario.Visible = true;
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
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Configuracion.existeConexion)
            {
                if (dgvDatos.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                    cuentaseleccionada = CuentaSeeMore.ObtenerC(id);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Se debe seleccionar un usuario creado para su eliminación");
                }
            }
            else
            {
                Boolean sinCoencidencia = false;
                for (int j = 0; j < tamaño; j++)
                {
                    if (Configuracion.UsuariosNombre[j]==txtUsuario.Text.Trim())
                    {
                        sinCoencidencia = true;
                        NombreUsuario = Configuracion.UsuariosNombre[j];
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
}
