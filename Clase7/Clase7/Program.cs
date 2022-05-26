int[] numeros = new int[10];

getNumeros();
mostrarNumeros();

Console.WriteLine(getTotal());
Console.WriteLine(getMayor());
Console.WriteLine(getMenor());
var promedio = (getTotal() - numeros.Length);

Console.ReadKey();
void getNumeros() {
    for (int i = 0; i < numeros.Length; i++) {
        Console.WriteLine("Ingrese un numero");
        var num = int.Parse(Console.ReadLine());
        numeros[i] = num;
    }
}

int getTotal() {
    int total = 0;
    for (int i = 0; i < numeros.Length; i++) {
        total += numeros[i];
    }
    return total;
}

int getMenor() {
    int menor = numeros[0];
    for (int i = 0; i < numeros.Length; i++) {
        if (menor > numeros[i]) {
            menor = numeros[i];
        }
    }
    return menor;
}

int getMayor() {
    int mayor = numeros[0];
    for (int i = 0; i < numeros.Length; i++) {
        if (mayor < numeros[i]) {
            mayor = numeros[i];
        }
    }
    return mayor;
}

void mostrarNumeros() {
    for (int i = 0; i < numeros.Length; i++) {
        Console.WriteLine(numeros[i]);
    }
}