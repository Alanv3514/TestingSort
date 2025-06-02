using TestingSort.utils;

namespace TestingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 25, 32, 7, 23, 6, 3 };
            double[] arrayDouble = { 25.5, 32.1, 7.8, 23.3, 6.9, 3.2 };
            string[] arrayString = { "banana", "apple", "cherry", "date" };

            Console.WriteLine("Array original:");
            Console.WriteLine(string.Join(" ", arrayInt));

            SelectionSort.ArrayInt(arrayInt);
            Console.WriteLine("Array ordenado:");
            Console.WriteLine(string.Join(" ", arrayInt));

            SelectionSort.ArrayDouble(arrayDouble);
            Console.WriteLine("Array ordenado:");
            Console.WriteLine(string.Join(" ", arrayDouble));

            SelectionSort.ArrayString(arrayString);
            Console.WriteLine("Array ordenado:");
            Console.WriteLine(string.Join(" ", arrayString));
        }
    }
}
