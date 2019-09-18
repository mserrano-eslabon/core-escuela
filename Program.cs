using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
              pais: "Mexico", ciudad: "Mexicali");

            miEscuela.Cursos = new Curso[]{
                            new Curso() { Nombre = "101" },
                            new Curso() { Nombre = "201" },
                            new Curso() { Nombre = "301" }
            };

            ImprimirCursosEscuela(miEscuela);
        }

        private static void ImprimirCursosEscuela(Escuela miEscuela)
        {

            WriteLine("========================================================");
            WriteLine("               Cursos de la escuela ");
            WriteLine("========================================================");

            if (miEscuela !=null && miEscuela.Cursos != null)
            {
                foreach (var curso in miEscuela.Cursos)
                {
                    WriteLine($"{curso.Nombre}, {curso.UniqueId}");
                }
            }
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"{arregloCursos[contador].Nombre}, {arregloCursos[contador].UniqueId}");
                contador++;
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                WriteLine($"{arregloCursos[contador].Nombre}, {arregloCursos[contador].UniqueId}");
                contador++;
            } while (contador < arregloCursos.Length);
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                WriteLine($"{arregloCursos[i].Nombre}, {arregloCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"{curso.Nombre}, {curso.UniqueId}");
            }
        }
    }
}
