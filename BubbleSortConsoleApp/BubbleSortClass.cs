namespace BubbleSortConsoleApp
{
    class BubbleSortClass
    {
        static void Main(string[] args)
        {
            // Example array
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Bubble Sort Algorithm");
            Console.WriteLine("Original array:");
            PrintArray(array);

            // Perform bubble sort
            BubbleSort(array);

            Console.WriteLine("Sorted array:");
            PrintArray(array);
        }

        // Sorts an array using the Bubble Sort algorithm.
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Track if any swaps were made during this pass
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    // If the element found is greater than the next element, swap them
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapped = true;
                    }
                }

                // If no elements were swapped, the array is already sorted
                if (!swapped)
                {
                    break;
                }
            }
        }

        // Swaps two elements in an array.

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Prints the elements of an array.
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
