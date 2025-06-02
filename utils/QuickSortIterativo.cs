namespace TestingSort.utils
{
    public static class QuickSortIterativo
    {
        public static void Sort(int[] arr)
        {
            int[] izquierda = new int[arr.Length];
            int[] derecha = new int[arr.Length];
            int tope = -1;

            izquierda[++tope] = 0;
            derecha[tope] = arr.Length - 1;

            while (tope >= 0)
            {
                int izq = izquierda[tope];
                int der = derecha[tope--];

                if (izq >= der) continue;

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

                izquierda[++tope] = izq;
                derecha[tope] = pos - 1;

                izquierda[++tope] = pos + 1;
                derecha[tope] = der;
            }
        }

        public static void Sort(double[] arr)
        {
            int[] izquierda = new int[arr.Length];
            int[] derecha = new int[arr.Length];
            int tope = -1;

            izquierda[++tope] = 0;
            derecha[tope] = arr.Length - 1;

            while (tope >= 0)
            {
                int izq = izquierda[tope];
                int der = derecha[tope--];

                if (izq >= der) continue;

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

                izquierda[++tope] = izq;
                derecha[tope] = pos - 1;

                izquierda[++tope] = pos + 1;
                derecha[tope] = der;
            }
        }

        public static void Sort(string[] arr)
        {
            int[] izquierda = new int[arr.Length];
            int[] derecha = new int[arr.Length];
            int tope = -1;

            izquierda[++tope] = 0;
            derecha[tope] = arr.Length - 1;

            while (tope >= 0)
            {
                int izq = izquierda[tope];
                int der = derecha[tope--];

                if (izq >= der) continue;

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

                izquierda[++tope] = izq;
                derecha[tope] = pos - 1;

                izquierda[++tope] = pos + 1;
                derecha[tope] = der;
            }
        }
    }
}
