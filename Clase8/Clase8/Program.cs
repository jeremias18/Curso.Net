

Console.WriteLine("Ingrese la cantidad de filas.");
int filas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de columnas.");
int columnas = int.Parse(Console.ReadLine());
int[,] matriz = new int[filas,columnas];

double[] promedios = new double[filas];

for (int i = 0; i < filas; i++) {
    for (int j = 0; j < columnas; j++) {
        Console.WriteLine("Ingrese un valor");
        matriz[i,j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < filas; i++) {
    double prom = 0;
    for (int j = 0; j < columnas; j++) {
        Console.WriteLine("Fila: " + i + ", columnas: " + j);
        Console.WriteLine(matriz[i, j]);
        prom += matriz[i, j];
    }
    promedios[i] = (prom / columnas);
}

for(int i = 0; i < promedios.Length; i++) {
    Console.WriteLine("El promedio de la fila: " + i + " es: " + promedios[i]);
}