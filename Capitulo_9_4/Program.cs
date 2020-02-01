using System;

namespace Capitulo_9_4 //crear una enumeracion para los diferentes tipos de neumáticos
{
    class Program
    {
        enum Neumaticos { Diagonal=1,Radial,Tubuless,Runflat};
        static void Main(string[] args)
        {
            Neumaticos nombre = Neumaticos.Radial;
            int num;

            num = (int)nombre;

            Console.WriteLine("El numero del neumatico {0} es {1}", nombre, num);
        }
    }
}
