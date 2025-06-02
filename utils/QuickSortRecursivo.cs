namespace TestingSort.utils
{
    public static class QuickSortRecursivo
    {
        public static void Sort(int[] arr, int izq, int der)
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

                Sort(arr, izq, pos - 1);
                Sort(arr, pos + 1, der);
            }
        }

        public static void Sort(double[] arr, int izq, int der)
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

                Sort(arr, izq, pos - 1);
                Sort(arr, pos + 1, der);
            }
        }

        public static void Sort(string[] arr, int izq, int der)
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

                Sort(arr, izq, pos - 1);
                Sort(arr, pos + 1, der);
            }
        }
    }
}
