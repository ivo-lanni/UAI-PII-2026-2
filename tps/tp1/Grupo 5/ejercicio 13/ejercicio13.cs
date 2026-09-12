DateTime fecha;

Console.WriteLine("Ingrese una fecha");
fecha = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine(fecha.ToString("yyyyMMdd"));
Console.ReadKey();
