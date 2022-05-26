Boolean AdivinoNumero = false;
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 100);
int contador = 0;

Console.WriteLine("Bienvenido! Intente adivinar el número comprendido entre 0 y 100");
while (AdivinoNumero == false) {
    var num = getNumero();
    if (num != 0) {
        if ((num < 0) || (num > 100)) {
            Console.WriteLine("El número ingresado está fuera de rango, intente nuevamente.");
        } else {
            if (num == numeroSecreto) {
                AdivinoNumero = true;
            }
            if (num > numeroSecreto) {
                Console.WriteLine("El número ingresado es mayor, intente nuevamente.");
            } else {
                Console.WriteLine("El número ingresado es menor, intente nuevamente.");
            }
        }
    }        
    contador += 1;
    Console.WriteLine("");
}
if (AdivinoNumero == true) {
    Console.WriteLine("Felicitaciones, has adivinado el número secreto que era: " + numeroSecreto);
    Console.WriteLine("Lo has logrado en " + contador + " intentos!!");
}


//Pide numero al usuario y formatea
int getNumero() {
    Console.WriteLine("Ingrese un número dentro del rango.");
    var num = Console.ReadLine();
    if (num != null) {
        return int.Parse(num);
    } else {
        return 0;
    }        
}
