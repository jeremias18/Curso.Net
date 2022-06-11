//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29,
//      así sucesivamente hasta la última columna la cual contiene del 80 al 90
//7)    Mostrar el carton por pantalla
int columna = 9; int fila = 3;
int numTotal = 0;
int[,] cartonBingo = new int[fila, columna];
Random Random = new Random();

cargarPrimerCarton();
terminarCarton();
mostrarCarton();




void cargarPrimerCarton() {
    for (int columna = 0; columna < cartonBingo.GetLength(1); columna++) {
        int numMin = (columna * 10); int numMax = ((columna + 1) * 10) - 1;
        int random = Random.Next(numMin, numMax);
        int posRandom = Random.Next(0, 2);
        cartonBingo[posRandom, columna] = random;
        numTotal++;
    }
    Console.WriteLine("La primer carga termino. Fueron:" + numTotal);
}

void terminarCarton() {
    int numPorCargar = 6;
    int num = 0;
    while(num < numPorCargar ) {
        for (int columna = 0; columna < cartonBingo.GetLength(1); columna++) {
            int numMin = (columna * 10); int numMax = ((columna + 1) * 10) - 1;
            int random = Random.Next(numMin, numMax);
            if (probabilidadNum() == true && num < numPorCargar) {
                bool numEvitado = comprobarRandom(random, columna);
                if (numEvitado == false) {
                    num++;
                    numTotal++;
                }
            }
        }
    }
    Console.WriteLine("Se cargó: " + num + " numero");
    Console.WriteLine("Cargados: " + numTotal);
}


void mostrarCarton() {
    for (int i = 0; i < cartonBingo.GetLength(0); i++) {
        for (int j = 0; j < cartonBingo.GetLength(1); j++) {
            Console.Write(cartonBingo[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

Boolean comprobarRandom(int pRandom, int pColumna) {
    Boolean repetido = false; int numPorFila = 0;
    for (int j = 0; j < cartonBingo.GetLength(0); j++) {
        if (pRandom == cartonBingo[j, pColumna]) {
            repetido = true;
            return repetido;
        }
    }


    for (int j = 0; j < cartonBingo.GetLength(0); j++) {
        if (cartonBingo[j, pColumna] != 0) {
            numPorFila++;
            if (numPorFila <= 1) {
                if (cartonBingo[j, pColumna] > pRandom) {
                    if (j == 0) {
                        cartonBingo[(j + 1), pColumna] = cartonBingo[j, pColumna];
                        cartonBingo[j, pColumna] = pRandom;
                        return repetido;
                    } else {
                        cartonBingo[(j - 1), pColumna] = pRandom;
                        return repetido;
                    }
                } else {
                    if (j == 2) {
                        cartonBingo[(j - 1), pColumna] = cartonBingo[j, pColumna];
                        cartonBingo[j, pColumna] = pRandom;
                        return repetido;
                    } else {
                        cartonBingo[(j + 1), pColumna] = pRandom;
                        return repetido;
                    }
                }
            }
        }
    }
    return repetido;
}

Boolean probabilidadNum() {
    int prob = Random.Next(0, 100);
    if (prob > 49) {
        return true;
    } else {
        return false;
    }
}