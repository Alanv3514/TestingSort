namespace TestingSort.utils
{
    public static class SelectionSort
    {
        public static void Sort(int[] arr) => SortInt(arr);
        public static void Sort(long[] arr) => SortLong(arr);
        public static void Sort(float[] arr) => SortFloat(arr);
        public static void Sort(double[] arr) => SortDouble(arr);
        public static void Sort(decimal[] arr) => SortDecimal(arr);
        public static void Sort(string[] arr) => SortString(arr);

        private static void SortInt(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;
                i++;
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        private static void SortLong(long[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;
                i++;
                long temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        private static void SortFloat(float[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;
                i++;
                float temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        private static void SortDouble(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;
                i++;
                double temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        private static void SortDecimal(decimal[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;
                i++;
                decimal temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        private static void SortString(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                    if (string.Compare(arr[j], arr[min]) < 0)
                        min = j;
                    
                i++;
                string temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
