using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUICK SORT");
            int[] arr = {
                    1, 5, 4, 11, 20, 8, 2, 98, 90, 16
                };

            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted Values:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        private static int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

    }
}
