namespace QuickSortConsoleApp
{
    class QuickSortClass
    {
        static void Main(string[] args)
        {
            // Example array
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Quick Sort Algorithm");
            Console.WriteLine("Original array:");
            PrintArray(array);

            // Perform quick sort
            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array:");
            PrintArray(array);
        }

        // Sorts an array using the Quick Sort algorithm.
        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        // Partitions the array around a pivot element.

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
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
﻿
