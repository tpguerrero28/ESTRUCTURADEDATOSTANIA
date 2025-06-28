using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 4:");
        List<string> materias = new List<string>
        {
            "ESTRUCTURA DE DATOS",
            "ADMINISTRACION",
            "FUNDAMENTOS",
            "INSTALACIONES",
            "METODOLOGIA"
        };
        List<string> repetir = new List<string>();

        for (int i = 0; i < materias.Count; i++)
        {
            Console.Write("Nota de " + materias[i] + ": ");
            float nota = float.Parse(Console.ReadLine());

            if (nota < 7)
            {
                repetir.Add(materias[i]);
            }
        }

        Console.WriteLine("\nTienes que repetir:");
        for (int j = 0; j < repetir.Count; j++)
        {
            Console.WriteLine(repetir[j]);
        }
    }
}
