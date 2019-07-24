using BubbleSortProgram;
using System;
using System.Diagnostics;
using System.Linq;
using UtitlityStuff;

namespace BubbleSort
{
    class BubbleSortProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUBBLE SORT");
            int[] arr;
            Utility.InitializeArray(out arr);

            //This can be enabled for degugging purposes
            //Console.WriteLine("Input array:");
            //Console.WriteLine();
            //WriteArrayToConsole(arr);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //call the sorting algorithm
            Console.WriteLine("Calling the sorting algorithm....");
            BubbleSort(arr);
            Console.WriteLine("Sorting completed.");
            stopWatch.Stop();

            //This can be enabled for degugging purposes
            //Console.WriteLine("Sorted Values:");
            //Console.WriteLine();
            //WriteArrayToConsole(arr);

            Utility.WritePerformance(stopWatch.Elapsed, stopWatch.ElapsedTicks);

            Console.Write("Enter any key to close ....");
            Console.ReadKey();
        }


        /************** the actual algorithm **************************/
        private static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Utility.Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }
    }

}
