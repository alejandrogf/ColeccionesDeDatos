using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColeccionesDeDatos.clases;

namespace ColeccionesDeDatos
{
    class Program
    {
        static void Mai(string[] args)
        {

            //Ejemplo de tipo de coleccion: cola
            Queue colaG=new Queue();

            colaG.Enqueue("Hola");
            colaG.Enqueue("Soy");
            colaG.Enqueue(new Persona() {Apellidos = "Gomez", Nombre = "Pepe"});
            colaG.Enqueue(22);

            foreach (var elemento in colaG)
            {
            //Como almacena una persona, hay que acceder de forma diferente a su contenido.
            //Se puede manipular dicha información de distintas formas:

            //Es la mas engorrosa, porque necesitas un IS para cada tipo que tengas
                //if (elemento is Persona)
                //{
                //    Console.WriteLine(((Persona)elemento).Nombre);

                //}
                //else
                //{
                //    Console.WriteLine(elemento);

                //}

            //Otra opción, llamada "safe casting". 
            //Cuando falla, no peta, si no que devuelve un null, por tanto se puede utilizar para
            //comprobar qué dato se está procesando.
                //var p = elemento as Persona;
                //if (p != null)
                //{
                //    Console.WriteLine(p.Nombre);
                //}
                //else
                //{
                //    Console.WriteLine(elemento);
                //}

            //La mejor opción, mas rápida y eficiente, es modificar el método ToString de la clase,
            //o clases, que tenemos que tratar para devuelvan el formato y valores que queremos.
            //Esto se hace porque, por ejemplo, un console.writeline lo que hace es llamar a 
            //ToString para mostrar la información escrita en pantalla.
            //Ver modificacion de método en clase "Persona"

                Console.WriteLine(elemento);


            }
            //Una coleccion de objetos de tipo generics recibe el tipo de objeto que va a guardar
            //Y solo permite esos valores.
            Queue<Persona> colaP=new Queue<Persona>();//Cola

            colaP.Enqueue(new Persona() { Apellidos = "Martín",   Nombre = "Gonzalo"  });
            colaP.Enqueue(new Persona() { Apellidos = "Gomez",    Nombre = "Pepe"     });
            colaP.Enqueue(new Persona() { Apellidos = "De Melón", Nombre = "Miguelón" });
            //Al ser generic, espefícica para un tipo de objetos, ya está modificada para mostrar la 
            //información y/o contenido correctamente de cada uno de sus elementos.
            foreach (var persona in colaP)
            {
                Console.WriteLine(persona.Nombre);
            }

            Stack<Persona> stackP=new Stack<Persona>();//Es una pila

            stackP.Push(new Persona() { Apellidos = "Martín", Nombre = "Gonzalo" });
            stackP.Push(new Persona() { Apellidos = "Gomez", Nombre = "Pepe" });
            stackP.Push(new Persona() { Apellidos = "De Melón", Nombre = "Miguelón" });

            foreach (var persona in stackP)
            {
                Console.WriteLine(persona.Nombre);
            }

            Console.ReadLine();
        }
    }
}
