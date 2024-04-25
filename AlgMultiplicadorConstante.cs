Console.Write("Ingrese a: "); String a = Console.ReadLine();
Console.Write("Ingrese X0: "); String x0 = Console.ReadLine();
Console.Write("Iteraciones: "); String iter = Console.ReadLine();


for (int i = 0; i < int.Parse(iter); i++)
{
    int result = int.Parse(a) * int.Parse(x0);

    int longitud = result.ToString().Length;
    int posicionInicial = longitud / 2 - 2; // Calcula la posición inicial (resta 2 para centrar los números)
    int longitudSubcadena = 4; // Cantidad de números centrales
    string subcadena = result.ToString().Substring(posicionInicial, longitudSubcadena);

    Console.WriteLine();
    Console.WriteLine(i + " (" + a + ")" + " (" + x0 + ") " + "= " + result + " x" + i + " = " + subcadena + " y" + i + " = " + "0." + subcadena);


    int xi = int.Parse(subcadena);
    x0 = xi.ToString();

    Console.WriteLine();
}
