
using System;

namespace CoreEscuela.Entidades
{
    class Escuela {
        private string nombre;
        public string Nombre
        {
            get { return "Copia:" + nombre; }
            set { nombre = value; }
        }        
        public int AñoDeCreación { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public Curso[] Cursos {get;set;}

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);

        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "" )
        {
            (Nombre, AñoDeCreación, TipoEscuela, Pais, Ciudad) = (nombre, año, tipo, pais, ciudad);
        }

        public override string ToString() {
            return $"Nombre: \"{Nombre}\", Tipo: \"{TipoEscuela}\", {System.Environment.NewLine}Pais: \"{Pais}\", Ciudad: \"{Ciudad}\"";
        }
    }
}