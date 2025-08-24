using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        Console.Clear();

        // 1. Crear 500 ciudadanos ficticios
        List<string> todos = new List<string>();
        for (int i = 1; i <= 500; i++)
            todos.Add($"Ciudadano {i}");

        // 2. Vacunados Pfizer: Ciudadano 1-75
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
            pfizer.Add($"Ciudadano {i}");

        // 3. Vacunados AstraZeneca: Ciudadano 76-150
        HashSet<string> astra = new HashSet<string>();
        for (int i = 76; i <= 150; i++)
            astra.Add($"Ciudadano {i}");

        // 4. Ciudadanos con ambas dosis: Ciudadano 151-175
        HashSet<string> ambasDosis = new HashSet<string>();
        for (int i = 151; i <= 175; i++)
            ambasDosis.Add($"Ciudadano {i}");

        // 5. No vacunados: Ciudadano 176-500
        HashSet<string> noVacunados = new HashSet<string>();
        for (int i = 176; i <= 500; i++)
            noVacunados.Add($"Ciudadano {i}");

        // 6. Mostrar conteo correcto
        Console.WriteLine("===== CAMPANA DE VACUNACION COVID-19 =====\n");
        Console.WriteLine($"1. Total ciudadanos: {todos.Count}");
        Console.WriteLine($"2. Vacunados con Pfizer: {pfizer.Count}");       // 75
        Console.WriteLine($"3. Vacunados con AstraZeneca: {astra.Count}");   // 75
        Console.WriteLine($"4. Ciudadanos con ambas dosis: {ambasDosis.Count}"); // 25
        Console.WriteLine($"5. No vacunados: {noVacunados.Count}");          // 325

        // 7. Mostrar listados
        Console.WriteLine("\n--- Listado de vacunados con Pfizer (75) ---");
        foreach (var c in pfizer.OrderBy(x => int.Parse(x.Split(' ')[1])))
            Console.WriteLine(c);

        Console.WriteLine("\n--- Listado de vacunados con AstraZeneca (75) ---");
        foreach (var c in astra.OrderBy(x => int.Parse(x.Split(' ')[1])))
            Console.WriteLine(c);

        Console.WriteLine("\n--- Listado de ciudadanos con ambas dosis (25) ---");
        foreach (var c in ambasDosis.OrderBy(x => int.Parse(x.Split(' ')[1])))
            Console.WriteLine(c);

        Console.WriteLine("\n--- Listado de ciudadanos no vacunados (325) ---");
        foreach (var c in noVacunados.OrderBy(x => int.Parse(x.Split(' ')[1])))
            Console.WriteLine(c);
    }
}
