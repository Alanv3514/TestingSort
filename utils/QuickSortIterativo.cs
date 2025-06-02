namespace TestingSort.utils
{
    public static class QuickSortIterativo
    {
        public static void ArrayInt(int[] arr)
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
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                int tempPivot = arr[i + 1];
                arr[i + 1] = arr[der];
                arr[der] = tempPivot;
                int pos = i + 1;

                izquierda[++tope] = izq;
                derecha[tope] = pos - 1;

                izquierda[++tope] = pos + 1;
                derecha[tope] = der;
            }
        }

        public static void ArrayDouble(double[] arr)
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
                        double temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                double tempPivot = arr[i + 1];
                arr[i + 1] = arr[der];
                arr[der] = tempPivot;
                int pos = i + 1;

                izquierda[++tope] = izq;
                derecha[tope] = pos - 1;

                izquierda[++tope] = pos + 1;
                derecha[tope] = der;
            }
        }

        public static void ArrayString(string[] arr)
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
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                string tempPivot = arr[i + 1];
                arr[i + 1] = arr[der];
                arr[der] = tempPivot;
                int pos = i + 1;

                izquierda[++tope] = izq;
                derecha[tope] = pos - 1;

                izquierda[++tope] = pos + 1;
                derecha[tope] = der;
            }
        }
    }
}
