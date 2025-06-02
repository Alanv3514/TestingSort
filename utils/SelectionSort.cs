namespace TestingSort.utils
{
    public static class SelectionSort
    {
        public static void ArrayInt(int[] arr)
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
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        public static void ArrayDouble(double[] arr)
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
                double temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        public static void ArrayString(string[] arr)
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
                string temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
