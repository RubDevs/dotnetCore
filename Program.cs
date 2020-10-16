using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
//Asi se puede dejar de escribir System.Console.WriteLine y solo utilizar WriteLine
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            WriteLine(engine.Escuela.ToString());
            printCursosEscuela(engine.Escuela);
            //printCursos(arregloCursos);
            // System.Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
            // System.Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
        }

        // private static bool Predicado(Curso obj)
        // {
        //     //Este metodo sera invocado por cada elemento de la coleccion y cada
        //     //elemento coincida con condicion se eliminara
        //     return obj.Nombre == "301";
        // }

        private static void printCursosEscuela(Escuela escuela)
        {

            Printer.writeTitle($"Cursos de {escuela.Nombre}");
            //Valida si escuela y escuela.cursos no son null
            if(escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre} , ID: {curso.UniqueId}");
                }
            }
            
        }
    }
}
