using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cuadrilateros.Models {
    public class Cuadrado : Cuadrilatero {
        public Cuadrado(int x1, int x2, int y1, int y2) : base(x1, x2, y1, y2) {

        }


        public override double Area(int x1, int x2, int y1, int y2) {
            int bases = x2 - x1;
            int altura = y2 - y1;

            double area = altura * bases;
            return area;
        }
        }    
}
