using System;
using System.Diagnostics;
using System.Linq;
using UtitlityStuff;

namespace SortingAnArray
{
    
    class InsertionSortProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INSERTION SORT");
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
            InsertionSort(arr);
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

        private static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                int temp = arr[i];
                int j = i;
                // now check all the elements after the current (temp) element and swap if it is smaller
                // The first elemet in intArray therefore will change as you loop over the elements to
                // the right of the current (temp) eement
                while (j > 0 && temp < arr[j - 1])
                {

                    // moving the left side element to one position forward.
                    arr[j] = arr[j - 1];
                    j = j - 1;

                }
                // moving current element to its  correct position.
                arr[j] = temp;
            }
        }
    }
}
