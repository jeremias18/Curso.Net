using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fórmula del área de un rectángulo. 
//Para calcular el área de un rectángulo multiplicamos el 
//largo por el ancho.

namespace Ejercicio_Cuadrilateros.Models {
    public class Ractangulo : Cuadrilatero {
        public Ractangulo(int x1, int x2, int y1, int y2) : base(x1, x2, y1, y2) {

        }

        public override double Area(int x1, int x2, int y1, int y2) { 
            int bases = x2 - x1;
            int altura = y2 - y1;
            double area = bases * altura;

            return area;
        }
    }
}
