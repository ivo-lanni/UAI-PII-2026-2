ateTime hoy, navidad;
TimeSpan diferencia;

hoy = DateTime.Now;
navidad = new DateTime(2020, 12, 25);

diferencia = navidad - hoy;

Console.WriteLine("Faltan {0} dias", diferencia.Days);
Console.ReadKey();
