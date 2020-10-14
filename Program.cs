using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se pueden crear de formas distintas los objetos pues la clase Escuela tiene sobrecarga de constructor.
            var escuela = new Escuela("Platzi", 2012,TiposEscuela.online,pais: "Colombia");
            var nuevaescuela = new Escuela("Nueva",2020);
            Console.WriteLine(escuela.ToString());
        }
    }
}
