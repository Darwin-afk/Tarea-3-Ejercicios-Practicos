using System;

namespace Capitulo_9_1 //Crear una estructura para guardar los productos de una tienda
{
    class Program
    {
        public struct Producto
        {
            public string Nombre;
            public int Cantidad;
            public int PrecioPorUnidad;
        }
        static void Main(string[] args)
        {
            Producto producto = new Producto();

            producto.Nombre = "Pizza";
            producto.Cantidad = 2;
            producto.PrecioPorUnidad = 200;

            Console.WriteLine("El nombre del producto es: {0}\n" +
                "La cantidad en existencia es: {1}\n" +
                "El precio por unidad es: {2}", producto.Nombre, producto.Cantidad, producto.PrecioPorUnidad);
        }
    }
}
