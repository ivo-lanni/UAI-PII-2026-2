int lado, superficie;

Console.WriteLine("Ingrese el lado del cuadrado");
lado = Convert.ToInt32(Console.ReadLine());

superficie = lado * lado;

Console.WriteLine("La superficie es {0}", superficie);
Console.ReadKey();
