﻿using System;
using System.Windows.Forms;
using System.IO;
using MODELOS_SEEMORE;
using DATOS_SEEMORE;

namespace See_More
{
    public partial class Comprobar : Form
    {
        int tamaño;
        public Comprobar()
        {
            InitializeComponent();
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
        public Cuenta usuarioSeleccionado { get; set; }
        public String Usuario { get; set; }
        public String Imagen { get; set; }
        public String Sexo { get; set; }
        public String Contraseña { get; set; }
        private void inicioDeComprabacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == Configuracion.usuario && txtContraseña.Text == Configuracion.contraseña)
            {
                try
                {
                    if (CuentaSeeMore.InicioSesion(txtUsuario.Text,txtContraseña.Text))
                    {
                        dgvDatos.DataSource = CuentaSeeMore.BuscarImagen(txtUsuario.Text);
                        dgvDatos.Rows[0].Selected = true;
                        dgvDatos.CurrentCell = dgvDatos.Rows[0].Cells[0];
                        if (dgvDatos.SelectedRows.Count == 1)
                        {
                            int Nombre = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
                            usuarioSeleccionado = CuentaSeeMore.ObtenerC(Nombre);
                            MessageBox.Show("Usuario " + txtUsuario.Text + " Comprobado");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario y/o contraseña estan mal, intente de nuevo");
                    }
                }
                catch (Exception)
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
                            Usuario = Configuracion.UsuariosNombre[j];
                            Contraseña = res;
                            Imagen = Configuracion.UsuariosImagen[j];
                            Sexo = Configuracion.UsuariosSexo[j];
                            Configuracion.loCerroelUsuario = false;
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
                finally
                {

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

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion.loCerroelUsuario = true;
            this.Close();
        }
    }
}