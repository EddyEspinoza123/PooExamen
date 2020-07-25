using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFigurasGeometricas
{
    class FiguraTriangulo : FiguraRectangulo
    {
        
        public void Area(double Base, double Altura)
        {
            Console.WriteLine("El area del triangulo es: " + (Base * Altura) / 2);
        }
    }
}
