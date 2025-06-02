

namespace TestingSort.utils
{
    public static class BubbleSort
    {
        public static void Sort(int[] arr) { SortInt(arr); }
        public static void Sort(long[] arr) { SortLong(arr); }
        public static void Sort(float[] arr) { SortFloat(arr); }
        public static void Sort(double[] arr) { SortDouble(arr); }
        public static void Sort(decimal[] arr) { SortDecimal(arr); }
        public static void Sort(string[] arr) { SortString(arr); }

        private static void SortInt(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }

        private static void SortLong(long[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }

        private static void SortFloat(float[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }

        private static void SortDouble(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }

        private static void SortDecimal(decimal[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }

        private static void SortString(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
        }
    }

}
