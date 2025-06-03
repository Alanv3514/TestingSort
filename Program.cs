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
            int[] tamanios = { 1000, 5000, 10000, 50000,100000 };
            int semilla = 123;



            foreach (int n in tamanios)
            {

                Console.WriteLine($"\nArray tamanio {n}");
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", "Tipo de Dato", "Método", "Tiempo (ms)"));
                Console.WriteLine(new string('-', 45));
                EjecutarYMostrar("Int32", n, () => GeneradorDatos.Enteros32(n, semilla));
                EjecutarYMostrar("Int64", n, () => GeneradorDatos.Enteros64(n, semilla));
                EjecutarYMostrar("Float32", n, () => GeneradorDatos.Reales32(n, semilla));
                EjecutarYMostrar("Decimal", n, () => GeneradorDatos.Reales128(n, semilla));
                EjecutarYMostrar("String8", n, () => GeneradorDatos.Strings(n, 8, semilla));
                EjecutarYMostrar("String32", n, () => GeneradorDatos.Strings(n, 32, semilla));
            }

            Console.WriteLine("\n--- Características del sistema ---");
            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.WriteLine($"Procesadores: {Environment.ProcessorCount}");
            Console.WriteLine($"RAM estimada (MB): {GC.GetGCMemoryInfo().TotalAvailableMemoryBytes / (1024 * 1024)}");
            Console.ReadKey();
        }

        static void EjecutarYMostrar(string tipo, int n, Func<object> generador)
        {
            object original = generador();

            if (tipo == "Int32")
            {
                int[] data = (int[])original;

                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "BubbleSort", MedirTiempo(() => BubbleSort.Sort((int[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "MergeSort", MedirTiempo(() => MergeSort.Sort((int[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Recursivo", MedirTiempo(() => QuickSortRecursivo.Sort((int[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Iterativo", MedirTiempo(() => QuickSortIterativo.Sort((int[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "SelectionSort", MedirTiempo(() => SelectionSort.Sort((int[])data.Clone()))));
            }
            else if (tipo == "Int64")
            {
                long[] data = (long[])original;
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "BubbleSort", MedirTiempo(() => BubbleSort.Sort((long[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "MergeSort", MedirTiempo(() => MergeSort.Sort((long[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Recursivo", MedirTiempo(() => QuickSortRecursivo.Sort((long[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Iterativo", MedirTiempo(() => QuickSortIterativo.Sort((long[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "SelectionSort", MedirTiempo(() => SelectionSort.Sort((long[])data.Clone()))));
            }
            else if (tipo == "Float32")
            {
                float[] data = (float[])original;
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "BubbleSort", MedirTiempo(() => BubbleSort.Sort((float[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "MergeSort", MedirTiempo(() => MergeSort.Sort((float[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Recursivo", MedirTiempo(() => QuickSortRecursivo.Sort((float[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Iterativo", MedirTiempo(() => QuickSortIterativo.Sort((float[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "SelectionSort", MedirTiempo(() => SelectionSort.Sort((float[])data.Clone()))));
            }
            else if (tipo == "Decimal")
            {
                decimal[] data = (decimal[])original;
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "BubbleSort", MedirTiempo(() => BubbleSort.Sort((decimal[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "MergeSort", MedirTiempo(() => MergeSort.Sort((decimal[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Recursivo", MedirTiempo(() => QuickSortRecursivo.Sort((decimal[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Iterativo", MedirTiempo(() => QuickSortIterativo.Sort((decimal[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "SelectionSort", MedirTiempo(() => SelectionSort.Sort((decimal[])data.Clone()))));
            }
            else
            {
                string[] data = (string[])original;
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "BubbleSort", MedirTiempo(() => BubbleSort.Sort((string[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "MergeSort", MedirTiempo(() => MergeSort.Sort((string[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Recursivo", MedirTiempo(() => QuickSortRecursivo.Sort((string[])data.Clone(), 0, n - 1))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "Quick Iterativo", MedirTiempo(() => QuickSortIterativo.Sort((string[])data.Clone()))));
                Console.WriteLine(string.Format("{0,-12} | {1,-18} | {2,10}", tipo, "SelectionSort", MedirTiempo(() => SelectionSort.Sort((string[])data.Clone()))));
            }
        }

        static long MedirTiempo(Action ordenamiento)
        {
            var inicio = DateTime.Now;
            ordenamiento();
            var fin = DateTime.Now;
            return (long)(fin - inicio).TotalMilliseconds;
        }
    }
}
