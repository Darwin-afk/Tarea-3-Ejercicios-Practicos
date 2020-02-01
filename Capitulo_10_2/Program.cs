using System;

namespace Capitulo_10_2 //Crear una clase para llevar la información de los estudiantes de una escuela
{
    public class Estudiantes
    {
        public string Nombre { get; set; }
        public int Matricula { get; set; }
        public int Edad { get; set; }

        public Estudiantes()
        {
            Nombre = "Darwin";
            Matricula = 20180179;
            Edad = 20;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Estudiantes estudiante = new Estudiantes();

            Console.WriteLine("El nombre  es: {0}\n" +
                "La matricula es: {1}\n" +
                "La edad es: {2}", estudiante.Nombre, estudiante.Matricula, estudiante.Edad);
        }
    }
}
