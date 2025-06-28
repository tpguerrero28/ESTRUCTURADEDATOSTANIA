using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 2:");
        List<string> materias = new List<string>
        {
           "ESTRUCTURA DE DATOS",
           "ADMINISTRACION",
           "FUNDAMENTOS",
           "INSTALACIONES",
           "METODOLOGIA"

        };
        float[] notas = new float[materias.Count];

        for (int i = 0; i < materias.Count; i++)
        {
            Console.Write("¿Qué nota sacaste en " + materias[i] + "? ");
            string? entrada = Console.ReadLine();

            // Validamos que entrada no sea null
            if (!string.IsNullOrWhiteSpace(entrada))
            {
                notas[i] = float.Parse(entrada);
            }
            else
            {
                notas[i] = 0; // Valor por defecto si no se escribe nada
            }
        }

        Console.WriteLine("\nResumen:");
        for (int i = 0; i < materias.Count; i++)
        {
            Console.WriteLine("En " + materias[i] + " sacaste " + notas[i]);
        }
    }
}
