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

        foreach (string materia in materias)
        {
            Console.WriteLine("YO ESTUDIO " + materia);
        }
    }
}
