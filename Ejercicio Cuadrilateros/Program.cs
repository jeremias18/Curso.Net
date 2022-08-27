
//Use la clase Cuadrilátero como la clase base de la
//jerarquía, que debe ser abstracta.

//Los datos privados de la clase base deben ser las
//coordenadas x-y de los cuatro vértices de la figura y
//debe contener un método abstracto para calcular el área.

//Agregue un constructor a cada clase para inicializar
//sus datos e invoque el constructor de la clase base
//desde el constructor de cada clase derivada.

//Escriba un programa que instancie objetos de cada
//una de las clases y calcule el área correspondiente.
//Investigue las fórmulas para calcular el área
//de cada figura.

namespace Ejercicio_Cuadrilateros {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Ingrese los puntos para calcular el area.");
            Console.WriteLine("X1:");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("X2:");
            int x2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y1:");
            int y1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y2:");
            int y2 = Int32.Parse(Console.ReadLine());
        }
    }
}