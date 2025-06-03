using System;
using System.Diagnostics;
using TestingSort.utils;

namespace TestingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tamanios = { 100000, 500000, 1000000, 5000000 };
            //int[] tamanios = { 1000, 5000, 10000, 50000,100000 };
            int semilla = 123;

            foreach (int n in tamanios)
            {
                Console.WriteLine($"--- Prueba con {n} elementos ---");

                // TEST INT32
                int[] originalInt = GeneradorDatos.Enteros32(n, semilla);
                EjecutarOrdenamientosInt(originalInt);

                // TEST INT64
                long[] originalLong = GeneradorDatos.Enteros64(n, semilla);
                EjecutarOrdenamientosLong(originalLong);

                // TEST FLOAT32
                float[] originalFloat = GeneradorDatos.Reales32(n, semilla);
                EjecutarOrdenamientosFloat(originalFloat);

                // TEST FLOAT128 (decimal)
                decimal[] originalDecimal = GeneradorDatos.Reales128(n, semilla);
                EjecutarOrdenamientosDecimal(originalDecimal);

                // TEST STRING 8
                string[] originalStr8 = GeneradorDatos.Strings(n, 8, semilla);
                EjecutarOrdenamientosString(originalStr8);

                // TEST STRING 32
                string[] originalStr32 = GeneradorDatos.Strings(n, 32, semilla);
                EjecutarOrdenamientosString(originalStr32);

                Console.WriteLine();
            }

            Console.WriteLine("--- Características del sistema ---");
            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.WriteLine($"Procesadores: {Environment.ProcessorCount}");
            Console.WriteLine($"RAM estimada (MB): {GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / (1024 * 1024)}");

            Console.ReadKey();
        }

        static void EjecutarOrdenamientosInt(int[] original)
        {
            Console.WriteLine("\nTipo: Int32");
            //MedirTiempo("BubbleSort", () => BubbleSort.Sort((int[])original.Clone()));
            MedirTiempo("MergeSort", () => MergeSort.Sort((int[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Recursivo", () => QuickSortRecursivo.Sort((int[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Iterativo", () => QuickSortIterativo.Sort((int[])original.Clone()));
            //MedirTiempo("SelectionSort", () => SelectionSort.Sort((int[])original.Clone()));
        }

        static void EjecutarOrdenamientosLong(long[] original)
        {
            Console.WriteLine("\nTipo: Int64");
            //MedirTiempo("BubbleSort", () => BubbleSort.Sort((long[])original.Clone()));
            MedirTiempo("MergeSort", () => MergeSort.Sort((long[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Recursivo", () => QuickSortRecursivo.Sort((long[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Iterativo", () => QuickSortIterativo.Sort((long[])original.Clone()));
            //MedirTiempo("SelectionSort", () => SelectionSort.Sort((long[])original.Clone()));
        }

        static void EjecutarOrdenamientosFloat(float[] original)
        {
            Console.WriteLine("\nTipo: Float32");
            //MedirTiempo("BubbleSort", () => BubbleSort.Sort((float[])original.Clone()));
            MedirTiempo("MergeSort", () => MergeSort.Sort((float[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Recursivo", () => QuickSortRecursivo.Sort((float[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Iterativo", () => QuickSortIterativo.Sort((float[])original.Clone()));
            //MedirTiempo("SelectionSort", () => SelectionSort.Sort((float[])original.Clone()));
        }

        static void EjecutarOrdenamientosDecimal(decimal[] original)
        {
            Console.WriteLine("\nTipo: Decimal (Float128)");
            //MedirTiempo("BubbleSort", () => BubbleSort.Sort((decimal[])original.Clone()));
            MedirTiempo("MergeSort", () => MergeSort.Sort((decimal[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Recursivo", () => QuickSortRecursivo.Sort((decimal[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Iterativo", () => QuickSortIterativo.Sort((decimal[])original.Clone()));
            //MedirTiempo("SelectionSort", () => SelectionSort.Sort((decimal[])original.Clone()));
        }

        static void EjecutarOrdenamientosString(string[] original)
        {
            Console.WriteLine($"\nTipo: String ({original[0].Length} caracteres)");
            //MedirTiempo("BubbleSort", () => BubbleSort.Sort((string[])original.Clone()));
            MedirTiempo("MergeSort", () => MergeSort.Sort((string[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Recursivo", () => QuickSortRecursivo.Sort((string[])original.Clone(), 0, original.Length - 1));
            MedirTiempo("Quick Iterativo", () => QuickSortIterativo.Sort((string[])original.Clone()));
            //MedirTiempo("SelectionSort", () => SelectionSort.Sort((string[])original.Clone()));
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
