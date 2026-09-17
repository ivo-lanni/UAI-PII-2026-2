using System;

namespace TP5_Ejercicio2
{
    class NodoAccion
    {
        public string Descripcion;
        public NodoAccion Siguiente;
    }

    class PilaDeAcciones
    {
        private NodoAccion tope;

        public bool HayAcciones()
        {
            return tope != null;
        }

        public void RegistrarAccion(string descripcion)
        {
            NodoAccion nuevo = new NodoAccion();

            nuevo.Descripcion = descripcion;
            nuevo.Siguiente = tope;
            tope = nuevo;
        }

        static void Main(string[] args)
        {
            PilaDeAcciones acciones = new PilaDeAcciones();

            acciones.RegistrarAccion("Escribir texto");
            acciones.RegistrarAccion("Aplicar negrita");
            acciones.RegistrarAccion("Insertar imagen");
            acciones.RegistrarAccion("Cambiar color");

            Console.WriteLine("Proxima a deshacer: " + acciones.VerUltimaAccion());

            Console.WriteLine("Deshacer: " + acciones.Deshacer());
            Console.WriteLine("Proxima a deshacer: " + acciones.VerUltimaAccion());

            Console.WriteLine();
            Console.WriteLine("Deshaciendo acciones restantes:");

            while (acciones.HayAcciones())
            {
                Console.WriteLine("Deshacer: " + acciones.Deshacer());
            }

            Console.ReadKey();
        }
        public string VerUltimaAccion()
        {
            if (!HayAcciones())
                return null;

            return tope.Descripcion;
        }

    
    public string Deshacer()
        {
            if (!HayAcciones())
                return null;

            string descripcion = tope.Descripcion;
            tope = tope.Siguiente;

            return descripcion;
        }
    }
}