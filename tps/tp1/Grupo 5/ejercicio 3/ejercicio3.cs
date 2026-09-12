int a, b, c, perimetro;

Console.WriteLine("Ingrese el primer lado");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo lado");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el tercer lado");
c = Convert.ToInt32(Console.ReadLine());

perimetro = a + b + c;

Console.WriteLine("El perimetro es {0}", perimetro);
Console.ReadKey();
