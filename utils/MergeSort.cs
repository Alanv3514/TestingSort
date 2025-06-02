
namespace TestingSort.utils
{
    public class MergeSort
    {
        public static void arrayInt(int[] arr, int left, int mid, int right)
        {
            int[] leftArray = new int[mid - left + 1];
            int[] rightArray = new int[right - mid];

            Array.Copy(arr, left, leftArray, 0, mid - left + 1);
            Array.Copy(arr, mid + 1, rightArray, 0, right - mid);

            int i = 0, j = 0, k = left;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                arr[k++] = leftArray[i] <= rightArray[j] ? leftArray[i++] : rightArray[j++];
            }

            while (i < leftArray.Length)
            {
                arr[k++] = leftArray[i++];
            }

            while (j < rightArray.Length)
            {
                arr[k++] = rightArray[j++];
            }
        }

        public static void arrayString(string[] arr, int left, int mid, int right)
        {
            string[] leftArray = new string[mid - left + 1];
            string[] rightArray = new string[right - mid];

            Array.Copy(arr, left, leftArray, 0, mid - left + 1);
            Array.Copy(arr, mid + 1, rightArray, 0, right - mid);

            int i = 0, j = 0, k = left;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                arr[k++] = string.Compare(leftArray[i], rightArray[j]) <= 0 ? leftArray[i++] : rightArray[j++];
            }

            while (i < leftArray.Length)
            {
                arr[k++] = leftArray[i++];
            }

            while (j < rightArray.Length)
            {
                arr[k++] = rightArray[j++];
            }
        }

        public static void arrayDouble(double[] arr, int left, int mid, int right)
        {
            double[] leftArray = new double[mid - left + 1];
            double[] rightArray = new double[right - mid];

            Array.Copy(arr, left, leftArray, 0, mid - left + 1);
            Array.Copy(arr, mid + 1, rightArray, 0, right - mid);

            int i = 0, j = 0, k = left;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                arr[k++] = leftArray[i] <= rightArray[j] ? leftArray[i++] : rightArray[j++];
            }

            while (i < leftArray.Length)
            {
                arr[k++] = leftArray[i++];
            }

            while (j < rightArray.Length)
            {
                arr[k++] = rightArray[j++];
            }
        }
    }
}