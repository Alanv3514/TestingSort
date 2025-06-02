using System;

namespace TestingSort.utils
{
    public class MergeSort
    {
        // int[]
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] leftArray = new int[mid - left + 1];
            int[] rightArray = new int[right - mid];

            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);

            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
                arr[k++] = (leftArray[i] <= rightArray[j]) ? leftArray[i++] : rightArray[j++];
            while (i < leftArray.Length) arr[k++] = leftArray[i++];
            while (j < rightArray.Length) arr[k++] = rightArray[j++];
        }

        // double[]
        public static void Sort(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(double[] arr, int left, int mid, int right)
        {
            double[] leftArray = new double[mid - left + 1];
            double[] rightArray = new double[right - mid];

            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);

            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
                arr[k++] = (leftArray[i] <= rightArray[j]) ? leftArray[i++] : rightArray[j++];
            while (i < leftArray.Length) arr[k++] = leftArray[i++];
            while (j < rightArray.Length) arr[k++] = rightArray[j++];
        }

        // string[]
        public static void Sort(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(string[] arr, int left, int mid, int right)
        {
            string[] leftArray = new string[mid - left + 1];
            string[] rightArray = new string[right - mid];

            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);

            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
                arr[k++] = (string.Compare(leftArray[i], rightArray[j]) <= 0) ? leftArray[i++] : rightArray[j++];
            while (i < leftArray.Length) arr[k++] = leftArray[i++];
            while (j < rightArray.Length) arr[k++] = rightArray[j++];
        }
    }
}
