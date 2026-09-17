using System;

namespace TP4_Listas6
{
    class Persona
    {
        public int numero;
        public int edad;
        public decimal precioEntrada;

        public Persona Anterior;
        public Persona Siguiente;
    }

    class ListaDobleCine
    {
        private Persona primero = null;
        private Persona ultimo = null;

        public decimal CalcularPrecio(int edad)
        {
            if (edad < 12)
                return 3000;
            else if (edad <= 17)
                return 4000;
            else if (edad <= 59)
                return 6000;
            else
                return 3000;
        }

        public void AgregarPersona(int numero, int edad)
        {
            Persona nueva = new Persona();

            nueva.numero = numero;
            nueva.edad = edad;
            nueva.precioEntrada = CalcularPrecio(edad);
            nueva.Anterior = null;
            nueva.Siguiente = null;

            if (primero == null)
            {
                primero = nueva;
                ultimo = nueva;
            }
            else
            {
                nueva.Anterior = ultimo;
                ultimo.Siguiente = nueva;
                ultimo = nueva;
            }
        }

        public void MostrarPersonas()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Persona actual = primero;

            while (actual != null)
            {
                Console.WriteLine(
                    "N°: " + actual.numero +
                    " | Edad: " + actual.edad +
                    " | Entrada: $" + actual.precioEntrada
                );

                actual = actual.Siguiente;
            }
        }

        public void MostrarInverso()
        {
            if (ultimo == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Persona actual = ultimo;

            while (actual != null)
            {
                Console.WriteLine(
                    "N°: " + actual.numero +
                    " | Edad: " + actual.edad +
                    " | Entrada: $" + actual.precioEntrada
                );

                actual = actual.Anterior;
            }
        }

        public decimal CalcularRecaudacion()
        {
            decimal total = 0;

            Persona actual = primero;

            while (actual != null)
            {
                total += actual.precioEntrada;
                actual = actual.Siguiente;
            }

            return total;
        }

        public void EliminarPersona(int numero)
        {
            Persona actual = primero;

            while (actual != null && actual.numero != numero)
            {
                actual = actual.Siguiente;
            }

            if (actual == null)
            {
                Console.WriteLine("Persona no encontrada.");
                return;
            }

            if (actual.Anterior == null)
            {
                primero = actual.Siguiente;
            }
            else
            {
                actual.Anterior.Siguiente = actual.Siguiente;
            }

            if (actual.Siguiente == null)
            {
                ultimo = actual.Anterior;
            }
            else
            {
                actual.Siguiente.Anterior = actual.Anterior;
            }

            Console.WriteLine("Persona eliminada correctamente.");
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
                Console.WriteLine("Persona no encontrada.");
                return;
            }

            Console.Write("Ingrese la nueva edad: ");
            actual.edad = int.Parse(Console.ReadLine());

            actual.precioEntrada = CalcularPrecio(actual.edad);

            Console.WriteLine("Persona actualizada correctamente.");
        }

        static void Main(string[] args)
        {
            ListaDobleCine lista = new ListaDobleCine();
            Random random = new Random();

            int cantidad = random.Next(0, 51);

            for (int i = 1; i <= cantidad; i++)
            {
                int edad = random.Next(5, 61);
                lista.AgregarPersona(i, edad);
            }

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("===== CINE =====");
                Console.WriteLine("1 - Mostrar lista");
                Console.WriteLine("2 - Mostrar lista inversa");
                Console.WriteLine("3 - Registrar nueva persona");
                Console.WriteLine("4 - Eliminar persona");
                Console.WriteLine("5 - Actualizar persona");
                Console.WriteLine("6 - Mostrar recaudación");
                Console.WriteLine("0 - Salir");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        lista.MostrarPersonas();
                        break;

                    case 2:
                        lista.MostrarInverso();
                        break;

                    case 3:
                        Console.Write("Número: ");
                        int numero = int.Parse(Console.ReadLine());

                        Console.Write("Edad: ");
                        int edad = int.Parse(Console.ReadLine());

                        lista.AgregarPersona(numero, edad);
                        Console.WriteLine("Persona registrada.");
                        break;

                    case 4:
                        Console.Write("Número de persona a eliminar: ");
                        int numeroEliminar = int.Parse(Console.ReadLine());

                        lista.EliminarPersona(numeroEliminar);
                        break;

                    case 5:
                        Console.Write("Número de persona a actualizar: ");
                        int numeroActualizar = int.Parse(Console.ReadLine());

                        lista.ActualizarPersona(numeroActualizar);
                        break;

                    case 6:
                        Console.WriteLine(
                            "Recaudación total: $" +
                            lista.CalcularRecaudacion()
                        );
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