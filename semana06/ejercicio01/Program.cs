using System;

namespace ListaInvertida
{
    class Nodo
    {
        public int Valor;
        public Nodo Siguiente;

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    class ListaEnlazada
    {
        private Nodo cabeza;

        public void InsertarAlFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        public void Invertir()
        {
            Nodo anterior = null;
            Nodo actual = cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }
            cabeza = anterior;
        }

        public void Mostrar()
        {
            Nodo actual = cabeza;
            Console.Write("Lista: ");
            while (actual != null)
            {
                Console.Write(actual.Valor + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main()
        {
            ListaEnlazada lista = new ListaEnlazada();
            lista.InsertarAlFinal(10);
            lista.InsertarAlFinal(20);
            lista.InsertarAlFinal(30);
            lista.InsertarAlFinal(40);
            Console.WriteLine("Lista original:");
            lista.Mostrar();

            lista.Invertir();
            Console.WriteLine("Lista invertida:");
            lista.Mostrar();
        }
    }
}
