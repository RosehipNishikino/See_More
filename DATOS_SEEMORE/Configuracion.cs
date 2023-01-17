using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MODELOS_SEEMORE;

namespace DATOS_SEEMORE
{
    public class Configuracion
    {
        public static String nombre;
        public static String nombreApartado;
        public static Boolean unCambio = true;
        public static String usuario = "";
        public static String contraseña = "";
        public static String imagen = "";
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
        public class BuscarAddon {
            public static Seemore AnimeSeleccionado { get; set; }
            public static Cuenta cuentaSeleccionado { get; set; }
            public static String NombreVideo { get; set; }
            public static String RutaVideo { get; set; }
            public static String UsuarioRegistrado { get; set; }
            public static String UsuarioImagen { get; set; }
            public static Boolean hayIntercambio { get; set; }
            public static String UsuarioTemporal { get; set; }
            public static String Usuario { get; set; }
            public static String Imagen { get; set; }
            public static String Sexo { get; set; }
            public static String Contraseña { get; set; }
            public static Boolean IsOnly { get; set; }
        }
    }
        
    
}
