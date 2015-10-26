using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesDeDatos.clases
{
    public class Persona
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Nombre,Apellidos);
        }
    }
}
