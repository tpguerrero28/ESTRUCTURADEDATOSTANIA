using System;
using System.Collections.Generic;

class Ejercicio3
{
    static void Main()
    {
        List<string> asignaturas = new List<string> { "ESTRUCTURA DE DATOS", "ADMINISTRACION", "INSTALACIONES", "METODOLOGIA", "FUNDAMENTOS" };
        List<float> notas = new List<float>();

        foreach (string asignatura in asignaturas)
        {
            Console.Write("Ingresa la nota de " + asignatura + ": ");
            float nota = float.Parse(Console.ReadLine());
            notas.Add(nota);
        }

        Console.WriteLine("\nResumen de notas:");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine("En " + asignaturas[i] + " has sacado " + notas[i]);
        }
    }
}
