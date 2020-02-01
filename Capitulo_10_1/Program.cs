using System;

namespace Capitulo_10_1 //crear una clase para llevar el inventario de una tienda
{
    public class Inventario
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public Inventario()
        {
            Nombre = "Pizza";
            Cantidad = 2;
            Precio = 200;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            Console.WriteLine("El nombre del producto es: {0}\n" +
                "La cantidad en existencia es: {1}\n" +
                "El precio por unidad es: {2}", inventario.Nombre, inventario.Cantidad, inventario.Precio);
        }
    }
}
