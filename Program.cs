using System;
using System.Diagnostics;
using TestingSort.utils;

namespace TestingSort
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //int[] tamanios = { 100000, 500000, 1000000, 5000000 };
            int[] tamanios = { 1000, 5000, 10000,50000 };
            int semilla = 123;

            foreach (int n in tamanios)
            {
                Console.WriteLine($"--- Prueba con {n} elementos ---");

                // TEST INT32
                int[] originalInt = GeneradorDatos.Enteros32(n, semilla);
                EjecutarOrdenamientosInt(originalInt);

                // TEST STRING 32
                string[] originalStr32 = GeneradorDatos.Strings(n, 32, semilla);
                EjecutarOrdenamientosString(originalStr32);

                Console.WriteLine();
            }

            Console.WriteLine("--- Características del sistema ---");
            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.WriteLine($"Procesadores: {Environment.ProcessorCount}");
            Console.WriteLine($"RAM estimada (MB): {GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / (1024 * 1024)}");

            Console.ReadKey(); // Mantener la consola abierta
        }

        static void EjecutarOrdenamientosInt(int[] original)
        {
            Console.WriteLine("Tipo: Int32");
            MedirTiempo("BubbleSort", () => BubbleSort.Sort((int[])original.Clone()));
            MedirTiempo("MergeSort", () => MergeSort.Sort((int[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Recursivo", () => QuickSortRecursivo.Sort((int[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Iterativo", () => QuickSortIterativo.Sort((int[])original.Clone()));
            MedirTiempo("SelectionSort", () => SelectionSort.Sort((int[])original.Clone()));
        }

        static void EjecutarOrdenamientosString(string[] original)
        {
            Console.WriteLine($"Tipo: String ({original[0].Length} caracteres)");
            MedirTiempo("BubbleSort", () => BubbleSort.Sort((string[])original.Clone()));
            MedirTiempo("MergeSort", () => MergeSort.Sort((string[])original.Clone(),0,original.Length-1));
            MedirTiempo("Quick Recursivo", () => QuickSortRecursivo.Sort((string[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Iterativo", () => QuickSortIterativo.Sort((string[])original.Clone()));
            MedirTiempo("SelectionSort", () => SelectionSort.Sort((string[])original.Clone()));
        }


        static void MedirTiempo(string metodo, Action ordenamiento)
        {
            var sw = Stopwatch.StartNew();
            ordenamiento();
            sw.Stop();
            Console.WriteLine($"{metodo}: {sw.ElapsedMilliseconds} ms");
        }
    }
}
