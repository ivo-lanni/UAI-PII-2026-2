string x, resultado;
int mitad;

Console.WriteLine("Ingrese una frase");
x = Console.ReadLine();

mitad = x.Length / 2;

resultado = x.Substring(mitad) + x.Substring(0, mitad);

Console.WriteLine(resultado);
Console.ReadKey();
