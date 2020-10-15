using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
//Asi se puede dejar de escribir System.Console.WriteLine y solo utilizar WriteLine
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se pueden crear de formas distintas los objetos pues la clase Escuela tiene sobrecarga de constructor.
            var escuela = new Escuela("Platzi", 2012,TiposEscuela.online,pais: "Colombia");
            // var nuevaescuela = new Escuela("Nueva",2020);

            var Cursos = new List<Curso>(){
                new Curso { Nombre = "101", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "201", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "301", Jornada = TiposJornada.Matutino }
            };
            var Cursos2 = new List<Curso>(){
                new Curso { Nombre = "401", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "501", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "402", Jornada = TiposJornada.Verspertino }
            };

            Cursos.Add(new Curso {Nombre = "102", Jornada = TiposJornada.Verspertino});

            escuela.Cursos = Cursos;
            escuela.Cursos.AddRange(Cursos2);
            
            WriteLine(escuela.ToString());
            printCursosEscuela(escuela);
            //printCursos(arregloCursos);
            // System.Console.WriteLine(curso1.Nombre + ", " + curso1.UniqueId);
            // System.Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
        }

        private static void printCursosEscuela(Escuela escuela)
        {
            WriteLine("=============================");
            WriteLine($"Cursos de {escuela.Nombre}");
            WriteLine("=============================");
            //Valida si escuela y escuela.cursos no son null
            if(escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre} , ID: {curso.UniqueId}");
                }
            }
            
        }

        private static void printCursos(Curso[] arregloCursos)
        {
            //Usando while
            // int contador = 0;
            // while (contador < arregloCursos.Length)
            // {
            //     System.Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre} , ID: {arregloCursos[contador].UniqueId}");
            //     contador++;
            // }

            //Usando for each
            foreach (var curso in arregloCursos)
            {   
                System.Console.WriteLine($"Nombre: {curso.Nombre} , ID: {curso.UniqueId}");
            }
        }
    }
}
