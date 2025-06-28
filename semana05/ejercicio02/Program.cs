using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 2:");
        List<string> materias = new List<string>
        {
            "Estructura de Datos",
            "Administración",
            "Fundamentos",
            "Instalaciones",
            "Metodología"
        };
        float[] notas = new float[materias.Count];

        for (int i = 0; i < materias.Count; i++)
        {
            Console.Write("¿Qué nota sacaste en " + materias[i] + "? ");
            string entrada = Console.ReadLine();
            notas[i] = float.Parse(entrada);
        }

        Console.WriteLine("\nResumen:");
        for (int i = 0; i < materias.Count; i++)
        {
            Console.WriteLine("En " + materias[i] + " sacaste " + notas[i]);
        }
    }
}
