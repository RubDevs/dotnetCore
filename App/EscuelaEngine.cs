using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            //Se pueden crear de formas distintas los objetos pues la clase Escuela tiene sobrecarga de constructor.
            Escuela = new Escuela("Platzi", 2012, TiposEscuela.online, pais: "Colombia");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{ Nombre="Matematicas" },
                    new Asignatura{ Nombre="Espanol" },
                    new Asignatura{ Nombre="Ciencias Naturales" },
                    new Asignatura{ Nombre="Historia" },
                    new Asignatura{ Nombre="Ingles" }
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAleatorios(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Morty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            //Linq lenguaje integrado de consulta de C#
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno{ Nombre=$"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy((al)=> al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso { Nombre = "101", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "201", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "301", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "401", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "501", Jornada = TiposJornada.Matutino }
            };

            var numRandom = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                var cant = numRandom.Next(5,20);
                curso.Alumnos = GenerarAlumnosAleatorios(cant);
            }
        }
    }
}