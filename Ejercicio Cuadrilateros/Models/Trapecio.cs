using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//El Perímetro de un trapecio es igual a la suma de todos sus lados.

namespace Ejercicio_Cuadrilateros.Models {
    public class Trapecio : Cuadrilatero {

        public Trapecio(int x1, int x2, int y1, int y2): base(x1, x2, y1, y2) {

        }

        //Es igual a la suma de las bases por la altura, y dividido por dos.
        public override double Area(int x1, int x2, int y1, int y2) {
            int bases = x2 - x1;
            int altura = y2 - y1;

            bases += bases;
            
            double area = (bases * altura) / 2;
            return area;
        }
    }
}
