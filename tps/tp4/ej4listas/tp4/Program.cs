using System;
namespace TP4_Listas4
{
    class Chico
    {
        public string nombre;
        public string apellido;
        public int edad;
        public int dni;
        public Chico Siguiente;

    }
    class ListaCircular
    {
        private Chico ultimo = null;
        public void AgregarChico(string nombre, string apellido, int edad, int dni)
        {
            Chico nuevo = new Chico();
            nuevo.nombre = nombre;
            nuevo.apellido = apellido;
            nuevo.edad = edad;
            nuevo.dni = dni;
            if (ultimo == null)
            {
                ultimo = nuevo;
                nuevo.Siguiente = nuevo;
            }
            else
            {
                nuevo.Siguiente = ultimo.Siguiente;
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
        }
        public void MostrarChicos()
        {
            if (ultimo == null)
            {
                Console.WriteLine("No hay chicos en la lista.");
                return;
            }
            Chico primero = ultimo.Siguiente;
            Chico actual = primero;
            do
            {
                Console.WriteLine($"Nombre: {actual.nombre}, Apellido: {actual.apellido}, Edad: {actual.edad}, DNI: {actual.dni}");
                actual = actual.Siguiente;
            } while (actual != primero);
        }
        static void Main(string[] args)
        {
            ListaCircular lista = new ListaCircular();
            lista.AgregarChico("Neymar", "JR", 10, 12345678);
            lista.AgregarChico("Cristiano", "Ronaldo", 7, 87654321);
            lista.AgregarChico("Lionel", "Messi", 10, 11228344);
            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("====== PATO ÑATO ======");
                Console.WriteLine("1 - Mostrar participantes");
                Console.WriteLine("2 - Registrar nuevo chico");
                Console.WriteLine("3 - Actualizar participante");
                Console.WriteLine("4 - Agregar después de un participante");
                Console.WriteLine("5 - Comenzar torneo");
                Console.WriteLine("0 - Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("===== PARTICIPANTES =====");
                        lista.MostrarChicos();
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el nombre:");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el apellido:");
                        string apellido = Console.ReadLine();

                        Console.WriteLine("Ingrese la edad:");
                        int edad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el DNI:");
                        int dni = int.Parse(Console.ReadLine());

                        lista.AgregarChico(nombre, apellido, edad, dni);

                        Console.WriteLine("Chico registrado correctamente.");
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el DNI del participante a actualizar:");
                        int dniActualizar = int.Parse(Console.ReadLine());

                        lista.ActualizarChico(dniActualizar);
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el DNI del participante después del cual desea agregar:");
                        int dniBuscado = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el nombre del nuevo chico:");
                        string nombreNuevo = Console.ReadLine();

                        Console.WriteLine("Ingrese el apellido:");
                        string apellidoNuevo = Console.ReadLine();

                        Console.WriteLine("Ingrese la edad:");
                        int edadNueva = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el DNI:");
                        int dniNuevo = int.Parse(Console.ReadLine());

                        lista.AgregarDespues(
                            dniBuscado,
                            nombreNuevo,
                            apellidoNuevo,
                            edadNueva,
                            dniNuevo
                        );
                        break;

                    case 5:
                        lista.JugarPatoÑato();

                        Console.WriteLine();
                        Console.WriteLine("===== CHICO RESTANTE =====");
                        lista.MostrarChicos();

                        opcion = 0;
                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
            }

            Console.ReadKey();

        }
        public void JugarPatoÑato()
        {
            if (ultimo == null)
            {
                Console.WriteLine("No hay chicos en la lista para jugar.");
                return;
            }

            Random random = new Random();

            Chico actual = ultimo.Siguiente;
            Chico anterior = ultimo;

            Console.WriteLine();
            Console.WriteLine("===COMIENZA EL JUEGO===");

            while (actual != actual.Siguiente)
            {
                int pasos = random.Next(2, 7);

                Console.WriteLine();
                Console.WriteLine("===NUEVA RONDA===");

                for (int i = 1; i < pasos; i++)
                {
                    Console.WriteLine("Pato: " + actual.nombre);

                    anterior = actual;
                    actual = actual.Siguiente;
                    Console.WriteLine();
                    Console.WriteLine("Presione ENTER para comenzar la siguiente ronda...");
                    Console.ReadLine();
                }

                Console.WriteLine("Ñato: " + actual.nombre);
                Console.WriteLine(actual.nombre + " ha sido eliminado");

                anterior.Siguiente = actual.Siguiente;

                if (actual == ultimo)
                {
                    ultimo = anterior;
                }

                actual = anterior.Siguiente;
            }

            ultimo = actual;

            Console.WriteLine();
            Console.WriteLine("=====GANADOR=====");
            Console.WriteLine(actual.nombre + " es el ganador del pato ñato!");
        }
        public void ActualizarChico(int dni)
        {
            if (ultimo == null)
            {
                Console.WriteLine("No hay chicos en la list");
                return;
            }
            Chico actual = ultimo.Siguiente;
            do
            {

                if (actual.dni == dni)
                {
                    Console.WriteLine("Ingrese nuevo nombre: ");
                    actual.nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese nuevo apellido: ");
                    actual.apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese nueva edad: ");
                    actual.edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Chico actualizado correctamente.");
                    return;

                }
                actual = actual.Siguiente;

            } while (actual != ultimo.Siguiente);

            Console.WriteLine("Chico no encontrado");
        }
        public void AgregarDespues(int dniBuscado, string nombre, string apellido, int edad, int dni)
        {
            if (ultimo == null)
            {
                Console.WriteLine("No hay chicos en la lista");
                return;

            }
            Chico actual = ultimo.Siguiente;
            do
            {
                if(actual.dni== dniBuscado)
                {
                    Chico nuevo = new Chico();
                        nuevo.nombre = nombre;
                    nuevo.apellido = apellido;
                    nuevo.edad = edad;
                    nuevo.dni = dni;

                    nuevo.Siguiente = actual.Siguiente;
                    actual.Siguiente = nuevo;
                    if (actual == ultimo)
                    {
                        ultimo = nuevo;
                    }
                    Console.WriteLine("Chico agregado correctamente");
                    return;
                }
                actual= actual.Siguiente;

            }while(actual != ultimo.Siguiente);
            Console.WriteLine("Chico no encontrado.");
        }
    }
}
        

    