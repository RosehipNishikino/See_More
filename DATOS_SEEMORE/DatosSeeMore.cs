using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using MODELOS_SEEMORE;

namespace DATOS_SEEMORE
{
    public class DatosSeeMore
    {
        public static int Agregar(Seemore pSee)
        {
            int retorno = 0;
            string sql = "Insert into animes (ID, Nombre, URL) values (@ID, @Nombre, @URL)";
            MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@ID", pSee.ID);
            comando.Parameters.AddWithValue("@Nombre", pSee.Nombre);
            comando.Parameters.AddWithValue("@URL", pSee.URL);
            try
            {
                Conexion.ObtenerConexion();

                retorno = comando.ExecuteNonQuery();
            }
            catch (MySqlException)
            {

            }
            finally
            {
                comando.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
        public static List<Seemore> BuscarPorOrden()
        {
            List<Seemore> lista = new List<Seemore>();
            string sql = "select * from animes order by Nombre";
            MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Seemore pSeeMore = new Seemore();
                pSeeMore.ID = reader.GetInt32(0);
                pSeeMore.Nombre = reader.GetString(1);
                pSeeMore.URL = reader.GetString(2);
                lista.Add(pSeeMore);
            }
            comando.Dispose();
            Conexion.ObtenerConexion().Close();
            Conexion.ObtenerConexion().Dispose();
            return lista;
        }
        public static List<Seemore> BusquedaContraria()
        {
            List<Seemore> lista = new List<Seemore>();
            String comando = "select * from animes where ";
            for (int j = 0; j < Configuracion.totales - 1; j++)
            {
                comando = comando + "NOT Nombre REGEXP '" + Configuracion.Animes[j] + "' && ";
            }
            comando = comando + "NOT Nombre REGEXP '" + Configuracion.Animes[Configuracion.totales - 1] + "'";
            MySqlCommand comando2 = new MySqlCommand(comando, Conexion.ObtenerConexion());
            MySqlDataReader reader = comando2.ExecuteReader();
            while (reader.Read())
            {
                Seemore pSee = new Seemore();
                pSee.ID = reader.GetInt32(0);
                pSee.Nombre = reader.GetString(1);
                pSee.URL = reader.GetString(2);
                lista.Add(pSee);
            }
            comando2.Dispose();
            Conexion.ObtenerConexion().Close();
            Conexion.ObtenerConexion().Dispose();
            return lista;
        }
        public static List<Seemore> BuscarT()
        {
            List<Seemore> lista = new List<Seemore>();
            MySqlCommand comando = new MySqlCommand(string.Format("select * from animes"), Conexion.ObtenerConexion());
            try
            {
                Conexion.ObtenerConexion();

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Seemore pSeemore = new Seemore();
                    pSeemore.ID = reader.GetInt32(0);
                    pSeemore.Nombre = reader.GetString(1);
                    pSeemore.URL = reader.GetString(2);
                    lista.Add(pSeemore);
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
        public static List<Seemore> BuscarUltimo()
        {
            List<Seemore> lista = new List<Seemore>();
            MySqlCommand comando = new MySqlCommand(string.Format("select * from animes order by ID desc limit 1"), Conexion.ObtenerConexion());
            try
            {
                Conexion.ObtenerConexion();

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Seemore pSeemore = new Seemore();
                    pSeemore.ID = reader.GetInt32(0);
                    pSeemore.Nombre = reader.GetString(1);
                    pSeemore.URL = reader.GetString(2);
                    lista.Add(pSeemore);
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
        public static List<Seemore> BuscarNombre(String nombre)
        {
            List<Seemore> lista = new List<Seemore>();
            string sql = "select ID, Nombre, URL from animes where Nombre regexp @Nombre";
            MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Nombre", nombre);
            try
            {
                Conexion.ObtenerConexion();

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Seemore pSeemore = new Seemore();
                    pSeemore.ID = reader.GetInt32(0);
                    pSeemore.Nombre = reader.GetString(1);
                    pSeemore.URL = reader.GetString(2);
                    lista.Add(pSeemore);
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
        public static Seemore Obtener(int clave)
        {
            Seemore pSee = new Seemore();
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string sql = "select ID, Nombre, URL from animes where ID=@ID";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ID", clave);
            try
            {
                Conexion.ObtenerConexion();

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pSee.ID = reader.GetInt32(0);
                    pSee.Nombre = reader.GetString(1);
                    pSee.URL = reader.GetString(2);
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
        public static int actualizar(Seemore see)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string sql = "update animes set ID=@ID, Nombre=@Nombre, URL=@URL Where Clave=@Clave";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ID", see.ID);
            comando.Parameters.AddWithValue("@Nombre", see.Nombre);
            comando.Parameters.AddWithValue("@URL", see.URL);
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
        public static int Eliminar(int ID)
        {
            int retorno = 0;
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string sql = "delete from animes where ID=@ID";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ID", ID);
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
