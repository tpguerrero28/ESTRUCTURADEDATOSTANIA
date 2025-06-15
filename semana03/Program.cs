using System;

namespace RegistroEstudiantes
{
    // Clase que representa un Estudiante con datos personales y teléfonos
    public class Estudiante
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string direccion;
        private string[] telefonos; // Array para manejar tres teléfonos

        // Constructor que valida y asigna los datos
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            if (telefonos.Length != 3)
                throw new ArgumentException("Se requieren exactamente 3 teléfonos.");
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefonos = telefonos;
        }

        // Propiedades para acceder a los campos
        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string[] Telefonos => telefonos;

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nombre: {nombres} {apellidos}");
            Console.WriteLine($"Dirección: {direccion}");
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < telefonos.Length; i++)
                Console.WriteLine($"  Teléfono {i+1}: {telefonos[i]}");
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            // Array con los tres teléfonos de Tania Pamela Guerrero Mora
            string[] misTelefonos = { "0978798419", "0991234567", "0999876543" };

            // Crear el objeto Estudiante con tus datos personales
            Estudiante estudiante = new Estudiante(
                1,
                "TANIA PAMELA",
                "GUERRERO MORA",
                "Samanes 2",
                misTelefonos
            );

            // Mostrar la información del estudiante por consola
            estudiante.MostrarInformacion();
        }
    }
}
