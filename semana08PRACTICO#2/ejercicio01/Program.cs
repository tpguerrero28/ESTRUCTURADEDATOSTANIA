using System;
using System.Collections.Generic;

namespace AsignacionAuditorio
{
    class RegistroAuditorio
    {
        private Queue<string> cola1;
        private Queue<string> cola2;
        private string[] asientos;
        private int totalAsientos;

        public RegistroAuditorio(int capacidad)
        {
            cola1 = new Queue<string>();
            cola2 = new Queue<string>();
            asientos = new string[capacidad];
            totalAsientos = 0;
        }

        public void AgregarPersona(string nombre, int registrador)
        {
            if (registrador == 1)
                cola1.Enqueue(nombre);
            else if (registrador == 2)
                cola2.Enqueue(nombre);
            else
                Console.WriteLine("Registrador inválido");
        }

        public void AsignarAsientos()
        {
            while ((cola1.Count > 0 || cola2.Count > 0) && totalAsientos < asientos.Length)
            {
                if (cola1.Count > 0)
                {
                    asientos[totalAsientos] = cola1.Dequeue();
                    totalAsientos++;
                }

                if (cola2.Count > 0 && totalAsientos < asientos.Length)
                {
                    asientos[totalAsientos] = cola2.Dequeue();
                    totalAsientos++;
                }
            }
        }

        public void MostrarAsientos()
        {
            Console.WriteLine("\nLista de Asientos Asignados:");
            for (int i = 0; i < totalAsientos; i++)
            {
                Console.WriteLine($"Asiento {i + 1}: {asientos[i]}");
            }

            if (totalAsientos == asientos.Length)
                Console.WriteLine("\nTodos los asientos han sido asignados.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RegistroAuditorio auditorio = new RegistroAuditorio(100);

            // Simulación de ingreso de personas
            for (int i = 1; i <= 60; i++)
                auditorio.AgregarPersona("Persona_R1_" + i, 1); // Registrador 1

            for (int i = 1; i <= 50; i++)
                auditorio.AgregarPersona("Persona_R2_" + i, 2); // Registrador 2

            auditorio.AsignarAsientos();
            auditorio.MostrarAsientos();

            Console.WriteLine("\nProceso terminado.");
        }
    }
}
