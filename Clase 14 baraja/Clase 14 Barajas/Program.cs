using Clase_14_Barajas.Models;
var PalosCarta = 4;
var CantidadCartas = 11;

var Mazo = new Baraja();
var MazoMonton = new Baraja();
int Accion = 0;
CrearBaraja(Mazo);

while (Accion >= 0) {
    LimpiarPantalla();
    MostrarMenu();
    PedirAccion();
    switch (Accion) {
        case 1: Mazo.Barajar(); ; break;
        case 2: Mazo.SiguienteCarta(MazoMonton); break;
        case 3: Mazo.CartasDisponibles(); break;
        case 4:
            var cantidad = PedirCartas();
            Mazo.DarCartas(cantidad, MazoMonton); 
            break;
        case 5: MazoMonton.MostrarBaraja(); break;
        case 6: Mazo.MostrarBaraja(); break;
        case 7: Accion = -1; break;
    }
    Console.ReadKey();
}

void MostrarMenu() {
    Console.WriteLine("Ingrese el numero correspondiente a la acción que desea realizar.");
    Console.WriteLine("1 - Barajar");
    Console.WriteLine("2 - Mostrar siguiente carta");
    Console.WriteLine("3 - Mostrar cartas disponibles");
    Console.WriteLine("4 - Dar cartas");
    Console.WriteLine("5 - Mostrar cartas del monton");
    Console.WriteLine("6 - Mostrar baraja");
    Console.WriteLine("7 - Salir");
}

void PedirAccion() {
    var accion = Console.ReadLine();
    if (accion != "") {
        Accion = Int32.Parse(accion);
    }
}

int PedirCartas() {
    Console.WriteLine("Ingrese la cantidad de cartas a repartir: ");
    int cantidad = 0;
    var cant = Console.ReadLine();
    if (cant != "") {
        cantidad = Int32.Parse(cant);
    }
    return cantidad;
}

void LimpiarPantalla() {
    Console.Clear();
}

void CrearBaraja(Baraja mazo) {
    for (int i = 0; i < PalosCarta; i++) {
        for (int j = 1; j < CantidadCartas; j++) {
            var carta = new Carta();
            carta.Palo = carta.CrearPalo(i);
            carta.Numero = carta.CrearNumero(j);
            mazo.baraja.Add(carta);
        }
    }
}