using System;
using System.Threading;

namespace Demo_02_Vector_Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de datos:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int[] aleatorios = new int[cantidad];

            Random random = new Random();
            for (int i = 0; i < aleatorios.Length; i++)
            {
                aleatorios[i] = random.Next(1, 100);
            }
            Imprimir(aleatorios);
            
            Burbuja(aleatorios);

            Imprimir(aleatorios);

            Console.Read();
        }

        private static void Burbuja(int[] aleatorios)
        {
            int temporal;
            for (int i = 0; i < aleatorios.Length; i++)
            {
                for (int j = 0; j < aleatorios.Length - 1; j++)
                {
                    if (aleatorios[j] > aleatorios[j + 1])
                    {
                        temporal = aleatorios[j];
                        aleatorios[j] = aleatorios[j + 1];
                        aleatorios[j + 1] = temporal;
                    }
                    Imprimir(aleatorios);
                }
            }
        }

        private static void Imprimir(int[] aleatorios)
        {
            Console.WriteLine();
            for (int i = 0; i < aleatorios.Length; i++)
            {
                Console.Write(aleatorios[i] + "-");
            }
            Thread.Sleep(1000);
        }
    }
}
