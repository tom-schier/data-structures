using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUBBLE SORT");
            int[] arr = {
                    1, 5, 4, 11, 20, 8, 2, 98, 90, 16
                };
            BubbleSort(arr);
            Console.WriteLine("Sorted Values:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

        }

        private static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }

}
