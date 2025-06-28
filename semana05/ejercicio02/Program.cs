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
            Console.Write("¿QUE NOTA SACASTE EN " + materias[i] + "? ");
            string entrada = Console.ReadLine();
            notas[i] = float.Parse(entrada);
        }

        Console.WriteLine("\nResumen:");
        for (int i = 0; i < materias.Count; i++)
        {
            Console.WriteLine("EN " + materias[i] + " SACASTE " + notas[i]);
        }
    }
}
