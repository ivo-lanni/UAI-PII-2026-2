using System;
    namespace TP4_Recursividad3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector= { 8 , 3 , 6, 1 , 9 , 2 , 5 };
            Console.WriteLine("El vector original es: ");
            MostrarVector(vector);
            OrdenarRecursivo(vector, vector.Length);

            Console.WriteLine();
            Console.WriteLine("El vector ordenado es: ");
            MostrarVector(vector);
            Console.ReadKey();
        }
        static void MostrarVector(int[] vector)
        {
            for (int i= 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
        static void OrdenarRecursivo(int[] vector, int n)
        {
            if (n == 1)
                return;
            for (int i = 0; i < n - 1; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    int temp = vector[i];
                    vector[i] = vector[i + 1];
                    vector[i + 1] = temp;
                }
            }
            OrdenarRecursivo(vector, n - 1);
        }
    }
}