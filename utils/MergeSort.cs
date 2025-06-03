using System;

namespace TestingSort.utils
{
    public class MergeSort
    {
        public static void Sort(int[] arr, int left, int right) => SortInt(arr, left, right);
        public static void Sort(long[] arr, int left, int right) => SortLong(arr, left, right);
        public static void Sort(float[] arr, int left, int right) => SortFloat(arr, left, right);
        public static void Sort(double[] arr, int left, int right) => SortDouble(arr, left, right);
        public static void Sort(decimal[] arr, int left, int right) => SortDecimal(arr, left, right);
        public static void Sort(string[] arr, int left, int right) => SortString(arr, left, right);

        private static void SortInt(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                SortInt(arr, left, mid);
                SortInt(arr, mid + 1, right);
                MergeInt(arr, left, mid, right);
            }
        }

        private static void MergeInt(int[] arr, int left, int mid, int right)
        {
            int[] leftArray = new int[mid - left + 1];
            int[] rightArray = new int[right - mid];
            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);
            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < leftArray.Length) 
                arr[k++] = leftArray[i++];
            while (j < rightArray.Length)
                arr[k++] = rightArray[j++];
        }

        private static void SortLong(long[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                SortLong(arr, left, mid);
                SortLong(arr, mid + 1, right);
                MergeLong(arr, left, mid, right);
            }
        }

        private static void MergeLong(long[] arr, int left, int mid, int right)
        {
            long[] leftArray = new long[mid - left + 1];
            long[] rightArray = new long[right - mid];
            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);
            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArray.Length) arr[k++] = leftArray[i++];
            while (j < rightArray.Length) arr[k++] = rightArray[j++];
        }

        private static void SortFloat(float[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                SortFloat(arr, left, mid);
                SortFloat(arr, mid + 1, right);
                MergeFloat(arr, left, mid, right);
            }
        }

        private static void MergeFloat(float[] arr, int left, int mid, int right)
        {
            float[] leftArray = new float[mid - left + 1];
            float[] rightArray = new float[right - mid];
            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);
            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArray.Length) 
                arr[k++] = leftArray[i++];
            while (j < rightArray.Length) 
                arr[k++] = rightArray[j++];
        }

        private static void SortDouble(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                SortDouble(arr, left, mid);
                SortDouble(arr, mid + 1, right);
                MergeDouble(arr, left, mid, right);
            }
        }

        private static void MergeDouble(double[] arr, int left, int mid, int right)
        {
            double[] leftArray = new double[mid - left + 1];
            double[] rightArray = new double[right - mid];
            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);
            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArray.Length) 
                arr[k++] = leftArray[i++];
            while (j < rightArray.Length) 
                arr[k++] = rightArray[j++];
        }

        private static void SortDecimal(decimal[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                SortDecimal(arr, left, mid);
                SortDecimal(arr, mid + 1, right);
                MergeDecimal(arr, left, mid, right);
            }
        }

        private static void MergeDecimal(decimal[] arr, int left, int mid, int right)
        {
            decimal[] leftArray = new decimal[mid - left + 1];
            decimal[] rightArray = new decimal[right - mid];
            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);
            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < leftArray.Length) 
                arr[k++] = leftArray[i++];
            while (j < rightArray.Length) 
                arr[k++] = rightArray[j++];
        }

        private static void SortString(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                SortString(arr, left, mid);
                SortString(arr, mid + 1, right);
                MergeString(arr, left, mid, right);
            }
        }

        private static void MergeString(string[] arr, int left, int mid, int right)
        {
            string[] leftArray = new string[mid - left + 1];
            string[] rightArray = new string[right - mid];
            Array.Copy(arr, left, leftArray, 0, leftArray.Length);
            Array.Copy(arr, mid + 1, rightArray, 0, rightArray.Length);
            int i = 0, j = 0, k = left;
            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (string.Compare(leftArray[i], rightArray[j]) <= 0)
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < leftArray.Length) 
                arr[k++] = leftArray[i++];
            while (j < rightArray.Length) 
                arr[k++] = rightArray[j++];
        }
    }
}
