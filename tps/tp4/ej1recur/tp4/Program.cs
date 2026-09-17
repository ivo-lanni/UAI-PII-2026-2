using System;
namespace TP4_Recursividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaRegresiva(10);
            Console.ReadKey();
        }
        static void CuentaRegresiva(int n)
        {
            if (n == 0)

            {
                return;
            }
            Console.Write(n + " ");
            CuentaRegresiva(n - 1);
        }
    }
}