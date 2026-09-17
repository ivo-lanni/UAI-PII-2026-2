using System;

namespace TP5_Ejercicio3
{
    class NodoReclamo
    {
        public string Descripcion;
        public NodoReclamo Siguiente;
    }
    class NodoCaracter
    {
        public char Dato;
        public NodoCaracter Siguiente;
    }

    class PilaCaracteres
    {
        private NodoCaracter tope;

        public bool EstaVacia()
        {
            return tope == null;
        }

        public void Apilar(char caracter)
        {
            NodoCaracter nuevo = new NodoCaracter();

            nuevo.Dato = caracter;
            nuevo.Siguiente = tope;
            tope = nuevo;
        }

        public char Desapilar()
        {
            char dato = tope.Dato;
            tope = tope.Siguiente;

            return dato;
        }
    }
    class PilaDeReclamos
    {
        private NodoReclamo tope;

        public bool EstaVacia()
        {
            return tope == null;
        }

        public bool Apilar(string reclamo)
        {
            if (!EstaBalanceada(reclamo))
                return false;

            NodoReclamo nuevo = new NodoReclamo();

            nuevo.Descripcion = reclamo;
            nuevo.Siguiente = tope;
            tope = nuevo;

            return true;
        }

        public string VerProximo()
        {
            if (EstaVacia())
                return null;

            return tope.Descripcion;
        }

        public string Atender()
        {
            if (EstaVacia())
                return null;

            string descripcion = tope.Descripcion;
            tope = tope.Siguiente;

            return descripcion;
        }

        static void Main(string[] args)
        {
            PilaDeReclamos reclamos = new PilaDeReclamos();

            reclamos.Apilar("Cobro duplicado (mes de agosto)");
            reclamos.Apilar("Tarjeta bloqueada (sucursal centro)");
            reclamos.Apilar("Transferencia no acreditada (monto $50000)");

            Console.WriteLine("Proximo a atender:");
            Console.WriteLine(reclamos.VerProximo());

            Console.WriteLine();
            Console.WriteLine("Atendiendo:");
            Console.WriteLine(reclamos.Atender());

            Console.WriteLine();
            Console.WriteLine("Nuevo proximo:");
            Console.WriteLine(reclamos.VerProximo());

            bool agregado = reclamos.Apilar("Problema con tarjeta (no funciona)");
            if (agregado)
                Console.WriteLine("Reclamo agregado correctamente.");
            else
                Console.WriteLine("ERROR: el reclamo tiene parentesis desbalanceados.");

            Console.WriteLine();
            Console.WriteLine("Atendiendo: " + reclamos.Atender());

            Console.WriteLine("Reclamos pendientes: " + reclamos.Contar());

            Console.ReadKey();
        }
        private bool Coincide(char abre, char cierra)
        {
            return (abre == '(' && cierra == ')') ||
                   (abre == '[' && cierra == ']') ||
                   (abre == '{' && cierra == '}');
        }

        private bool EstaBalanceada(string expresion)
        {
            PilaCaracteres pila = new PilaCaracteres();

            foreach (char caracter in expresion)
            {
                if (caracter == '(' || caracter == '[' || caracter == '{')
                {
                    pila.Apilar(caracter);
                }
                else if (caracter == ')' || caracter == ']' || caracter == '}')
                {
                    if (pila.EstaVacia())
                        return false;

                    char abre = pila.Desapilar();

                    if (!Coincide(abre, caracter))
                        return false;
                }
            }

            return pila.EstaVacia();
        }
        public int Contar()
        {
            return ContarDesde(tope);
        }

        private int ContarDesde(NodoReclamo nodo)
        {
            if (nodo == null)
                return 0;

            return 1 + ContarDesde(nodo.Siguiente);
        }
    }
}