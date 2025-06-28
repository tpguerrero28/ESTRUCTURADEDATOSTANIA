using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 3:");
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }

        Console.WriteLine("Números del 10 al 1:");
        for (int j = numeros.Count - 1; j >= 0; j--)
        {
            Console.Write(numeros[j]);
            if (j != 0)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
