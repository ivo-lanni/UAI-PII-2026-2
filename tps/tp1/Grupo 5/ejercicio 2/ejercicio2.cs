int a, b, cantidad;

Console.WriteLine("Ingrese un numero");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese otro numero");
b = Convert.ToInt32(Console.ReadLine());

cantidad = b - a;

Console.WriteLine("Hay {0} numeros entre ellos", cantidad);
Console.ReadKey();
