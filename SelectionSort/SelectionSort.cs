using System;
using System.Diagnostics;
using System.Linq;
using UtitlityStuff;

namespace SelectionSort
{
    class SelectionSortProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SELECTION SORT");
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
            SelectionSort(arr);
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


        private static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var tmp = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }


    }
}
