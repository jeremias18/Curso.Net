using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_14_Barajas.Models;

namespace Clase_14_Barajas.Models {
    internal class Baraja {

        public List<Carta> baraja = new List<Carta>();



        //Metodos
        public void Barajar() {
            Random rand = new Random();
            for (int i = 0; i < (baraja.Count - 1); i++) {
                int posicion = rand.Next(1, baraja.Count);
                var carta = baraja[posicion];
                baraja.Remove(baraja[posicion]);
                baraja.Insert(0, carta);
            }
        }
        
        public void CartasDisponibles() {
            Console.WriteLine("La cantidad de cartas disponibles son: " + baraja.Count);
        }
        public void MostrarBaraja() {
            foreach (Carta carta in baraja) {
                Console.WriteLine("Palo: " + carta.Palo);
                Console.WriteLine("Número: " + carta.Numero);
                Console.WriteLine();
            }
        }
        public void SiguienteCarta(Baraja mazoMonton) {
            if (baraja.Count > 1) {
                Console.WriteLine("Siguiente carta: ");
                Console.WriteLine("Palo: " + baraja[0].Palo + ", número: " + baraja[0].Numero);
                mazoMonton.baraja.Add(baraja[0]);
                baraja.Remove(baraja[0]);
            } else {
                Console.WriteLine("No hay más cartas por dar.");
            }
        }

        public void DarCartas(int cantidad, Baraja mazoMonton) {
            if (baraja.Count < cantidad) {
                Console.WriteLine("No se pueden repartir esa cantidad de cartas.");
            } else {
                for (int i = 0; i < cantidad; i++) {
                    Console.WriteLine("Siguiente carta: ");
                    Console.WriteLine("Palo: " + baraja[0].Palo + ", número: " + baraja[0].Numero);
                    mazoMonton.baraja.Add(baraja[0]);
                    baraja.Remove(baraja[0]);
                }
            }
        }
    }
}
