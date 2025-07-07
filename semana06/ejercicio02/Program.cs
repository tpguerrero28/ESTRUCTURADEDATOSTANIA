using System;

namespace RegistroEstudiantes
{
    class Estudiante
    {
        public string Cedula;
        public string Nombre;
        public string Apellido;
        public string Correo;
        public float Nota;
        public Estudiante Siguiente;

        public Estudiante(string cedula, string nombre, string apellido, string correo, float nota)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Nota = nota;
            Siguiente = null;
        }

        public override string ToString()
        {
            return $"Cédula: {Cedula}, Nombre: {Nombre} {Apellido}, Correo: {Correo}, Nota: {Nota}";
        }
    }

    class ListaEstudiantes
    {
        private Estudiante cabeza;

        public void AgregarEstudiante(Estudiante nuevo)
        {
            if (nuevo.Nota >= 7) // Aprobado → al inicio
            {
                nuevo.Siguiente = cabeza;
                cabeza = nuevo;
            }
            else // Reprobado → al final
            {
                if (cabeza == null)
                {
                    cabeza = nuevo;
                }
                else
                {
                    Estudiante actual = cabeza;
                    while (actual.Siguiente != null)
                    {
                        actual = actual.Siguiente;
                    }
                    actual.Siguiente = nuevo;
                }
            }
        }

        public void BuscarPorCedula(string cedula)
        {
            Estudiante actual = cabeza;
            while (actual != null)
            {
                if (actual.Cedula == cedula)
                {
                    Console.WriteLine("Estudiante encontrado:\n" + actual);
                    return;
                }
                actual = actual.Siguiente;
            }
            Console.WriteLine("Estudiante no encontrado.");
        }

        public void EliminarPorCedula(string cedula)
        {
            if (cabeza == null) return;

            if (cabeza.Cedula == cedula)
            {
                cabeza = cabeza.Siguiente;
                Console.WriteLine("Estudiante eliminado.");
                return;
            }

            Estudiante anterior = cabeza;
            Estudiante actual = cabeza.Siguiente;

            while (actual != null)
            {
                if (actual.Cedula == cedula)
                {
                    anterior.Siguiente = actual.Siguiente;
                    Console.WriteLine("Estudiante eliminado.");
                    return;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }

            Console.WriteLine("Estudiante no encontrado.");
        }

        public void ContarAprobadosYReprobados()
        {
            int aprobados = 0, reprobados = 0;
            Estudiante actual = cabeza;
            while (actual != null)
            {
                if (actual.Nota >= 7)
                    aprobados++;
                else
                    reprobados++;
                actual = actual.Siguiente;
            }
            Console.WriteLine($"Aprobados: {aprobados}");
            Console.WriteLine($"Reprobados: {reprobados}");
        }

        public void MostrarLista()
        {
            Console.WriteLine("\n--- Lista de Estudiantes ---");
            Estudiante actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine(actual);
                actual = actual.Siguiente;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ListaEstudiantes lista = new ListaEstudiantes();

            // Agregamos estudiantes
            lista.AgregarEstudiante(new Estudiante("0101", "Tania", "Guerrero", "tania@mail.com", 8.5f));
            lista.AgregarEstudiante(new Estudiante("0102", "Leila", "Muñoz", "leila@mail.com", 5.0f));
            lista.AgregarEstudiante(new Estudiante("0103", "Valeska", "Muñoz", "valeska@mail.com", 9.75f));
            lista.AgregarEstudiante(new Estudiante("0104", "Magno", "Muñoz", "magno@mail.com", 6.0f));

            lista.MostrarLista();

            // Buscar
            Console.WriteLine("\n🔍 Buscar estudiante con cédula 0103:");
            lista.BuscarPorCedula("0103");

            // Eliminar
            Console.WriteLine("\n🗑 Eliminar estudiante con cédula 0102:");
            lista.EliminarPorCedula("0102");
            lista.MostrarLista();

            // Contar
            Console.WriteLine("\n📊 Contar aprobados y reprobados:");
            lista.ContarAprobadosYReprobados();
        }
    }
}
