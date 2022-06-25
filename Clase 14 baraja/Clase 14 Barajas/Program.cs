using Clase_14_Barajas.Models;


var Baraja = new List<Carta>();
Baraja = CrearBaraja();

Console.WriteLine("Total de cartas en la baraja: " + Baraja.Count);
foreach(Carta carta in Baraja) {
    Console.WriteLine("Palo: " + carta.Palo);
    Console.WriteLine("Número: " + carta.Numero);
    Console.WriteLine();
}


List<Carta> CrearBaraja() {
    var cartas = new List<Carta>();
    for (int i = 0; i < 4; i++) {
        for (int j = 1; j < 11; j++) {
            var carta = new Carta();
            carta.Palo = CrearPalo(i);
            carta.Numero = CrearNumero(j);
            cartas.Add(carta);
        }
    }
    return cartas;
}

int CrearNumero(int j) {
    var numero = 0;
    if (j < 8) {
        numero = j;
    } else {
        numero = j + 2;
    }
    return numero;
}

string CrearPalo(int i) {
    string palo = "";
    switch (i) {
        case 0: palo = "Espada"; break;
        case 1: palo = "Basto"; break;
        case 2: palo = "Oro"; break;
        case 3: palo = "Copa"; break;
    }
    return palo;
}