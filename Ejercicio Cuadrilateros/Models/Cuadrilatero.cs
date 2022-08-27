using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cuadrilateros.Models {
    public abstract class Cuadrilatero {
        private int _X1 { get; set; }
        private int _X2 { get; set; }
        private int _Y1 { get; set; }
        private int _Y2 { get; set; }

        public int x1 { 
            get => _X1; 
            set => _X1 = value; 
        }

        public int x2 {
            get => _X2;
            set => _X2 = value;
        }
        public int y1 {
            get => _Y1;
            set => _Y1 = value;
        }

        public int y2 {
            get => _Y2;
            set => _Y2 = value;
        }

        public Cuadrilatero(int x1, int x2, int y1, int y2) {
            _X1 = x1;
            _X2 = x2;
            _Y1 = y1;
            _Y2 = y2;
        }

        public abstract double Area(int x1, int x2, int y1, int y2);
    }
}
