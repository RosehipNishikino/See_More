using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace DATOS_SEEMORE
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=animes; Uid=root; pwd=root;");
            try
            {
                conexion.Open();
            }
            catch (MySqlException)
            {
            }
            return conexion;
        } 
        public static Boolean existeConexion()
        {
            try
            {
                var conexion = ObtenerConexion();
                conexion.Close();
                conexion.Open();
                return true;
            }
            catch (Exception) { return false; }
        }
    }
}
