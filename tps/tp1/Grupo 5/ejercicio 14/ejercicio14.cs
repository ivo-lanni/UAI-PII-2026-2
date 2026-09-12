DateTime fecha1, fecha2;
TimeSpan diferencia;

Console.WriteLine("Ingrese la primera fecha");
fecha1 = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Ingrese la segunda fecha");
fecha2 = Convert.ToDateTime(Console.ReadLine());

diferencia = fecha1.Subtract(fecha2);

Console.WriteLine("La diferencia es de {0} dias", Math.Abs(diferencia.Days));
Console.ReadKey();
