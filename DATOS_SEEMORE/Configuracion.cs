using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_SEEMORE
{
    public class Configuracion
    {
        public static String nombre;
        public static String nombreApartado;
        public static Boolean unCambio = true;
        public static String usuario="";
        public static String contraseña="";
        public static Boolean encriptacion = false;
        public static String[] Animes;
        public static int totales = 0;
        public static String UsuarioActual = Environment.UserName;
        public static String[] Usuarios;
        public static String[] Usuarios2;
        public static String[] UsuariosNombre;
        public static String[] UsuariosContra;
        public static String[] UsuariosImagen;
        public static String[] UsuariosSexo;
        public static String[] TempNombre;
        public static String[] TempContra;
        public static String[] TempImagen;
        public static String[] TempSexo;
        public static int[] duracion;
        public static Boolean loCerroelUsuario = false;
        public static String ruta;
        public static Boolean existeConexion = Conexion.existeConexion();
    }
        
    
}
