﻿using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        List<string> asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine("Yo estudio " + asignatura);
        }
    }
}


