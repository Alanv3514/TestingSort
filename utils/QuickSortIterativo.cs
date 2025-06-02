using System;

namespace TestingSort.utils
{
    public static class QuickSortIterativo
    {
        public static void Sort(int[] arr) => SortInt(arr);
        public static void Sort(long[] arr) => SortLong(arr);
        public static void Sort(float[] arr) => SortFloat(arr);
        public static void Sort(double[] arr) => SortDouble(arr);
        public static void Sort(decimal[] arr) => SortDecimal(arr);
        public static void Sort(string[] arr) => SortString(arr);

        private static void SortInt(int[] arr)
        {
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int top = -1;
            left[++top] = 0;
            right[top] = arr.Length - 1;

            while (top >= 0)
            {
                int l = left[top];
                int r = right[top--];
                if (l >= r) continue;
                int pivot = arr[r];
                int i = l - 1;
                for (int j = l; j < r; j++)
                    if (arr[j] < pivot)
                        (arr[++i], arr[j]) = (arr[j], arr[i]);
                (arr[i + 1], arr[r]) = (arr[r], arr[i + 1]);
                int p = i + 1;
                left[++top] = l; right[top] = p - 1;
                left[++top] = p + 1; right[top] = r;
            }
        }

        private static void SortLong(long[] arr)
        {
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int top = -1;
            left[++top] = 0;
            right[top] = arr.Length - 1;

            while (top >= 0)
            {
                int l = left[top];
                int r = right[top--];
                if (l >= r) continue;
                long pivot = arr[r];
                int i = l - 1;
                for (int j = l; j < r; j++)
                    if (arr[j] < pivot)
                        (arr[++i], arr[j]) = (arr[j], arr[i]);
                (arr[i + 1], arr[r]) = (arr[r], arr[i + 1]);
                int p = i + 1;
                left[++top] = l; right[top] = p - 1;
                left[++top] = p + 1; right[top] = r;
            }
        }

        private static void SortFloat(float[] arr)
        {
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int top = -1;
            left[++top] = 0;
            right[top] = arr.Length - 1;

            while (top >= 0)
            {
                int l = left[top];
                int r = right[top--];
                if (l >= r) continue;
                float pivot = arr[r];
                int i = l - 1;
                for (int j = l; j < r; j++)
                    if (arr[j] < pivot)
                        (arr[++i], arr[j]) = (arr[j], arr[i]);
                (arr[i + 1], arr[r]) = (arr[r], arr[i + 1]);
                int p = i + 1;
                left[++top] = l; right[top] = p - 1;
                left[++top] = p + 1; right[top] = r;
            }
        }

        private static void SortDouble(double[] arr)
        {
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int top = -1;
            left[++top] = 0;
            right[top] = arr.Length - 1;

            while (top >= 0)
            {
                int l = left[top];
                int r = right[top--];
                if (l >= r) continue;
                double pivot = arr[r];
                int i = l - 1;
                for (int j = l; j < r; j++)
                    if (arr[j] < pivot)
                        (arr[++i], arr[j]) = (arr[j], arr[i]);
                (arr[i + 1], arr[r]) = (arr[r], arr[i + 1]);
                int p = i + 1;
                left[++top] = l; right[top] = p - 1;
                left[++top] = p + 1; right[top] = r;
            }
        }

        private static void SortDecimal(decimal[] arr)
        {
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int top = -1;
            left[++top] = 0;
            right[top] = arr.Length - 1;

            while (top >= 0)
            {
                int l = left[top];
                int r = right[top--];
                if (l >= r) continue;
                decimal pivot = arr[r];
                int i = l - 1;
                for (int j = l; j < r; j++)
                    if (arr[j] < pivot)
                        (arr[++i], arr[j]) = (arr[j], arr[i]);
                (arr[i + 1], arr[r]) = (arr[r], arr[i + 1]);
                int p = i + 1;
                left[++top] = l; right[top] = p - 1;
                left[++top] = p + 1; right[top] = r;
            }
        }

        private static void SortString(string[] arr)
        {
            int[] left = new int[arr.Length];
            int[] right = new int[arr.Length];
            int top = -1;
            left[++top] = 0;
            right[top] = arr.Length - 1;

            while (top >= 0)
            {
                int l = left[top];
                int r = right[top--];
                if (l >= r) continue;
                string pivot = arr[r];
                int i = l - 1;
                for (int j = l; j < r; j++)
                    if (string.Compare(arr[j], pivot) < 0)
                        (arr[++i], arr[j]) = (arr[j], arr[i]);
                (arr[i + 1], arr[r]) = (arr[r], arr[i + 1]);
                int p = i + 1;
                left[++top] = l; right[top] = p - 1;
                left[++top] = p + 1; right[top] = r;
            }
        }
    }
}
