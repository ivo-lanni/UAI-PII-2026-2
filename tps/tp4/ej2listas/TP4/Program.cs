using System;
namespace TP4_Listas2
{
    class Alumno
    {
        public string nombre;
        public string apellido;
        public int dni;
        public string fechaNacimiento;
        public string direccion;
        public string telefono;
        public Alumno Siguiente;

    }
    class listaAlumnos
    {
        private Alumno primero = null;
        public void AgregarAlumno(string nombre, string apellido, int dni, string fechaNacimiento, string direccion, string telefono)
        {
            Alumno nuevo = new Alumno();
            nuevo.nombre = nombre;
            nuevo.apellido = apellido;
            nuevo.dni = dni;
            nuevo.fechaNacimiento = fechaNacimiento;
            nuevo.direccion = direccion;
            nuevo.telefono = telefono;
            nuevo.Siguiente = null;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Alumno actual = primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }
        public void MostrarAlumnos()
        {
            Alumno actual = primero;
            if (actual == null)
            {
                Console.WriteLine("No hay alumnos en la lista.");
                return;
            }
            while (actual != null)
            {
                Console.WriteLine("Nombre: " + actual.nombre);
                Console.WriteLine("Apellido: " + actual.apellido);
                Console.WriteLine("DNI: " + actual.dni);
                Console.WriteLine("Fecha de Nacimiento: " + actual.fechaNacimiento);
                Console.WriteLine("Direccion: " + actual.direccion);
                Console.WriteLine("Telefono: " + actual.telefono);
                Console.WriteLine("------------------------------");
                actual = actual.Siguiente;
            }
        }
        static void Main(string[] args)
        {
            listaAlumnos lista = new listaAlumnos();
            lista.AgregarAlumno("Juan", "Perez", 12345678, "01/01/2000", "Calle Falsa 123", "123456789");
            lista.AgregarAlumno("Maria", "Gomez", 87654321, "02/02/2001", "Avenida Siempre Viva 456", "987654321");
            lista.AgregarAlumno("Pedro", "Lopez", 11223344, "03/03/2002", "Calle Real 789", "456789123"
                );
            Console.WriteLine("=====LISTA DE ALUMNOS=====");
            lista.MostrarAlumnos();
            Console.WriteLine();
            Console.WriteLine("Ingrese el DNI del alumno a eliminar:");
            int dniEliminarAlumno = int.Parse(Console.ReadLine());
            lista.EliminarAlumno(dniEliminarAlumno);
            Console.WriteLine();
            Console.WriteLine("=====LISTA DE ALUMNOS ACTUALIZADA=====");
            lista.MostrarAlumnos();
            Console.WriteLine();
            Console.WriteLine("Ingrese el DNI del alumno a actualizar:");
            int dniActualizarAlumno = int.Parse(Console.ReadLine());
            lista.ActualizarAlumno(dniActualizarAlumno);
            Console.WriteLine();
            Console.WriteLine("=====LISTA DE ALUMNOS ACTUALIZADA=====");
            lista.MostrarAlumnos();
            Console.WriteLine();
            Console.WriteLine("Ingrese el DNI del alumno después del cual desea agregar un nuevo alumno:");
            int dniDespues = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del nuevo alumno:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del nuevo alumno:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del nuevo alumno:");
            int dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de nacimiento del nuevo alumno:");
            string fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion del nuevo alumno:");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del nuevo alumno:");
            string telefono = Console.ReadLine();
            lista.AgregarDespues(dniDespues, nombre, apellido, dni, fechaNacimiento, direccion, telefono);
            Console.WriteLine();
            Console.WriteLine("=====LISTA DE ALUMNOS ACTUALIZADA=====");
            lista.MostrarAlumnos(); Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ingrese el DNI del alumno anntes del cual desea agregar un nuevo alumno:");
            int dniAntes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del nuevo alumno:");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del nuevo alumno:");
            string apellido2 = Console.ReadLine();
            Console.WriteLine("Ingrese el DNI del nuevo alumno:");
            int dni2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de nacimiento del nuevo alumno:");
            string fechaNacimiento2 = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion del nuevo alumno:");
            string direccion2 = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono del nuevo alumno:");
            string telefono2 = Console.ReadLine();
            lista.AgregarAntes(dniAntes, nombre2, apellido2, dni2, fechaNacimiento2, direccion2, telefono2);
            Console.WriteLine();
            Console.WriteLine("=====LISTA DE ALUMNOS ACTUALIZADA=====");
            lista.MostrarAlumnos();

            Console.ReadKey();
        }
        public void EliminarAlumno(int dni)
        {
            Alumno actual = primero;
            Alumno anterior = null;
            while (actual != null && actual.dni != dni)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("Alumno no encontrado.");
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
            Console.WriteLine("Alumno eliminado correctamente.");


        }
        public void ActualizarAlumno(int dni)
        {
            Alumno actual = primero;
            while (actual != null && actual.dni != dni)
            {
                actual = actual.Siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("Alumno no encontrado.");
                return;
            }
            Console.WriteLine("Ingrese el nuevo nombre del alumno:");
            actual.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo apellido del alumno:");
            actual.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva fecha de nacimiento del alumno:");
            actual.fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva direccion del alumno:");
            actual.direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo telefono del alumno:");
            actual.telefono = Console.ReadLine();
            Console.WriteLine("Alumno actualizado correctamente.");
        }
        public void AgregarDespues(int dniBuscado, string nombre, string apellido, int dni, string fechaNacimiento, string direccion, string telefono)
        {
            Alumno actual = primero;
            while (actual != null && actual.dni != dniBuscado)
            {
                actual = actual.Siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("Alumno no encontrado.");
                return;
            }
            Alumno nuevo = new Alumno();
            nuevo.nombre = nombre;
            nuevo.apellido = apellido;
            nuevo.dni = dni;
            nuevo.fechaNacimiento = fechaNacimiento;
            nuevo.direccion = direccion;
            nuevo.telefono = telefono;
            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;
            Console.WriteLine("Alumno agregado correctamente.");
        }
        public void AgregarAntes(int dniBuscado, string nombre, string apellido, int dni, string fechaNacimiento, string direccion, string telefono)
        {
            Alumno actual = primero;
            Alumno anterior = null;
            while (actual != null && actual.dni != dniBuscado)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("Alumno no encontrado.");
                return;
            }
            Alumno nuevo = new Alumno();
            nuevo.nombre = nombre;
            nuevo.apellido = apellido;
            nuevo.dni = dni;
            nuevo.fechaNacimiento = fechaNacimiento;
            nuevo.direccion = direccion;
            nuevo.telefono = telefono;
            if (anterior == null)
            {
                nuevo.Siguiente = primero;
                primero = nuevo;
            }
            else
            {
                nuevo.Siguiente = actual;
                anterior.Siguiente = nuevo;
            }
            Console.WriteLine("Alumno agregado correctamente.");
        }
    }
}