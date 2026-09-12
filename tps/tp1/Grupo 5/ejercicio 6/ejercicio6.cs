double circunferencia, diametro;

Console.WriteLine("Ingrese la circunferencia");
circunferencia = Convert.ToDouble(Console.ReadLine());

diametro = circunferencia / Math.PI;

Console.WriteLine("El diametro es {0}", diametro);
Console.ReadKey();
