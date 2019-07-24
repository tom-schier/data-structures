using BubbleSortProgram;
using System;
using System.Diagnostics;
using System.Linq;

namespace BubbleSort
{
    class BubbleSortProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BUBBLE SORT");
            int[] arr;
            InitializeArray(out arr);

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

            WritePerformance(stopWatch.Elapsed, stopWatch.ElapsedTicks);

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
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }

        /*************Utility stuff ***********************/

        private static void InitializeArray(out int[] arr)
        {
            bool isInitialised = false;
            do
            {
                Console.WriteLine("Enter array size then ENTER: ");
                var st = Console.ReadLine();
                Console.WriteLine("Initialising array....");
                if (st.Length > 0)
                {
                    int cnt;
                    if (Int32.TryParse(st, out cnt) == true)
                    {

                        int Min = 0;
                        int Max = 100000;
                        Random randNum = new Random();
                        arr = Enumerable
                            .Repeat(0, cnt)
                            .Select(i => randNum.Next(Min, Max))
                            .ToArray();
                        isInitialised = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input argument");
                        Console.ReadKey();
                        arr = null;
                        continue;
                    };

                }
                else
                {
                    arr = new int[]{
                        1, 5, 4, 11, 20, 8, 2, 98, 90, 16
                    };
                    isInitialised = true;
                }
            } while (isInitialised == false);

        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private static void WriteArrayToConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString());
                if (i < arr.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine();              
        }

        private static void WritePerformance(TimeSpan ts, long elapsedTicks)
        {
            Console.WriteLine($"Total seconds: {ts.TotalSeconds}");
            Console.WriteLine($"Total milliseconds: {ts.TotalMilliseconds}");
            Console.WriteLine("ELAPSED TICKS " + elapsedTicks);
        }
    }

}
