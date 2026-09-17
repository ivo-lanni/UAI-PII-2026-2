using System;

namespace TP5_Ejercicio1
{
    class NodoPila
    {
        public int Dato;
        public NodoPila Siguiente;
    }

    class Pila
    {
        private NodoPila tope;

        public bool EstaVacia()
        {
            return tope == null;
        }

        public void Apilar(int dato)
        {
            NodoPila nuevo = new NodoPila();

            nuevo.Dato = dato;
            nuevo.Siguiente = tope;
            tope = nuevo;
        }

        static void Main(string[] args)
        {
            Pila pila = new Pila();

            pila.Apilar(10);
            pila.Apilar(20);
            pila.Apilar(30);

            Console.WriteLine("Tope de la pila: " + pila.VerTope());

            Console.WriteLine("Desapilado: " + pila.Desapilar());
            Console.WriteLine("Nuevo tope: " + pila.VerTope());

            Console.WriteLine();
            Console.WriteLine("Desapilando todo:");

            while (!pila.EstaVacia())
            {
                Console.WriteLine(pila.Desapilar());
            }
            Console.ReadKey();
        }
        public int VerTope()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila esta vacia");

            return tope.Dato;
        }
        public int Desapilar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila esta vacia");

            int dato = tope.Dato;
            tope = tope.Siguiente;

            return dato;
        }
    }
}