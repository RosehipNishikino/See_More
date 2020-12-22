using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MODELOS_SEEMORE;

namespace DATOS_SEEMORE
{
    public class ListasSeeMore
    {
        public static int AgregarLista(Seemore pSee)
        {
            int retorno = 0;
            string sql = "Insert into lista (ID, Nombre, URL) values (@ID, @Nombre, @URL)";
            MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@ID", pSee.ID);
            comando.Parameters.AddWithValue("@Nombre", pSee.Nombre);
            comando.Parameters.AddWithValue("@URL", pSee.URL);
            try
            {
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
        public static List<Seemore> BuscarLista(String pID)
        {
            List<Seemore> lista = new List<Seemore>();
            string sql = "select ID, Nombre, URL from Lista where ID=@ID";
            MySqlCommand comando = new MySqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@ID", pID);
            try
            {
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
        public static List<Seemore> BuscarTL()
        {
            List<Seemore> lista = new List<Seemore>();
            MySqlCommand comando = new MySqlCommand(string.Format("select * from lista"), Conexion.ObtenerConexion());
            try
            {
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
        public static List<Seemore> BuscarUltimaLista()
        {
            List<Seemore> lista = new List<Seemore>();
            MySqlCommand comando = new MySqlCommand(string.Format("select * from lista order by ID desc limit 1"), Conexion.ObtenerConexion());
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
        public static List<Seemore> BuscarNombreLista(String nombre)
        {
            List<Seemore> lista = new List<Seemore>();
            string sql = "select ID, Nombre, URL from lista where Nombre regexp @Nombre";
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
        public static Seemore ObtenerI()
        {
            Seemore pSee = new Seemore();
            MySqlConnection conexion = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("select * from lista order by ID desc limit 1"), conexion);
            try
            {
                Conexion.ObtenerConexion();

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    pSee.URL = reader.GetString(0);
                }
                conexion.Close();

            }
            catch (MySqlException) { }
            comando.Dispose();
            Conexion.ObtenerConexion().Close();
            Conexion.ObtenerConexion().Dispose();
            return pSee;
        }
        public static Seemore ObtenerLista(int clave)
        {
            Seemore pSee = new Seemore();
            MySqlConnection conexion = Conexion.ObtenerConexion();
            string sql = "select ID, Nombre, URL from lista where ID=@ID";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Clave", clave);
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
    }
}
