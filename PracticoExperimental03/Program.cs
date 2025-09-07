using System;
using System.Collections.Generic;
using System.Linq;

namespace PremiacionDeportistas
{
    class Deportista
    {
        public string Nombre { get; set; }
        public string Disciplina { get; set; }
        public int Puntaje { get; set; }
        public string Medalla { get; set; }

        public Deportista(string nombre, string disciplina, int puntaje, string medalla = "")
        {
            Nombre = nombre;
            Disciplina = disciplina;
            Puntaje = puntaje;
            Medalla = medalla;
        }
    }

    class Program
    {
        static List<Deportista> deportistas = new List<Deportista>()
        {
            new Deportista("LIAM TOMALA", "Atletismo", 95),
            new Deportista("MAGNO MUÑOZ", "Natacion", 150),
            new Deportista("LEILA MUÑOZ", "Natacion", 220),
            new Deportista("NARCISA CAGUA", "Ciclismo", 92),
            new Deportista("VALESKA MUÑOZ", "Natacion", 200),
            new Deportista("BRYAN GARCIA", "Atletismo", 78),
            new Deportista("JEANCARLOS MORA", "Ciclismo", 90),
            new Deportista("LUCÍA FERNÁNDEZ", "Atletismo", 83),
            new Deportista("ROSALIA QUIÑONEZ", "Ciclismo", 75),
            new Deportista("ANTONIO GUERRERO", "Natacion", 75)
        };

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("--- Sistema de Premiación de Deportistas ---");
                Console.WriteLine("1. Registrar deportista");
                Console.WriteLine("2. Generar reportes y medallas");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarDeportista();
                        break;
                    case "2":
                        GenerarReportes();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RegistrarDeportista()
        {
            Console.WriteLine("\n--- Registrar Deportista ---");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine().Trim();

            string disciplina;
            do
            {
                Console.Write("Disciplina (Natacion, Atletismo, Ciclismo): ");
                disciplina = Console.ReadLine().Trim();
            } while (!new string[] { "Natacion", "Atletismo", "Ciclismo" }.Contains(disciplina, StringComparer.OrdinalIgnoreCase));

            int puntaje;
            Console.Write("Puntaje: ");
            while (!int.TryParse(Console.ReadLine(), out puntaje) || puntaje < 0)
            {
                Console.Write("Entrada inválida. Ingrese un número positivo: ");
            }

            // Asegurar capitalización correcta
            disciplina = char.ToUpper(disciplina[0]) + disciplina.Substring(1).ToLower();

            deportistas.Add(new Deportista(nombre, disciplina, puntaje));
            Console.WriteLine("Deportista registrado exitosamente. Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        static void GenerarReportes()
        {
            var disciplinas = deportistas.Select(d => d.Disciplina).Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var disciplina in disciplinas)
            {
                Console.WriteLine($"\n--- {disciplina} ---");
                var lista = deportistas
                    .Where(d => d.Disciplina.Equals(disciplina, StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(d => d.Puntaje)
                    .ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    string medalla;
                    switch (i)
                    {
                        case 0: medalla = "Oro"; break;
                        case 1: medalla = "Plata"; break;
                        case 2: medalla = "Bronce"; break;
                        case 3: medalla = "Diploma"; break;
                        default: medalla = "-"; break;
                    }
                    lista[i].Medalla = medalla;
                    Console.WriteLine($"{lista[i].Nombre} - Puntaje: {lista[i].Puntaje}, Medalla: {medalla}");
                }
            }

            Console.WriteLine("\nReporte completado. Presione cualquier tecla para volver al menú...");
            Console.ReadKey();
        }
    }
}


