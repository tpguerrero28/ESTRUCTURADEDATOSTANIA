using System;

class Program
{
    static void Main()
    {
        string[] materias = 
        { 
            "ESTRUCTURA DE DATOS", 
            "ADMINISTRACION", 
            "FUNDAMENTOS", 
            "INSTALACIONES", 
            "METODOLOGIA" 
        };

        for (int i = 0; i < materias.Length; i++)
        {
            Console.WriteLine(materias[i]);
        }
    }
}


