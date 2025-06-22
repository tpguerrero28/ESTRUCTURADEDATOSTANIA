using System;

struct Empleado
{
    public int Id;
    public string Nombre;
    public string Cargo;
    public double Aporte;
}

class RegistroAportes
{
    Empleado[] empleados;
    int cantidadEmpleados;

    public RegistroAportes(int maxEmpleados)
    {
        empleados = new Empleado[maxEmpleados];
        cantidadEmpleados = 0;
    }

    public void AgregarEmpleado(int id, string nombre, string cargo, double aporte)
    {
        for (int i = 0; i < cantidadEmpleados; i++)
        {
            if (empleados[i].Id == id)
            {
                Console.WriteLine("Ya existe un empleado con este ID.");
                return;
            }
        }

        if (cantidadEmpleados < empleados.Length)
        {
            empleados[cantidadEmpleados].Id = id;
            empleados[cantidadEmpleados].Nombre = nombre;
            empleados[cantidadEmpleados].Cargo = cargo;
            empleados[cantidadEmpleados].Aporte = aporte;
            cantidadEmpleados++;
            Console.WriteLine("Empleado agregado correctamente.");
        }
        else
        {
            Console.WriteLine("No se pueden agregar más empleados, capacidad llena.");
        }
    }

    public void MostrarEmpleados()
    {
        Console.WriteLine("\nLista de empleados y sus aportes:");
        Console.WriteLine("ID\tNombre\t\tCargo\t\tAporte");
        Console.WriteLine("--------------------------------------------------");

        for (int i = 0; i < cantidadEmpleados; i++)
        {
            Console.WriteLine($"{empleados[i].Id}\t{empleados[i].Nombre}\t{empleados[i].Cargo}\t{empleados[i].Aporte:C}");
        }
    }

    public double TotalAportes()
    {
        double total = 0;
        for (int i = 0; i < cantidadEmpleados; i++)
        {
            total += empleados[i].Aporte;
        }
        return total;
    }

    public void BuscarEmpleado(int id)
    {
        for (int i = 0; i < cantidadEmpleados; i++)
        {
            if (empleados[i].Id == id)
            {
                Console.WriteLine($"Empleado encontrado: {empleados[i].Nombre}, Cargo: {empleados[i].Cargo}, Aporte: {empleados[i].Aporte:C}");
                return;
            }
        }
        Console.WriteLine("Empleado no encontrado.");
    }
}

class Program
{
    static void Main()
    {
        RegistroAportes registro = new RegistroAportes(5);

        // Agregando empleados manualmente
        registro.AgregarEmpleado(1, "LEILA", "Secretaria", 200);
        registro.AgregarEmpleado(2, "MAGNO", "Contador", 300);
        registro.AgregarEmpleado(3, "VALESKA", "Directora", 400);

        // Mostrar todos los empleados
        registro.MostrarEmpleados();

        // Buscar empleado por ID
        Console.WriteLine("\nBuscar empleado con ID 2:");
        registro.BuscarEmpleado(2);

        // Mostrar total de aportes
        Console.WriteLine($"\nTotal aportado: {registro.TotalAportes():C}");

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
