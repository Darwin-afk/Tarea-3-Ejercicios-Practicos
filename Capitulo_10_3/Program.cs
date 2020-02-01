using System;

namespace Capitulo_10_3 //Crear una clase para poligonos con sobrecarga del constructor
    //Crear propiedades que solamente permitan colocar valores validos
    //programar el método ToString()
{
    public class Poligonos
    {
        private int lados;
        private int distancia;

        public int Lados
        {
            get
            {
                return lados;
            }
            set
            {
                if (value >= 3)
                    lados = value;
                else
                    lados = 0;
            }
        }

        public int Distancia
        {
            get
            {
                return distancia;
            }
            set
            {
                if (value > 0)
                    distancia = value;
                else
                    distancia = 0;
            }
        }
        public Poligonos()
        {
            Lados = 0;
            Distancia = 0;
        }

        public Poligonos(int lados,int distancia)
        {
            Lados = lados;
            Distancia = distancia;
        }

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Los lados del poligono son " + Lados.ToString() + " y miden " + Distancia.ToString();

            return mensaje;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Poligonos triangulo = new Poligonos(-3, 6);

            Console.WriteLine("{0}", triangulo.ToString());
        }
    }
}
