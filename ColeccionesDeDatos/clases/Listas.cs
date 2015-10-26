using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesDeDatos.clases
{
    public class Listas
    {
        public static void Mai(string[] args)
        {
            List<Persona> listaP=new List<Persona>();

            listaP.Add(new Persona()
            {
                Apellidos = "Martín",
                Nombre = "Gonzalo"
            });
            listaP.Add(new Persona()
            {
                Apellidos = "Gomez",
                Nombre = "Pepe"
            });
            //Se puede usar Insert, indicando la posición donde añadir el objeto.
            //El resto de objetos, desde esa posición, se desplazarán una posición.
            listaP.Insert(2, new Persona()
            {
                Apellidos = "De Melón",
                Nombre = "Miguelón"
            });
            listaP.Add(new Persona()
            {
                Apellidos = "Dominguez",
                Nombre = "Eva"
            });
            listaP.Add(new Persona()
            {
                Apellidos = "López",
                Nombre = "María"
            });

            //Para eliminar elementos:
            //remove
            //removeAll
            //removeAt (indicando posición)
            listaP.RemoveAt(2);

            //Para recorrer la lista
            //.Count indica el número de elementos
            for (int i = 0; i < listaP.Count; i++)
            {
                Console.WriteLine("\n{0} {1}",listaP[i].Nombre , listaP[i].Apellidos);
            }


            Console.ReadLine();
        }
    }
}
