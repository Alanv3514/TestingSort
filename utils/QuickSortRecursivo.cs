using System;

namespace TestingSort.utils
{
    public static class QuickSortRecursivo
    {
        public static void Sort(int[] arr, int izq, int der) => SortInt(arr, izq, der);
        public static void Sort(long[] arr, int izq, int der) => SortLong(arr, izq, der);
        public static void Sort(float[] arr, int izq, int der) => SortFloat(arr, izq, der);
        public static void Sort(double[] arr, int izq, int der) => SortDouble(arr, izq, der);
        public static void Sort(decimal[] arr, int izq, int der) => SortDecimal(arr, izq, der);
        public static void Sort(string[] arr, int izq, int der) => SortString(arr, izq, der);

        private static void SortInt(int[] arr, int izq, int der)
        {
            if (izq < der)
            {
                int pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                    if (arr[j] < pivote)
                    {
                        i++;
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;
                SortInt(arr, izq, pos - 1);
                SortInt(arr, pos + 1, der);
            }
        }

        private static void SortLong(long[] arr, int izq, int der)
        {
            if (izq < der)
            {
                long pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                    if (arr[j] < pivote)
                    {
                        i++;
                        long temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;
                SortLong(arr, izq, pos - 1);
                SortLong(arr, pos + 1, der);
            }
        }

        private static void SortFloat(float[] arr, int izq, int der)
        {
            if (izq < der)
            {
                float pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                    if (arr[j] < pivote)
                    {
                        i++;
                        float temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;
                SortFloat(arr, izq, pos - 1);
                SortFloat(arr, pos + 1, der);
            }
        }

        private static void SortDouble(double[] arr, int izq, int der)
        {
            if (izq < der)
            {
                double pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                    if (arr[j] < pivote)
                    {
                        i++;
                        double temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;
                SortDouble(arr, izq, pos - 1);
                SortDouble(arr, pos + 1, der);
            }
        }

        private static void SortDecimal(decimal[] arr, int izq, int der)
        {
            if (izq < der)
            {
                decimal pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                    if (arr[j] < pivote)
                    {
                        i++;
                        decimal temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;
                SortDecimal(arr, izq, pos - 1);
                SortDecimal(arr, pos + 1, der);
            }
        }

        private static void SortString(string[] arr, int izq, int der)
        {
            if (izq < der)
            {
                string pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                    if (string.Compare(arr[j], pivote) < 0)
                    {
                        i++;
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;
                SortString(arr, izq, pos - 1);
                SortString(arr, pos + 1, der);
            }
        }
    }
}
