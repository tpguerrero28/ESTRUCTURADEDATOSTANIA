using System;
using System.Collections.Generic;

class TorreHanoi
{
    static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            return;
        }

        MoverDiscos(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
        MoverDiscos(1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
        MoverDiscos(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
    }

    static void Main()
    {
        Console.Write("Ingrese el número de discos: ");
        int n = int.Parse(Console.ReadLine());

        Stack<int> origen = new Stack<int>();
        Stack<int> destino = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();

        for (int i = n; i >= 1; i--)
            origen.Push(i);

        Console.WriteLine("Secuencia de movimientos:");
        MoverDiscos(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }
}
