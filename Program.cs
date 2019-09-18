using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
              pais: "Mexico", ciudad: "Mexicali");
            /*miEscuela.Pais = "Colombia";
            miEscuela.Ciudad = "Bogota";*/
            Console.WriteLine(miEscuela);
        }
    }
}
