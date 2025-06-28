using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 5:");
        Console.Write("Escribe una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int a = 0, e = 0, i = 0, o = 0, u = 0;

        for (int x = 0; x < palabra.Length; x++)
        {
            char letra = palabra[x];

            if (letra == 'a') a++;
            else if (letra == 'e') e++;
            else if (letra == 'i') i++;
            else if (letra == 'o') o++;
            else if (letra == 'u') u++;
        }

        Console.WriteLine("\nVocales:");
        Console.WriteLine("a: " + a);
        Console.WriteLine("e: " + e);
        Console.WriteLine("i: " + i);
        Console.WriteLine("o: " + o);
        Console.WriteLine("u: " + u);
    }
}

