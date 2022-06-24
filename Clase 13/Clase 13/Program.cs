using Clase_13.Models;

namespace Clase_13 {
    internal class Program {
        static void Main(string[] args) {
            var billetera1 = new Billetera(1, 1, 1, 1, 1, 1);
            var billetera2 = new Billetera(3, 3, 3, 3, 3, 3);
            var billeteraCombinada = new Billetera();


            Console.WriteLine(billetera1.Total());
            Console.WriteLine(billetera2.Total());
            billeteraCombinada = billetera1.Combinar(billetera2 as Billetera);
            billetera1.Vaciar();
            billetera2.Vaciar();

            Console.WriteLine(billeteraCombinada.Total());
            Console.WriteLine(billetera1.Total());
            Console.WriteLine(billetera2.Total());
        }

    }
}