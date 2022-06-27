using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_Barajas.Models {
    public class Carta {

        public int Numero;
        public string Palo = "";

        //Metodos
        public int CrearNumero(int j) {
            var numero = 0;
            if (j < 8) {
                numero = j;
            } else {
                numero = j + 2;
            }
            return numero;
        }

        public string CrearPalo(int i) {
            string palo = "";
            switch (i) {
                case 0: palo = "Espada"; break;
                case 1: palo = "Basto"; break;
                case 2: palo = "Oro"; break;
                case 3: palo = "Copa"; break;
            }
            return palo;
        }
    }

    //public void Barajar(List<Carta> baraja) {
    //    Random rand = new Random();
    //    for(int i = 0; i < 40; i++) {
    //        List<int> posiciones = new List<int>();
    //        int posicion = rand.Next(1,40);
    //        var existePosicion = posiciones.Contains(posicion);
    //        if (existePosicion) {
    //            baraja.Insert(0, baraja[posicion]);
    //            posiciones.Add(posicion);
    //        }         

    //    }
    //}
}
