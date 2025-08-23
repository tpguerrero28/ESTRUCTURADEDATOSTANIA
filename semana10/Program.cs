using System;
using System.Collections.Generic;

class Program
{
    // Random global para evitar repetición de semillas
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("2525 - ESTRUCTURA DE DATOS - UEA / SEMANA 10\n");

        // =========================================================================
        // 1. Crear conjunto de 500 ciudadanos (Universo U)
        // =========================================================================
        HashSet<string> universo = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            universo.Add("Ciudadano " + i);
        }

        // =========================================================================
        // 2. Crear conjunto ficticio de 75 vacunados con Pfizer
        // =========================================================================
        HashSet<string> pfizer = GenerarVacunados("Pfizer");

        // =========================================================================
        // 3. Crear conjunto ficticio de 75 vacunados con AstraZeneca
        // =========================================================================
        HashSet<string> astraZeneca = GenerarVacunados("AstraZeneca");

        // =========================================================================
        // 4. Operaciones de teoría de conjuntos
        // =========================================================================

        // vacunados = (Pfizer ∪ AstraZeneca)
        var vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astraZeneca);

        // no vacunados = U - (Pfizer ∪ AstraZeneca)
        var noVacunados = new HashSet<string>(universo);
        noVacunados.ExceptWith(vacunados);

        // ambas dosis = Pfizer ∩ AstraZeneca
        var ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // solo Pfizer = Pfizer - AstraZeneca
        var soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // solo AstraZeneca = AstraZeneca - Pfizer
        var soloAstra = new HashSet<string>(astraZeneca);
        soloAstra.ExceptWith(pfizer);

        // =========================================================================
        // 5. Mostrar resultados
        // =========================================================================
        MostrarResumen(universo, pfizer, astraZeneca, noVacunados, ambasDosis, soloPfizer, soloAstra);

        // (Opcional) Mostrar listados completos
        /*
        Console.WriteLine("\n-- No vacunados --");
        foreach (var c in noVacunados) Console.WriteLine(c);

        Console.WriteLine("\n-- Ambas dosis --");
        foreach (var c in ambasDosis) Console.WriteLine(c);

        Console.WriteLine("\n-- Solo Pfizer --");
        foreach (var c in soloPfizer) Console.WriteLine(c);

        Console.WriteLine("\n-- Solo AstraZeneca --");
        foreach (var c in soloAstra) Console.WriteLine(c);
        */
    }

    // Método para generar ciudadanos vacunados aleatoriamente
    static HashSet<string> GenerarVacunados(string vacuna)
    {
        HashSet<string> conjunto = new HashSet<string>();
        while (conjunto.Count < 75)
        {
            int numero = random.Next(1, 501); // incluye al 500
            conjunto.Add("Ciudadano " + numero);
        }
        return conjunto;
    }

    // Método auxiliar para imprimir resultados
    static void MostrarResumen(HashSet<string> universo,
                               HashSet<string> pfizer,
                               HashSet<string> astraZeneca,
                               HashSet<string> noVacunados,
                               HashSet<string> ambasDosis,
                               HashSet<string> soloPfizer,
                               HashSet<string> soloAstra)
    {
        Console.WriteLine("=== Campaña de Vacunación COVID-19 ===");
        Console.WriteLine($"Total ciudadanos: {universo.Count}");
        Console.WriteLine($"Vacunados con Pfizer: {pfizer.Count}");
        Console.WriteLine($"Vacunados con AstraZeneca: {astraZeneca.Count}");
        Console.WriteLine($"No vacunados: {noVacunados.Count}");
        Console.WriteLine($"Con ambas dosis: {ambasDosis.Count}");
        Console.WriteLine($"Solo Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Solo AstraZeneca: {soloAstra.Count}");
    }
}
