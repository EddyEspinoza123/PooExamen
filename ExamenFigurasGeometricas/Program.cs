using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola!, presione enter en el teclado para continuar ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("A continuacion vamos a calcular el Area del Triangulo , Rectangulo y Circulo:");
            Console.ReadLine();
            Console.Clear();

            FiguraRectangulo rectangulo = new FiguraRectangulo();
            rectangulo.Area(34, 56);
            Console.ReadLine();
            Console.Clear();


            FiguraTriangulo triangulo = new FiguraTriangulo();
            triangulo.Area(34, 56);
            Console.ReadLine();
            Console.Clear();


            FiguraCirculo circulo = new FiguraCirculo();
            circulo.Area(3.1415 ,34);
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("GRACIAS");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
