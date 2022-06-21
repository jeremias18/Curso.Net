Console.WriteLine("Ingrese el largo del vector:");
int length = int.Parse(Console.ReadLine());
int[] vector = new int[length];
Random aleatorio = new Random();
int contador = 0;


for (int index = 0; index < vector.Length; index++) {
    vector[index] = aleatorio.Next(100);
}

foreach (var index in vector) {
    contador++;
    Console.WriteLine(contador + ": " + index);
}

Console.WriteLine("");
Console.WriteLine("");

for (int index = 0; index < (vector.Length - (index + 1)); index++) {
    int respaldoValor = 0;
    int vectorInvertido = (vector.Length - (index + 1));
    respaldoValor = vector[index];
    vector[index] = vector[vectorInvertido];
    vector[vectorInvertido] = respaldoValor;
}

contador = 0;
foreach (var index in vector) {
    contador++;
    Console.WriteLine(contador + ": " + index);
}