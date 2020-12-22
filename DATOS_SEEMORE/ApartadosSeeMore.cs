using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MODELOS_SEEMORE;

namespace DATOS_SEEMORE
{
    public class ApartadosSeeMore
    {
        /// <summary>
        /// Recibe el nombre del apartado y retorna si lo creo o no
        /// </summary>
        /// <param name="nombre">Recibe el nombre del apartado</param>
        /// <returns>Retorna 1 en caso de exito y 0 de lo contrario</returns>
        public static int CrearApartado(String nombre)
        {
            int retorno = 0;
            String comandoA = "create table @Tabla (ID INT PRIMARY KEY AUTO_INCREMENT, Nombre VARCHAR(255), URL VARCHAR(255))";
            MySqlCommand comandoB = new MySqlCommand(comandoA, Conexion.ObtenerConexion());
            comandoB.Parameters.AddWithValue("@Tabla", nombre);
            try
            {
                retorno = comandoB.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                comandoB.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
        /// <summary>
        /// Recibe un nombre y un objeto SeeMore para agregar al apartado
        /// </summary>
        /// <param name="nombre">Nombre del apartado</param>
        /// <param name="pSee">Objeto SeeMore</param>
        /// <returns>Regresa 1 en caso de exito y 0 de lo contrario</returns>
        public static int AgregarEnApartado(String nombre, Seemore pSee)
        {
            int retorno = 0;
            String comandoA = "Insert into @Tabla (ID, Nombre, URL) values (@ID, @Nombre, @URL)";
            MySqlCommand comandoB = new MySqlCommand(comandoA, Conexion.ObtenerConexion());
            comandoB.Parameters.AddWithValue("@Tabla", nombre);
            comandoB.Parameters.AddWithValue("@ID", pSee.ID);
            comandoB.Parameters.AddWithValue("@Nombre", pSee.Nombre);
            comandoB.Parameters.AddWithValue("@URL", pSee.URL);
            try
            {
                retorno = comandoB.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                comandoB.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
        /// <summary>
        /// Recibe el apartado creado mas el nombre de la serie a mover
        /// </summary>
        /// <param name="nombre">Nombre del apartado</param>
        /// <param name="nameSerie">Nombre de la serie</param>
        /// <returns>Regresa 1 en caso de exito y 0 de lo contrario</returns>
        public static int MoverAlApartado(String nombre, String nameSerie)
        {
            int retorno = 0;
            String comandoA = "Insert Into @Tabla Select * From animes Where Nombre REGEXP @NombreSerie";
            MySqlCommand comandoB = new MySqlCommand(comandoA, Conexion.ObtenerConexion());
            comandoB.Parameters.AddWithValue("@Tabla", nombre);
            comandoB.Parameters.AddWithValue("@NombreSerie", nameSerie);
            try
            {
                retorno = comandoB.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                comandoB.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
        /// <summary>
        /// Recibe un nombre de apartado y busca el contenido del apartado
        /// </summary>
        /// <param name="nombre">Nombre del apartado</param>
        /// <returns>Regresa la lista completa de datos del apartado buscado</returns>
        public static List<Seemore> BuscarEnElApartado(String nombre)
        {
            String comandoA = "Select * From @Tabla";
            List<Seemore> lista = new List<Seemore>();
            MySqlCommand comando = new MySqlCommand(comandoA, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@Tabla", nombre);
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
        public static Seemore ObtenerApartado(String nombre, int clave)
        {
            String comandoA = "select ID, Nombre, URL from @Tabla where ID=@ID";
            Seemore pSee = new Seemore();
            MySqlConnection conexion = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(comandoA, conexion);
            comando.Parameters.AddWithValue("@Tabla", nombre);
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
        public static int ActualizarApartado(String nombre, Seemore see)
        {
            int retorno = 0;
            String comandoA = "update @Tabla set ID=@ID, Nombre=@Nombre, URL=@URL where Clave=@Clave";
            MySqlConnection conexion = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(comandoA, conexion);
            comando.Parameters.AddWithValue("@Tabla", nombre);
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
        public static int EliminarApartado(String nombre, int ID)
        {
            int retorno = 0;
            String comandoA = "delete from @Tabla where ID=@ID";
            MySqlConnection conexion = Conexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(comandoA, conexion);
            comando.Parameters.AddWithValue("@Tabla", nombre);
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
