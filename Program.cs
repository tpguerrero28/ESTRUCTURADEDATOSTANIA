using System;

namespace FigurasGeometricas
{
    // Clase que representa un Círculo
    public class Circulo
    {
        // Campo privado que almacena el radio del círculo
        private double radio;

        // Constructor que inicializa el radio del círculo
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método que calcula el área del círculo
        public double CalcularArea()
        {
            // Fórmula: Área = π * radio^2
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método que calcula el perímetro (circunferencia) del círculo
        public double CalcularPerimetro()
        {
            // Fórmula: Perímetro = 2 * π * radio
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un Cuadrado
    public class Cuadrado
    {
        // Campo privado que almacena la longitud del lado del cuadrado
        private double lado;

        // Constructor que inicializa el lado del cuadrado
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Método que calcula el área del cuadrado
        public double CalcularArea()
        {
            // Fórmula: Área = lado * lado
            return lado * lado;
        }

        // Método que calcula el perímetro del cuadrado
        public double CalcularPerimetro()
        {
            // Fórmula: Perímetro = 4 * lado
            return 4 * lado;
        }
    }

    // Clase principal que contiene el método Main
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Circulo con un radio de 5
            Circulo circulo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine($"Área: {circulo.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro():F2}");

            // Crear una instancia de la clase Cuadrado con un lado de 4
            Cuadrado cuadrado = new Cuadrado(4);
            Console.WriteLine("\nCuadrado:");
            Console.WriteLine($"Área: {cuadrado.CalcularArea():F2}");
            Console.WriteLine($"Perímetro: {cuadrado.CalcularPerimetro():F2}");
        }
    }
}
