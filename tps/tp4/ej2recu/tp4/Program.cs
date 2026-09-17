using System;
namespace TP4_Recursividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            long resultado;
            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());
            resultado = Factorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {resultado}");
            Console.ReadKey();
        }
        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;

            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

    }
}