using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        string nombre;
        public string Nombre{
            get{ return nombre; }
            set { nombre = value; }
        }

        public int AnoDeCreacion { get; set; }

        public string UniqueId { get; set; } = Guid.NewGuid().ToString();

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        //TipoEscuela es un enumerable definido en TiposEscuela.cs
        public TiposEscuela tipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        //Constructor full
        // public Escuela(string nombre,int AnoDeCreacion)
        // {
        //     this.nombre = nombre;
        //     this.AnoDeCreacion = AnoDeCreacion;
        // }

        //Constructor forma corta, los parametros con valor por defecto son opcionales pueden definirse o no al momento de la creacion de la instancia

        public Escuela(string nombre, int ano) => (Nombre,AnoDeCreacion)=(nombre,ano);
        public Escuela(string nombre, int ano, 
                        TiposEscuela tipos,
                        string pais = "", string ciudad = "") => (Nombre,AnoDeCreacion,tipoEscuela,Pais,Ciudad)=(nombre,ano,tipos,pais,ciudad);


        //Sobreescribir el metodo toString para obtener las propiedades del objeto
        public override string ToString()
        {
            return $"Nombre: {nombre}, Tipo: {tipoEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}