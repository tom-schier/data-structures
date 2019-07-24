using System;
using System.Diagnostics;
using UtitlityStuff;

namespace HeapSort
{
    class HeapSortProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEAP SORT");
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
            HeapSort(arr);
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

        private static void HeapSort(int[] arr)
        {
            Console.Write("Not implemented yet ....");
        }
    }
}

