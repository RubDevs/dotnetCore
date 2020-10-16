using System.Collections.Generic;
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
            this.Escuela = new Escuela("Platzi", 2012,TiposEscuela.online,pais: "Colombia");
            // var nuevaescuela = new Escuela("Nueva",2020);

            var Cursos = new List<Curso>(){
                new Curso { Nombre = "101", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "201", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "301", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "401", Jornada = TiposJornada.Matutino },
                new Curso { Nombre = "501", Jornada = TiposJornada.Matutino }
            };
            // var Cursos2 = new List<Curso>(){
            //     new Curso { Nombre = "401", Jornada = TiposJornada.Matutino },
            //     new Curso { Nombre = "501", Jornada = TiposJornada.Matutino },
            //     new Curso { Nombre = "402", Jornada = TiposJornada.Verspertino }
            // };

            // Cursos.Add(new Curso {Nombre = "102", Jornada = TiposJornada.Verspertino});
            Escuela.Cursos = Cursos;
            //escuela.Cursos.AddRange(Cursos2);
            //Para eliminar un curso se puede pasar la referencia al objeto y 
            //se va a buscar el hashcode dentro de la coleccion para eliminarlo
            //escuela.Cursos.Remove(curso)

            //Si no tengo la referencia al objeto se puede hacer de la siguiente forma
            
            //escuela.Cursos.RemoveAll(Predicado);

            //Es posible reducir la cantidad de codigo con una expresion lambda
            //escuela.Cursos.RemoveAll((curso)=> curso.Nombre == "401");
        }
    }
}