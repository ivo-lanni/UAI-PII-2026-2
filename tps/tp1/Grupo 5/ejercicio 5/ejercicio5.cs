int baseRectangulo, altura, superficie;

Console.WriteLine("Ingrese la base");
baseRectangulo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la altura");
altura = Convert.ToInt32(Console.ReadLine());

superficie = baseRectangulo * altura;

Console.WriteLine("La superficie es {0}", superficie);
Console.ReadKey();
