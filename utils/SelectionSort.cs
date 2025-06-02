namespace TestingSort.utils
{
    public static class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
        }

        public static void Sort(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
        }

        public static void Sort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(arr[j], arr[min]) < 0)
                        min = j;
                }
                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
        }
    }
}
