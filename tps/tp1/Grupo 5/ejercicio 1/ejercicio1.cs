string cadena;
int a, b, suma;

Console.WriteLine("Ingrese un numero");
cadena = Console.ReadLine();
a = Convert.ToInt32(cadena);

Console.WriteLine("Ingrese otro numero");
cadena = Console.ReadLine();
b = Convert.ToInt32(cadena);

suma = a + b;

Console.WriteLine("La suma es {0}", suma);
Console.ReadKey();