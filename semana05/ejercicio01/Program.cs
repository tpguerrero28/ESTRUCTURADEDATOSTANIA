using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1:");
        List<string> materias = new List<string>
        {
            "ESTRUCTURA DE DATOS",
            "ADMINISTRACION",
            "FUNDAMENTOS",
            "INSTALACIONES",
            "METODOLOGIA"
        };

        for (int i = 0; i < materias.Count; i++)
        {
            Console.WriteLine("YO ESTUDIO " + materias[i]);
        }
    }
}
