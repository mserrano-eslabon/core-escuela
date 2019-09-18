using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela("Platzi Academy", 2012);
            miEscuela.Pais = "Colombia";
            miEscuela.Ciudad = "Bogota";
            miEscuela.TipoEscuela = TiposEscuela.Primaria;
            // Console.WriteLine("Hello World!");
            Console.WriteLine(miEscuela);
        }
    }
}
