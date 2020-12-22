using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS_SEEMORE
{
    public class Seemore
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String URL { get; set; }
        public Seemore() { }
        public Seemore(int id, String nombre, String url)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.URL = url;
        }
    }
}
