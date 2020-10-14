using System;
namespace CoreEscuela.Entidades
{
    public class Curso
    {
        //modificador de acceso en el set como privado para que solo se pueda asignar el id dentro de la clase
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}