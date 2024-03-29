﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Crear_Cuenta : Form
    {
        public Boolean cerrar { get; set; }
        public String nombreUsuario { get; set; }
        String imagenPerfil = string.Empty;
        public Crear_Cuenta()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            String line;
            try
            {
                StreamReader rd = new StreamReader(Application.StartupPath + @"\See More\Configuraciones SeeMore\crearcuenta.txt");
                line = rd.ReadLine();
                this.BackgroundImage = Image.FromFile(line);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                rd.Close();
            }
            catch (Exception) { }
        }        
        private void crearUsuarioNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "" && txtRepetirContraseña.Text != "" && picImagen.Image != null && (rdoHombre.Checked || rdoMujer.Checked || (rdoOtro.Checked && txtOtro.Text != "")))
            {
                if (txtContraseña.Text == txtRepetirContraseña.Text)
                {
                        if (!ExisteUsuario(txtUsuario.Text))
                        {
                            string resultado = string.Empty;
                            byte[] encrytedo = System.Text.Encoding.Unicode.GetBytes(txtContraseña.Text);
                            resultado = Convert.ToBase64String(encrytedo);
                            string result = string.Empty;
                            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(imagenPerfil);
                            result = Convert.ToBase64String(encryted);
                            StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                            if (rdoHombre.Checked)
                                sw.WriteLine(txtUsuario.Text.Trim() + ";" + resultado.Trim() + ";" + result.Trim() + ";" + rdoHombre.Text.Trim());
                            if (rdoMujer.Checked)
                                sw.WriteLine(txtUsuario.Text.Trim() + ";" + resultado.Trim() + ";" + result.Trim() + ";" + rdoMujer.Text.Trim());
                            if (rdoOtro.Checked)
                                sw.WriteLine(txtUsuario.Text.Trim() + ";" + resultado.Trim() + ";" + result.Trim() + ";" + txtOtro.Text.Trim());
                            sw.Close();
                            StreamWriter creaciones = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\creaciones.txt");
                            if (rdoHombre.Checked)
                                creaciones.WriteLine(txtUsuario.Text.Trim() + ";" + txtContraseña.Text.Trim() + ";" + result.Trim() + ";" + rdoHombre.Text.Trim());
                            if (rdoMujer.Checked)
                                creaciones.WriteLine(txtUsuario.Text.Trim() + ";" + txtContraseña.Text.Trim() + ";" + result.Trim() + ";" + rdoMujer.Text.Trim());
                            if (rdoOtro.Checked)
                                creaciones.WriteLine(txtUsuario.Text.Trim() + ";" + txtContraseña.Text.Trim() + ";" + result.Trim() + ";" + txtOtro.Text.Trim());
                            creaciones.Close();
                            File.Create(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + ".txt");
                            if (!File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Imagen.txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Busqueda.txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Animes.txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Inte.txt") &&
                                !File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Ruta.txt"))
                            {
                                File.Create(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Imagen.txt");
                                File.Create(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Busqueda.txt");
                                File.Create(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Animes.txt");
                                File.Create(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Inte.txt");
                                File.Create(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtUsuario.Text.Trim() + "Ruta.txt");
                            }
                            MessageBox.Show("Se ha creado su cuenta, proceda a loguearse en la parte Iniciar Sesión");
                            Limpiar();
                        }else
                            MessageBox.Show("El usuario ya ha sido creado", "Error al crear nuevo usuario");
                }
            }
            else
            {
                MessageBox.Show("Hay un campo vacio, busquelo");
            }
        }
        private void buscarUnUsuarioCreadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaC frm = new BusquedaC();
            frm.ShowDialog();
                if(frm.NombreUsuario != null)
                {
                    nombreUsuario = frm.NombreUsuario;
                    txtEliminarUser.Text = frm.NombreUsuario;
                }
        }
        private void eliminarElUsuarioCreadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (txtEliminarUser.Text == "")
                {
                    MessageBox.Show("No se ha buscado ningún usuario creado para eliminar", "Falló al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
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
                        if (txtEliminarUser.Text.Trim() != Configuracion.DatosInicioSesionTemp.TempNombre[contador])
                        {
                            StreamWriter sw = File.AppendText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
                            sw.WriteLine(Configuracion.DatosInicioSesionTemp.TempNombre[contador] + ";" + Configuracion.DatosInicioSesionTemp.TempContra[contador] + ";" + Configuracion.DatosInicioSesionTemp.TempImagen[contador] + ";" + Configuracion.DatosInicioSesionTemp.TempSexo[contador]);
                            sw.Close();
                        }
                        contador += 1;
                    }
                    File.Delete(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                    File.Move(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt", Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
                    if (!File.Exists(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt"))
                    {
                        File.CreateText(Application.StartupPath + @"\See More\Inicios SeeMore\temp.txt");
                    }
                    if (File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + ".txt") &&
                                    File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Imagen.txt") &&
                                    File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Busqueda.txt") &&
                                    File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Animes.txt") &&
                                    File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Inte.txt") &&
                                    File.Exists(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Ruta.txt"))
                    {
                        File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + ".txt");
                        File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Imagen.txt");
                        File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Busqueda.txt");
                        File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Animes.txt");
                        File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Inte.txt");
                        File.Delete(Application.StartupPath + @"\See More\Usuarios SeeMore\" + txtEliminarUser.Text.Trim() + "Ruta.txt");
                    }
                    MessageBox.Show("Se ha eliminado la Cuenta exitosamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtContraseña.Text == txtRepetirContraseña.Text)
            {
                lblComprobacion.Text = "La contraseña es igual";
            }
            else
            {
                lblComprobacion.Text = "La contraseña no es igual";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos de imagen jpg|*.jpg| Archivos de imagen png|*.png";
            abrir.FileName = "Imagenes";
            abrir.Title = "Imagen";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string direccion = abrir.FileName;
                imagenPerfil = direccion;
                picImagen.Image = Image.FromFile(direccion);
                txtUsuario.Focus();
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Enabled = true;
        }
        private void rdoMujer_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Enabled = false;
        }
        private void rdoHombre_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Enabled = false;
        }
        public Boolean ExisteUsuario(String nombre)
        {
            Boolean exiUser = false;
            String[] usuarios = File.ReadAllLines(Application.StartupPath + @"\See More\Inicios SeeMore\Usuarios Creados.txt");
            foreach (String usuario in usuarios)
            {
                String[] var = usuario.Split(';');
                if (var[0].Equals(nombre))
                {
                    exiUser = true;
                    break;
                }
            }
            if (exiUser)
                return true;
            else
                return false;
        }
        public void Limpiar()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtRepetirContraseña.Clear();
            rdoHombre.Checked = false;
            rdoMujer.Checked = false;
            rdoOtro.Checked = false;
            txtOtro.Clear();
            picImagen.Image = null; imagenPerfil = string.Empty;
            txtEliminarUser.Clear();
        }

        private void Crear_Cuenta_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                crearUsuarioNuevoToolStripMenuItem.PerformClick();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                crearUsuarioNuevoToolStripMenuItem.PerformClick();
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                crearUsuarioNuevoToolStripMenuItem.PerformClick();
        }

        private void rdoHombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                crearUsuarioNuevoToolStripMenuItem.PerformClick();
        }

        private void rdoMujer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                crearUsuarioNuevoToolStripMenuItem.PerformClick();
        }

        private void rdoOtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                crearUsuarioNuevoToolStripMenuItem.PerformClick();
        }

        private void txtOtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                crearUsuarioNuevoToolStripMenuItem.PerformClick();
        }
    }
}
