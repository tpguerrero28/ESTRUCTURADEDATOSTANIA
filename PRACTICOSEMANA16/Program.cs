using System;
using System.Collections.Generic;

namespace VuelosBaratos
{
    public class Vuelo
    {
        public string Codigo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal Precio { get; set; }
        public string HoraSalida { get; set; }
        public string HoraLlegada { get; set; }

        public override string ToString()
        {
            return $"{Codigo}: {Origen} -> {Destino} | Precio: ${Precio} | Salida: {HoraSalida} | Llegada: {HoraLlegada}";
        }
    }

    public class Node
    {
        public Vuelo Vuelo { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(Vuelo vuelo)
        {
            Vuelo = vuelo;
        }
    }

    public class ArbolVuelos
    {
        public Node Root { get; set; }

        public void Insert(Vuelo vuelo)
        {
            Root = InsertRec(Root, vuelo);
        }

        private Node InsertRec(Node root, Vuelo vuelo)
        {
            if (root == null) return new Node(vuelo);

            if (vuelo.Precio < root.Vuelo.Precio)
                root.Left = InsertRec(root.Left, vuelo);
            else
                root.Right = InsertRec(root.Right, vuelo);

            return root;
        }

        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Console.WriteLine(root.Vuelo);
                InOrder(root.Right);
            }
        }

        public Vuelo BuscarVueloBarato(Node root, string origen, string destino, ref Vuelo mejor)
        {
            if (root == null) return mejor;

            if (root.Vuelo.Origen == origen && root.Vuelo.Destino == destino)
            {
                if (mejor == null || root.Vuelo.Precio < mejor.Precio)
                    mejor = root.Vuelo;
            }

            BuscarVueloBarato(root.Left, origen, destino, ref mejor);
            BuscarVueloBarato(root.Right, origen, destino, ref mejor);

            return mejor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArbolVuelos arbol = new ArbolVuelos();

            List<Vuelo> vuelos = new List<Vuelo>
            {
                new Vuelo { Codigo="V001", Origen="Quito", Destino="Guayaquil", Precio=120, HoraSalida="08:00", HoraLlegada="09:15" },
                new Vuelo { Codigo="V002", Origen="Quito", Destino="Colombia", Precio=250, HoraSalida="09:00", HoraLlegada="12:00" },
                new Vuelo { Codigo="V003", Origen="Quito", Destino="Panama", Precio=300, HoraSalida="10:00", HoraLlegada="14:00" },
                new Vuelo { Codigo="V004", Origen="Guayaquil", Destino="Galapagos", Precio=180, HoraSalida="07:00", HoraLlegada="09:00" },
                new Vuelo { Codigo="V005", Origen="Guayaquil", Destino="Quito", Precio=130, HoraSalida="11:00", HoraLlegada="12:15" },
                new Vuelo { Codigo="V006", Origen="Quito", Destino="Cuenca", Precio=90, HoraSalida="12:00", HoraLlegada="13:00" },
                new Vuelo { Codigo="V007", Origen="Esmeraldas", Destino="Guayaquil", Precio=150, HoraSalida="08:30", HoraLlegada="10:00" },
                new Vuelo { Codigo="V008", Origen="Guayaquil", Destino="Miami", Precio=450, HoraSalida="06:00", HoraLlegada="14:00" },
                new Vuelo { Codigo="V009", Origen="Guayaquil", Destino="Quito", Precio=125, HoraSalida="13:00", HoraLlegada="14:15" }
            };

            // Insertar vuelos en el árbol
            foreach (var vuelo in vuelos)
                arbol.Insert(vuelo);

            Console.WriteLine("📌 Todos los vuelos ordenados por precio:");
            arbol.InOrder(arbol.Root);

            Console.WriteLine("\n🔎 Buscando el vuelo más barato Quito -> Guayaquil...");
            Vuelo mejor = null;
            mejor = arbol.BuscarVueloBarato(arbol.Root, "Quito", "Guayaquil", ref mejor);

            if (mejor != null)
                Console.WriteLine($"✅ Vuelo más barato encontrado: {mejor}");
            else
                Console.WriteLine("❌ No se encontró un vuelo para ese destino.");

            Console.ReadKey();
        }
    }
}
