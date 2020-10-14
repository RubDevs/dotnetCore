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

            var curso1 = new Curso(){
                Nombre="101"
            };
            var curso2 = new Curso(){
                Nombre="102"
            };
            
            Console.WriteLine(escuela.ToString());
            Console.WriteLine("=======================");
            System.Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
            System.Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
        }
    }
}
