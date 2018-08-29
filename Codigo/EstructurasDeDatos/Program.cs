using System;

namespace EstructurasDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Nodo nodoInicial = new Nodo();
            nodoInicial.Valor = random.Next(0, 100) + "";
            Console.Write(nodoInicial.Valor + "  ");

            Nodo nodoActual = new Nodo();
            nodoActual = nodoInicial;

            for (int i = 0; i < 9; i++)
            {
                Nodo nuevo = new Nodo(random.Next(0, 100) + "");

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
