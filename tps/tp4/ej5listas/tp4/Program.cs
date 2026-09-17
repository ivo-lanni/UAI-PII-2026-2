using System;
namespace TP4_Listas5
{
    class Paciente
    {
        public string nombre;
        public int codigo;
        public string apellido;
        public string direccion;
        public string telefono;

        public Paciente Anterior;
        public Paciente Siguiente;

    }
    class ListaDoblePacientes
    {
        private Paciente primero = null;
        private Paciente ultimo = null;
        public void AgregarPaciente(int codigo, string nombre, string apellido, string direccion, string telefono)
        {
            Paciente nuevo = new Paciente();
            nuevo.codigo = codigo;
            nuevo.nombre = nombre;
            nuevo.telefono = telefono;
            nuevo.direccion = direccion;

            nuevo.Anterior = null;
            nuevo.Siguiente = null;

            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;

            }
            else
            {
                nuevo.Anterior = ultimo;
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
        }
        public void MostrarPacientes()
        {
            if (primero == null)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }
            Paciente actual = primero;
            while (actual != null)
            {
                Console.WriteLine("Código: " + actual.codigo);
                Console.WriteLine("Nombre: " + actual.nombre);
                Console.WriteLine("Apellido: " + actual.apellido);
                Console.WriteLine("Dirección: " + actual.direccion);
                Console.WriteLine("Teléfono: " + actual.telefono);
                Console.WriteLine("------------------------------");

                actual = actual.Siguiente;
            }
        }
        static void Main(string[] args)
        {
            ListaDoblePacientes lista = new ListaDoblePacientes();
            lista.AgregarPaciente(
                1, "Juan", "Perez", "Calle 123", "1111-1111");

            lista.AgregarPaciente(
                2, "Maria", "Gomez", "Calle 456", "2222-2222");

            lista.AgregarPaciente(
                3, "Pedro", "Lopez", "Calle 789", "3333-3333");

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("===== MENÚ =====");
                Console.WriteLine("1 - Mostrar lista");
                Console.WriteLine("2 - Mostrar lista inversa");
                Console.WriteLine("3 - Eliminar paciente");
                Console.WriteLine("4 - Actualizar paciente");
                Console.WriteLine("0 - Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("===== LISTA DE PACIENTES =====");
                        lista.MostrarPacientes();
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("===== LISTA INVERSA =====");
                        lista.MostrarPacientesInverso();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.Write("Ingrese el código del paciente a eliminar: ");
                        int codigoEliminar = int.Parse(Console.ReadLine());

                        lista.EliminarPaciente(codigoEliminar);
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.Write("Ingrese el código del paciente a actualizar: ");
                        int codigoActualizar = int.Parse(Console.ReadLine());

                        lista.ActualizarPaciente(codigoActualizar);
                        break;

                    case 0:
                        Console.WriteLine();
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
            }
        }
    

        public void EliminarPaciente(int codigo)
        {
            Paciente actual = primero;

            while (actual != null && actual.codigo != codigo)
            {
                actual = actual.Siguiente;
            }

            if (actual == null)
            {
                Console.WriteLine("Paciente no encontrado.");
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

            Console.WriteLine("Paciente eliminado correctamente.");
        }
        public void MostrarPacientesInverso()
        {
            if (ultimo == null)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            Paciente actual = ultimo;

            while (actual != null)
            {
                Console.WriteLine("Código: " + actual.codigo);
                Console.WriteLine("Nombre: " + actual.nombre);
                Console.WriteLine("Apellido: " + actual.apellido);
                Console.WriteLine("Dirección: " + actual.direccion);
                Console.WriteLine("Teléfono: " + actual.telefono);
                Console.WriteLine("------------------------------");

                actual = actual.Anterior;
            }
        }
        public void ActualizarPaciente(int codigo)
        {
            Paciente actual = primero;

            while (actual != null && actual.codigo != codigo)
            {
                actual = actual.Siguiente;
            }

            if (actual == null)
            {
                Console.WriteLine("Paciente no encontrado.");
                return;
            }

            Console.WriteLine("Ingrese el nuevo nombre:");
            actual.nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo apellido:");
            actual.apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la nueva dirección:");
            actual.direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo teléfono:");
            actual.telefono = Console.ReadLine();

            Console.WriteLine("Paciente actualizado correctamente.");
        }
    }
    }