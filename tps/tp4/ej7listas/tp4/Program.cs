using System;

namespace TP4_Listas7
{
    class NodoSimple
    {
        public int Numero;
        public string Nombre;
        public NodoSimple Siguiente;
    }

    class ListaEnlazadaSimple
    {
        private NodoSimple NodoInicial = null;

        public void Agregar(int numero, string nombre)
        {
            NodoSimple nuevo = new NodoSimple();

            nuevo.Numero = numero;
            nuevo.Nombre = nombre;
            nuevo.Siguiente = null;

            if (NodoInicial == null)
            {
                NodoInicial = nuevo;
            }
            else
            {
                NodoSimple actual = NodoInicial;

                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevo;
            }
        }

        public void Mostrar()
        {
            NodoSimple actual = NodoInicial;

            while (actual != null)
            {
                Console.WriteLine(
                    "Número: " + actual.Numero +
                    " | Nombre: " + actual.Nombre
                );

                actual = actual.Siguiente;
            }
        }

        public NodoSimple BuscarNodo(NodoSimple nodo, int numero)
        {
            if (nodo == null)
            {
                return null;
            }

            if (nodo.Numero == numero)
            {
                return nodo;
            }

            return BuscarNodo(nodo.Siguiente, numero);
        }

        public NodoSimple BuscarAnterior(NodoSimple nodo, int numero)
        {
            if (nodo == null || nodo.Siguiente == null)
            {
                return null;
            }

            if (nodo.Siguiente.Numero == numero)
            {
                return nodo;
            }

            return BuscarAnterior(nodo.Siguiente, numero);
        }

        public void IntercambiarDerecha(int numero)
        {
            NodoSimple nodo = BuscarNodo(NodoInicial, numero);

            if (nodo != null && nodo.Siguiente != null)
            {
                Intercambiar(nodo, nodo.Siguiente);
            }
        }

        public void IntercambiarIzquierda(int numero)
        {
            NodoSimple anterior = BuscarAnterior(NodoInicial, numero);
            NodoSimple nodo = BuscarNodo(NodoInicial, numero);

            if (anterior != null && nodo != null)
            {
                Intercambiar(anterior, nodo);
            }
        }

        public void Intercambiar(int numero1, int numero2)
        {
            NodoSimple nodo1 = BuscarNodo(NodoInicial, numero1);
            NodoSimple nodo2 = BuscarNodo(NodoInicial, numero2);

            if (nodo1 != null && nodo2 != null)
            {
                Intercambiar(nodo1, nodo2);
            }
        }

        private void Intercambiar(NodoSimple nodo1, NodoSimple nodo2)
        {
            int numeroAuxiliar = nodo1.Numero;
            string nombreAuxiliar = nodo1.Nombre;

            nodo1.Numero = nodo2.Numero;
            nodo1.Nombre = nodo2.Nombre;

            nodo2.Numero = numeroAuxiliar;
            nodo2.Nombre = nombreAuxiliar;
        }

        static void Main(string[] args)
        {
            ListaEnlazadaSimple lista = new ListaEnlazadaSimple();

            lista.Agregar(1, "Juan");
            lista.Agregar(2, "Maria");
            lista.Agregar(3, "Pedro");
            lista.Agregar(4, "Ivo");

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("===== LISTA =====");
                lista.Mostrar();

                Console.WriteLine();
                Console.WriteLine("===== MENÚ =====");
                Console.WriteLine("1 - Intercambiar hacia la derecha");
                Console.WriteLine("2 - Intercambiar hacia la izquierda");
                Console.WriteLine("3 - Intercambiar dos elementos");
                Console.WriteLine("0 - Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número: ");
                        int numeroDerecha = int.Parse(Console.ReadLine());

                        lista.IntercambiarDerecha(numeroDerecha);
                        break;

                    case 2:
                        Console.Write("Ingrese el número: ");
                        int numeroIzquierda = int.Parse(Console.ReadLine());

                        lista.IntercambiarIzquierda(numeroIzquierda);
                        break;

                    case 3:
                        Console.Write("Ingrese el primer número: ");
                        int numero1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el segundo número: ");
                        int numero2 = int.Parse(Console.ReadLine());

                        lista.Intercambiar(numero1, numero2);
                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
            }
        }
    }
}