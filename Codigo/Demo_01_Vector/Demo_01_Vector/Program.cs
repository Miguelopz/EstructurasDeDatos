using System;

namespace Demo_01_Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes:");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            //Inicialización
            double[] notasFinales = new double[cantidad];
            //llenado del arreglo
            for (int i = 0; i < notasFinales.Length; i++)
            {
                Console.Write($"Ingrese la nota para estudiante {i + 1}:");
                string dato = Console.ReadLine();
                double valor = Convert.ToDouble(dato);
                notasFinales[i] = valor;
            }
            double sumatoria = 0;
            double promedio = 0;
            //Lectura del arreglo
            for (int i = 0; i < notasFinales.Length; i++)
            {
                sumatoria += notasFinales[i];
            }
            promedio = sumatoria / notasFinales.Length;

            Console.WriteLine($"El promedio del curso es {promedio}");Estruc

            Console.Read();
        }
    }
}
