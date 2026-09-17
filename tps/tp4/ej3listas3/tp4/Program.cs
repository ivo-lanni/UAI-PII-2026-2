using System;
namespace TP4_Listas3
{
    class Persona
    {
        public int numero;
        public int edad;
        public decimal precioEntrada;
        public Persona Siguiente;

    }
    class ListaPersonas
    {
        private Persona primero = null;
        public void AgregarPersona(int numero, int edad, decimal precioEntrada)
        {
            Persona nueva = new Persona();
            nueva.numero = numero;
            nueva.edad = edad;
            nueva.precioEntrada = precioEntrada;
            nueva.Siguiente = null;
            if (primero == null)
            {
                primero = nueva;
            }
            else
            {
                Persona actual = primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nueva;
            }
        }
        public void MostrarPersonas()
        {
            Persona actual = primero;
            if (actual == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            while (actual != null)
            {
                Console.WriteLine("Persona N°: " + actual.numero);
                Console.WriteLine("Edad: " + actual.edad);
                Console.WriteLine("Precio entrada: $" + actual.precioEntrada);
                Console.WriteLine("------------------------------");

                actual = actual.Siguiente;
            }
        }
        static void Main(string[] args)
        {
            ListaPersonas lista = new ListaPersonas();
            Random random = new Random();

            int cantidadPersonas = random.Next(0, 51);

            for (int i = 1; i <= cantidadPersonas; i++)
            {
                int edad = random.Next(5, 61);
                decimal precioEntrada = lista.CalcularPrecio(edad);

                lista.AgregarPersona(i, edad, precioEntrada);
            }

            Console.WriteLine("Cantidad de personas generadas: " + cantidadPersonas);
            lista.MostrarPersonas();
            Console.WriteLine("Recaudación total: $" + lista.CalcularRecaudacion());

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("===== MENÚ =====");
                Console.WriteLine("1 - Agregar persona");
                Console.WriteLine("2 - Eliminar persona");
                Console.WriteLine("3 - Actualizar persona");
                Console.WriteLine("4 - Agregar persona después de otra");
                Console.WriteLine("5 - Mostrar lista");
                Console.WriteLine("0 - Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("======AGREGAR NUEVA PERSONA======");
                        Console.Write("Ingrese el número de la persona: ");
                        int numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la edad de la persona: ");
                        int edadNueva = int.Parse(Console.ReadLine());
                        decimal precioNuevo = lista.CalcularPrecio(edadNueva);

                        lista.AgregarPersona(numero, edadNueva, precioNuevo);
                        Console.WriteLine("Persona agregada correctamente.");
                        Console.WriteLine();
                        Console.WriteLine("=====LISTA DE PERSONAS ACTUALIZADA=====");
                        lista.MostrarPersonas();

                        Console.WriteLine();
                        Console.WriteLine("Recaudación total actualizada: $" + lista.CalcularRecaudacion());
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero de la persona que desea eliminar: ");
                        int numeroEliminar = int.Parse(Console.ReadLine());
                        lista.ELiminarPersona(numeroEliminar);

                        Console.WriteLine();
                        Console.WriteLine("=====LISTA DE PERSONAS ACTUALIZADA=====");
                        lista.MostrarPersonas();
                        Console.WriteLine();
                        Console.WriteLine("Recaudación total actualizada: $" + lista.CalcularRecaudacion());
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero de la persona que desea actualizar: ");
                        int numeroActualizar = int.Parse(Console.ReadLine());
                        lista.ActualizarPersona(numeroActualizar);
                        Console.WriteLine();
                        Console.WriteLine("=====LISTA DE PERSONAS ACTUALIZADA=====");
                        lista.MostrarPersonas();
                        Console.WriteLine();
                        Console.WriteLine("Recaudación total actualizada: $" + lista.CalcularRecaudacion());

                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el número de persona después del cual desea agregar una nueva persona: ");
                        int numeroBuscado = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el número de la nueva persona: ");
                        int numeroNuevoDespues = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la edad de la nueva persona: ");
                        int edadNuevaDespues = int.Parse(Console.ReadLine());
                        lista.AgregarDespues(numeroBuscado, numeroNuevoDespues, edadNuevaDespues);
                        Console.WriteLine();
                        Console.WriteLine("=====LISTA DE PERSONAS ACTUALIZADA=====");
                        lista.MostrarPersonas();

                        break;

                    case 5:
                        lista.MostrarPersonas();
                        Console.WriteLine("Recaudación total: $" + lista.CalcularRecaudacion());
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
        public decimal CalcularPrecio(int edad)
        {
            if (edad < 12)
            {
                return 3000;
            }
            else if (edad >= 12 && edad <= 17)
            {
                return 4000;
            }
            else if (edad >= 18 && edad <= 59)
            {
                return 6000;
            }
            else
            {
                return 3000;
            }
        }
        public decimal CalcularRecaudacion()
        {
            decimal total = 0;

            Persona actual = primero;

            while (actual != null)
            {
                total = total + actual.precioEntrada;
                actual = actual.Siguiente;
            }

            return total;
        }
        public void ELiminarPersona(int numero)
        {
            Persona actual = primero;
            Persona anterior = null;
            while (actual != null && actual.numero != numero)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("No se encontró la persona con el número: " + numero);
                return;
            }
            if (anterior == null)
            {
                primero = actual.Siguiente;
            }
            else
            {
                anterior.Siguiente = actual.Siguiente;
            }
            Console.WriteLine("Persona con el número " + numero + " eliminada correctamente.");
        }
        public void ActualizarPersona(int numero)
        {
            Persona actual = primero;
            while (actual != null && actual.numero != numero)
            {
                actual = actual.Siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("No se encontró la persona con el número: " + numero);
                return;
            }
            Console.WriteLine("Ingrese la nueva edad de la persona: ");
            int nuevaEdad = int.Parse(Console.ReadLine());
            decimal nuevoPrecio = CalcularPrecio(nuevaEdad);
            actual.edad = nuevaEdad;
            actual.precioEntrada = nuevoPrecio;
            Console.WriteLine("Persona con el número " + numero + " actualizada correctamente.");
        }
        public void AgregarDespues(int numeroBuscado, int numero, int edad)
        {
            Persona actual = primero;
            while (actual != null && actual.numero != numeroBuscado)
            {
                actual = actual.Siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("No se encontró la persona con el número: " + numeroBuscado);
                return;
            }
            Persona nueva = new Persona();
            nueva.numero = numero;
            nueva.edad = edad;
            nueva.precioEntrada = CalcularPrecio(edad);
            nueva.Siguiente = actual.Siguiente;
            actual.Siguiente = nueva;
            Console.WriteLine("Persona agregada después del número " + numeroBuscado + " correctamente.");

            
        }
    }
}
    
