using System;

namespace Capitulo_9_3 //Crear estructuras enlazadas para guardar la informaci[on de una mascota y su dueño 
{
    class Program
    {
        public struct Propietario
        {
            public string Nombre;
            public int Edad;
            public string Telefono;
        }

        public struct Mascota
        {
            public string Nombre;
            public Propietario propietario;
        }
        static void Main(string[] args)
        {
            Mascota mascota = new Mascota();

            mascota.Nombre = "Fido";
            mascota.propietario.Nombre = "Jose";
            mascota.propietario.Edad = 18;
            mascota.propietario.Telefono = "809-555-7890";

            Console.WriteLine("El nombre de la mascota es: {0}\n" +
                "El nombre de su dueño es: {1}\n" +
                "La edad de su dueño es: {2}\n" +
                "El telefono de su dueño es: {3}", mascota.Nombre, mascota.propietario.Nombre, mascota.propietario.Edad, mascota.propietario.Telefono);
        }
    }
}
