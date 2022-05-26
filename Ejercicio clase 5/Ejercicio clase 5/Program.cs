string saludoCierre = "Programa finalizado correctamente";
string msjError = "Opcion no valida.";
string operacion = "S";

while (operacion == "S")
{
    Console.Clear();
    Console.WriteLine("Por favor, ingrese su nombre.");
    string nombre = Console.ReadLine();
    Console.WriteLine("!Hola " + nombre + "!");

    Console.WriteLine("¿Desea continuar?");
    Console.WriteLine("'S' - Si");
    Console.WriteLine("'N' - No");
    operacion = Console.ReadLine();
}

if (operacion == "N")
{
    Console.WriteLine(saludoCierre);
}
else
{
    Console.WriteLine(msjError);
}