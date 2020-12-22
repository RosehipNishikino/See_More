using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MODELOS_SEEMORE;
using System.Data;
using System.Security.Cryptography;

namespace DATOS_SEEMORE
{
    public class CuentaSeeMore
    {
        public static Cuenta usuarioSelec { get; set; }
        public static int AgregarC(Cuenta pSee)
        {
            int retorno = 0;
            string sql = "Insert into Cuenta (Clave, Nombre, Contraseña, Imagen, Genero) values (@Clave, @Nombre, @Contraseña, @Imagen, @Genero)";
            MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Clave", pSee.ID);
            comando.Parameters.AddWithValue("@Nombre", pSee.usuario);
            comando.Parameters.AddWithValue("@Contraseña", pSee.contraseña);
            comando.Parameters.AddWithValue("@Imagen", pSee.imagen);
            comando.Parameters.AddWithValue("@Genero", pSee.genero);
            try
            {
                Conexion.ObtenerConexion();

                retorno = comando.ExecuteNonQuery();
            }

            catch (MySqlException) { }
            finally
            {
                comando.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
        public static Boolean CompartirInformacion(String Usuario, String Contraseña)
        {
            if (Usuario != "" && Contraseña != "")
            {
                String sql = "select Nombre, Contraseña from cuenta where Nombre=@Nombre and Contraseña=@Contraseña";
                MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@Nombre", Usuario);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static Boolean InicioSesion(String Usuario, String Contraseña)
        {
            if (Usuario != "" && Contraseña != "")
            {
                String sql = "select Nombre, Contraseña from cuenta where Nombre=@Nombre and Contraseña=@Contraseña";
                MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
                MySqlCommand coman = new MySqlCommand(sql, Conexion.ObtenerConexion());
                comando.Parameters.AddWithValue("@Nombre", Usuario);
                coman.Parameters.AddWithValue("@Nombre", Usuario);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);
                coman.Parameters.AddWithValue("@Contraseña", Contraseña);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.Read() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static List<Cuenta> BuscarImagen(String Nombre)
        {
            List<Cuenta> pCuenta = new List<Cuenta>();
            string sql = "select Clave, Nombre, Genero from Cuenta where Nombre=@Nombre";
            MySqlCommand coamndo = new MySqlCommand(sql, Conexion.ObtenerConexion());
            coamndo.Parameters.AddWithValue("@Nombre", Nombre);
            MySqlDataReader reader = coamndo.ExecuteReader();
            while (reader.Read())
            {
                Cuenta cuenta = new Cuenta();
                cuenta.ID = reader.GetInt32(0);
                cuenta.usuario = reader.GetString(1);
                cuenta.genero = reader.GetString(2);
                pCuenta.Add(cuenta);
            }
            coamndo.Dispose();
            Conexion.ObtenerConexion().Close();
            Conexion.ObtenerConexion().Dispose();
            return pCuenta;
        }
        public static List<Cuenta> BuscarTC()
        {
            List<Cuenta> lista = new List<Cuenta>();
            MySqlCommand comando = new MySqlCommand(string.Format("select Clave, Nombre from cuenta"), Conexion.ObtenerConexion());
            try
            {

                MySqlConnection conn = Conexion.ObtenerConexion();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Cuenta pSeemore = new Cuenta();
                        pSeemore.ID = reader.GetInt32(0);
                        pSeemore.usuario = reader.GetString(1);
                        lista.Add(pSeemore);
                    }
                }
                else
                {

                }

            }
            catch (MySqlException) { }
            finally
            {
                comando.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return lista;
        }
        public static Cuenta ObtenerImagen(String nombre)
        {
            Cuenta pCu = new Cuenta();
            string sql = "select Clave, Nombre, Contraseña, Imagen, Genero from Cuenta where Nombre=@Nombre";
            MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Nombre", nombre);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                pCu.ID = reader.GetInt32(0);
                pCu.usuario = reader.GetString(1);
                pCu.contraseña = reader.GetString(2);
                pCu.imagen = reader.GetString(3);
                pCu.genero = reader.GetString(4);
            }
            comando.Dispose();
            Conexion.ObtenerConexion().Close();
            Conexion.ObtenerConexion().Dispose();
            return pCu;
        }
        public static Cuenta ObtenerC(int clave)
        {
            Cuenta pSee = new Cuenta();
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string sql = "select Clave, Nombre, Contraseña, Imagen, Genero from Cuenta where Clave=@Clave";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Clave", clave);
            try
            {
                Conexion.ObtenerConexion();

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pSee.ID = reader.GetInt32(0);
                    pSee.usuario = reader.GetString(1);
                    pSee.contraseña = reader.GetString(2);
                    pSee.imagen = reader.GetString(3);
                    pSee.genero = reader.GetString(4);
                }
                conexion.Close();

            }
            catch (MySqlException) { }
            finally
            {
                comando.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return pSee;
        }
        public static int actualizarC(Cuenta see)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string sql = "update cuenta set Clave=@Clave, Nombre=@Nombre, Contraseña=@Contraseña, Imagen=@Imagen, Genero=@Genero where Clave=@Clave";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Clave", see.ID);
            comando.Parameters.AddWithValue("@Nombre", see.usuario);
            comando.Parameters.AddWithValue("@Contraseña", see.contraseña);
            comando.Parameters.AddWithValue("@Imagen", see.imagen);
            comando.Parameters.AddWithValue("@Genero", see.genero);
            try
            {
                Conexion.ObtenerConexion();

                retorno = comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (MySqlException) { }
            finally
            {
                comando.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
        public static int actualizarC2(Cuenta see)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string sql = "update cuenta set Nombre=@Nombre, Contraseña=@Contraseña, Imagen=@Imagen, Genero=@Genero where Nombre=@Nombre";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Nombre", see.usuario);
            comando.Parameters.AddWithValue("@Contraseña", see.contraseña);
            comando.Parameters.AddWithValue("@Imagen", see.imagen);
            comando.Parameters.AddWithValue("@Genero", see.genero);
            try
            {
                Conexion.ObtenerConexion();

                retorno = comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (MySqlException) { }
            finally
            {
                comando.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
        public static int EliminarC(int ID)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string sql = "delete from cuenta where Clave=@Clave";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Clave", ID);
            try
            {
                Conexion.ObtenerConexion();

                retorno = comando.ExecuteNonQuery();
                conexion.Close();

            }
            catch (MySqlException) { }
            finally
            {
                comando.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
    }
}
