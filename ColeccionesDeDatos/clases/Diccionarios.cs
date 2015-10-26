using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesDeDatos.clases
{
    public class Diccionarios
    {
        public static void Main(string[] args)
        {
            //Al definir un diccionario se indica en el primer campo la clave 
            //y luego el tipo de objeto que va a almacenar
            Dictionary<string, Persona> d=new Dictionary<string, Persona>();

            d.Add("Uno", new Persona()
            {
                Apellidos = "Martín",
                Nombre = "Gonzalo"
            });

            d.Add("Dos", new Persona()
            {
                Apellidos = "De Melón",
                Nombre = "Miguelón"
            });

            d.Add("Tres", new Persona()
            {
                Apellidos = "López",
                Nombre = "María"
            });
            //Para recorrer, se puede hacer por .Keys o .Values
            foreach (var key in d.Keys)
            {
                Console.WriteLine("\n{0} {1}", d[key].Nombre, d[key].Apellidos);
            }

            Console.ReadLine();

            //Accedo según la clave.
            Console.WriteLine(d["Dos"].Nombre);

            //Busco por la clave y luego elimino.
            if (d.ContainsKey("Tres"))
            {
                d.Remove("Tres");
            }

            //Para recorrer, se puede hacer por .Keys o .Values
            foreach (var key in d.Keys)
            {
                Console.WriteLine("\n{0} {1}", d[key].Nombre, d[key].Apellidos);

            }
            Console.ReadLine();

        }
    }
}
