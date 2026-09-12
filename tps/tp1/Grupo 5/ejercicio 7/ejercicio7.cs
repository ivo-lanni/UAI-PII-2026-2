int kb, bits;

Console.WriteLine("Ingrese la cantidad de KBytes");
kb = Convert.ToInt32(Console.ReadLine());

bits = kb * 1024 * 8;

Console.WriteLine("La cantidad de bits es {0}", bits);
Console.ReadKey();
