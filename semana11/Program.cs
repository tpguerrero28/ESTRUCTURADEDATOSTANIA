using System;
using System.Collections.Generic;

class Traductor
{
    static void Main()
    {
        // Diccionario inicial
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"child", "niño"},
            {"eye", "ojo"},
            {"woman", "mujer"},
            {"place", "lugar"},
            {"work", "trabajo"}
        };

        int opcion;

        do
        {
            Console.WriteLine("==================== MENÚ ====================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.\n");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    TraducirFrase(diccionario);
                    break;
                case 2:
                    AgregarPalabra(diccionario);
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.\n");
                    break;
            }

        } while (opcion != 0);
    }

    static void TraducirFrase(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la frase a traducir: ");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ', ',', '.', ';', ':'); // Separar por espacios y signos de puntuación
        string traduccion = frase;

        foreach (string palabra in palabras)
        {
            string palabraTrim = palabra.Trim();
            if (diccionario.ContainsKey(palabraTrim.ToLower()))
            {
                // Reemplazar solo la palabra exacta usando Regex
                traduccion = System.Text.RegularExpressions.Regex.Replace(
                    traduccion,
                    @"\b" + palabraTrim + @"\b",
                    diccionario[palabraTrim.ToLower()],
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase
                );
            }
        }

        Console.WriteLine("Traducción parcial: " + traduccion + "\n");
    }

    static void AgregarPalabra(Dictionary<string, string> diccionario)
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine().Trim();

        Console.Write("Ingrese la traducción en español: ");
        string espanol = Console.ReadLine().Trim();

        if (!diccionario.ContainsKey(ingles))
        {
            diccionario.Add(ingles, espanol);
            Console.WriteLine($"Palabra agregada: {ingles} => {espanol}\n");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.\n");
        }
    }
}
