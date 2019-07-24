using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UtitlityStuff;

namespace MergeSort
{
    class MergSortProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MERGE SORT");
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
            MergeSort(arr, 0, arr.Length - 1);
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


        private static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        private static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }

    }
}
