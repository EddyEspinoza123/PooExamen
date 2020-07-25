using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFigurasGeometricas
{
    class FiguraCirculo : FiguraRectangulo
    {
        
        public void Area(double radio, double pi )
        {

            Console.WriteLine("El area del Circulo es: " + (pi ) * (radio * radio));
        
        }
    }
}
