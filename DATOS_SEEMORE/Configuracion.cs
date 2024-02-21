using System;

namespace DATOS_SEEMORE
{
    public class Configuracion
    {
        public static String nombreApartado;
        public static Boolean unCambio = true;
        public static Boolean encriptacion = false;
        public static String[] Animes;
        public static int totales = 0;
        public static String UsuarioActual = Environment.UserName;
        public static String[] Usuarios2;
        public static int[] duracion;
        public static String ruta;
        public class Informacion
        {
            public static Boolean loCerroelUsuario = false;
            public static String ImagenUsable = "";
            public static Boolean respuesta { get; set; }
        }
        public class DatosReproductor {
            public static String NombreVideo { get; set; }
            public static String RutaVideo { get; set; }
            public static Boolean hayIntercambio { get; set; }
            public static String UsuarioTemporal { get; set; }
            public static Boolean IsOnly { get; set; }
        }
        public class DatosUsuario
        {
            public static String Usuario { get; set; }
            public static String Imagen { get; set; }
            public static String Sexo { get; set; }
            public static String Contraseña { get; set; }
        }
        public class DatosInicioSesionAuto
        {
            public static String[] Usuarios { get; set; }
            public static String[] UsuariosNombre { get; set; }
            public static String[] UsuariosContra { get; set; }
            public static String[] UsuariosImagen { get; set; }
            public static String[] UsuariosSexo { get; set; }
        }
        public class DatosInicioSesionTemp
        {
            public static String[] TempNombre { get; set; }
            public static String[] TempContra { get; set; }
            public static String[] TempImagen { get; set; }
            public static String[] TempSexo { get; set; }
        }
    }
        
    
}
