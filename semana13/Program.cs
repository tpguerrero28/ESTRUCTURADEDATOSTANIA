using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Catálogo de revistas con los títulos indicados
        static List<string> catalogo = new List<string>()
        {
            "National Geographic",
            "Sports Illustrated",
            "Forbes",
            "Vogue",
            "Mac",
            "Rolling Stone",
            "Automobile Magazine",
            "Classic Cars",
            "Computerworld",
            "Time"
        };

        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                // Menú interactivo
                Console.WriteLine("\n--- Catálogo de Revistas ---");
                Console.WriteLine("1. Buscar título (Iterativa)");
                Console.WriteLine("2. Buscar título (Recursiva)");
                Console.WriteLine("3. Mostrar catálogo completo");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el título a buscar: ");
                        string tituloIter = Console.ReadLine();
                        bool encontradoIter = BuscarIterativa(tituloIter);
                        Console.WriteLine(encontradoIter ? "Encontrado" : "No encontrado");
                        break;

                    case "2":
                        Console.Write("Ingrese el título a buscar: ");
                        string tituloRec = Console.ReadLine();
                        bool encontradoRec = BuscarRecursiva(tituloRec, 0);
                        Console.WriteLine(encontradoRec ? "Encontrado" : "No encontrado");
                        break;

                    case "3":
                        Console.WriteLine("\nCatálogo de revistas:");
                        foreach (var revista in catalogo)
                        {
                            Console.WriteLine("- " + revista);
                        }
                        break;

                    case "4":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }

            Console.WriteLine("Programa finalizado.");
        }

        // Búsqueda iterativa
        static bool BuscarIterativa(string titulo)
        {
            foreach (var revista in catalogo)
            {
                if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        // Búsqueda recursiva
        static bool BuscarRecursiva(string titulo, int indice)
        {
            if (indice >= catalogo.Count)
                return false;

            if (catalogo[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;

            return BuscarRecursiva(titulo, indice + 1);
        }
    }
}
