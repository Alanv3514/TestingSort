namespace TestingSort.utils
{
    public static class QuickSortRecursivo
    {
        public static void ArrayInt(int[] arr, int izq, int der)
        {
            if (izq < der)
            {
                int pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                {
                    if (arr[j] < pivote)
                    {
                        i++;
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;

                ArrayInt(arr, izq, pos - 1);
                ArrayInt(arr, pos + 1, der);
            }
        }

        public static void ArrayDouble(double[] arr, int izq, int der)
        {
            if (izq < der)
            {
                double pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                {
                    if (arr[j] < pivote)
                    {
                        i++;
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;

                ArrayDouble(arr, izq, pos - 1);
                ArrayDouble(arr, pos + 1, der);
            }
        }

        public static void ArrayString(string[] arr, int izq, int der)
        {
            if (izq < der)
            {
                string pivote = arr[der];
                int i = izq - 1;
                for (int j = izq; j < der; j++)
                {
                    if (string.Compare(arr[j], pivote) < 0)
                    {
                        i++;
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
                (arr[i + 1], arr[der]) = (arr[der], arr[i + 1]);
                int pos = i + 1;

                ArrayString(arr, izq, pos - 1);
                ArrayString(arr, pos + 1, der);
            }
        }
    }
}
