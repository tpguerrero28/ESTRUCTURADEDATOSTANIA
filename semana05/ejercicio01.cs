using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        List<string> asignaturas = new List<string> { "ESTRUCTURA DE DATOS", "ADMINISTRACION", "INSTALACION", "METODOLOGIA", "FUNDAMENTOS" };

        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("Yo estudio " + asignatura);
        }
    }
}

