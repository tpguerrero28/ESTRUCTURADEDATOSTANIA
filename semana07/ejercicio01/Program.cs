using System;
using System.Collections.Generic;

class BalanceoParentesis
{
    static bool EstaBalanceado(string expresion)
    {
        Stack<char> pila = new Stack<char>();
        foreach (char c in expresion)
        {
            if (c == '(' || c == '[' || c == '{')
                pila.Push(c);
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0)
                    return false;

                char tope = pila.Pop();
                if ((c == ')' && tope != '(') ||
                    (c == ']' && tope != '[') ||
                    (c == '}' && tope != '{'))
                    return false;
            }
        }
        return pila.Count == 0;
    }

    static void Main()
    {
        Console.Write("Ingrese una expresión matemática: ");
        string expresion = Console.ReadLine();

        if (EstaBalanceado(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}
