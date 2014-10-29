using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ColectorObjetos <Tipo> where Tipo:Libro
    {

        private Tipo[] datos;//me creo la propiedad

        public ColectorObjetos(int elementos)//la inicializo
        {
            datos=new Tipo[elementos];
        }

        public Tipo this[int i]//es una propiedad con índices de indexamiento para poder trabajar con ella como si fuera un array
        {
            get { return datos[i]; }
            set { datos[i] = value; }

        }

        public void Borrar(Tipo t)
        {
            for(int i=0;i<datos.Length;i++)
            {


                if (datos[i]!=null && datos[i].Equals(t))
                {
                    datos[i] = default(Tipo);//default es para que me devuelva el Tipo por defecto de una clase
                }
            }
        }
    }
}
