using System;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Nodo<int> nodoInicial = new Nodo<int>();

            nodoInicial.Valor = random.Next(0, 100);
            Console.Write(nodoInicial.Valor + "  ");

            Nodo<int> nodoActual = new Nodo<int>();
            nodoActual = nodoInicial;

            for (int i = 0; i < 9; i++)
            {
                Nodo<int> nuevo = new Nodo<int>(random.Next(0, 100));

                Console.Write(nuevo.Valor + "  ");

                nodoActual.Siguiente = nuevo;

                nodoActual = nuevo;
            }
            Console.WriteLine();

            int sumatoria = 0;
            nodoActual = nodoInicial;


            while (nodoActual.Siguiente != null)
            {
                sumatoria += Convert.ToInt32(nodoActual.Valor);
                nodoActual = nodoActual.Siguiente;
            }

            Console.WriteLine($"La sumatoria es {sumatoria}");
            Console.Read();
        }
    }
}
