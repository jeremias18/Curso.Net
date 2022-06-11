Random aleatorio = new Random();
int intentosPosibles = 3;
Boolean encontrado = false;
int numeroGanador = aleatorio.Next(0,30);

Console.WriteLine("Bienvenido al juego");
Console.WriteLine("Deberá adivinar un número entre 0 y 30");

while ((encontrado == false) && (intentosPosibles > 0)){
    Console.WriteLine("Intentos disponibles: " + intentosPosibles);
    Console.WriteLine("Ingrese su numero: ");
    int numeroUsuario = int.Parse(Console.ReadLine());
    if (validarNumeroIngresado(numeroUsuario)) {
        if (numeroUsuario == numeroGanador) {
            encontrado = true;
        } else {
            comprobarNumero(numeroUsuario);
            //Console.WriteLine("El numero ingresado no es correcto, vuelva a intentarlo.");
            intentosPosibles--;
        }
    } else {
        Console.WriteLine("El número ingresado está fuera de rango");
    }
    espaciado();
}

if (encontrado == true) {
    Console.WriteLine("Felicidades! ganaste el juego. Reclamale el premio al creador del juego.");
} else {
    Console.WriteLine("Perdiste! No te pongas mal, paga $100 y volvé a intentar.");
    Console.WriteLine("El número correcto era: " + numeroGanador);
}

Boolean validarNumeroIngresado(int pNum) {
    if ((pNum < 100) || (pNum > 0)) {
        return true;
    } else {
        return false;
    }
} 

void espaciado() {
    for(int i = 0; i < 4; i++) {
        Console.WriteLine("");
    }
}

void comprobarNumero(int pNum) {
    if (pNum < numeroGanador) {
        Console.WriteLine("Es un número mayor...");
    } else {
        Console.WriteLine("Es un número menor...");
    }
}