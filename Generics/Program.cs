using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //comento hasta el borrar para poner el ejemplo de lista
           // ColectorObjetos<Libro> co=new ColectorObjetos<Libro>(3);
            //var l = new Libro() {Titulo = "La Hoguera e las Vanidades"};
            //co[0] = new Libro() {Titulo = "El Padrino"};
            //co[0].Titulo = "El Padrino";
            //co[1] = l;
            //co.Borrar(co[0]);


            var lista = new List<Libro>();//las diferencias de esto con ArrayList, es que ese es para objects y eso es para genéricos

            lista.Add(new Libro(){Titulo = "Lo que sea"});
            lista.Add(new Libro() { Titulo = "Lo que sea" });
            lista.Add(new Libro() { Titulo = "Lo que sea" });
            lista.Add(new Libro() { Titulo = "Lo que sea" });

            Console.WriteLine(lista[2].Titulo);

            lista.RemoveAt(3);

            Console.WriteLine(lista.Count);

            foreach (var l in lista)
            {
                Console.WriteLine(l.Titulo);
            }

        }
    }
}
