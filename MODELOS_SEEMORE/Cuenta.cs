using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS_SEEMORE
{
    public class Cuenta
    {
        public int ID { get; set; }
        public String usuario { get; set; }
        public String contraseña { get; set; }
        public String imagen { get; set; }
        public String genero { get; set; }
        public Cuenta() { }
        public Cuenta(int id, String Usuario, String Contraseña, String Imagen, String Genero)
        {
            this.ID = id;
            this.usuario = Usuario;
            this.contraseña = Contraseña;
            this.imagen = Imagen;
            this.genero = Genero;
        }
    }
}
