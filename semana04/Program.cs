using System;

// Clase que representa un aporte realizado por un empleado
class Aporte {
    // Propiedades del aporte
    public string Cedula { get; set; }        // Identificación del empleado
    public string Nombre { get; set; }        // Nombre del empleado
    public decimal Monto { get; set; }        // Monto aportado
    public DateTime Fecha { get; set; }       // Fecha del aporte
    public string Descripcion { get; set; }   // Descripción del aporte

    // Método para mostrar los datos del aporte
    public void Mostrar() {
        Console.WriteLine($"Cédula: {Cedula} | Nombre: {Nombre} | Monto: ${Monto} | Fecha: {Fecha.ToShortDateString()} | {Descripcion}");
    }
}

class Program {
    static void Main() {
        const int MAX = 200; // Número máximo de registros permitidos
        Aporte[] registros = new Aporte[MAX]; // Arreglo que almacenará los aportes
        int contador = 0; // Contador de aportes registrados
        int opcion; // Variable para controlar el menú

        do {
            // Menú principal
            Console.WriteLine("\n--- MENÚ DE APORTES ---");
            Console.WriteLine("1. Agregar aporte");
            Console.WriteLine("2. Ver todos los aportes");
            Console.WriteLine("3. Buscar por cédula");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            // Conversión segura de la opción ingresada
            bool esNumero = int.TryParse(Console.ReadLine(), out opcion);

            if (!esNumero) {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            switch (opcion) {
                case 1:
                    // Agregar un nuevo aporte
                    if (contador < MAX) {
                        Aporte nuevo = new Aporte();

                        // Captura de datos por consola
                        Console.Write("Cédula: ");
                        nuevo.Cedula = Console.ReadLine();

                        Console.Write("Nombre: ");
                        nuevo.Nombre = Console.R
