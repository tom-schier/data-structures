using System;
using System.Linq;

namespace UtitlityStuff
{
    public static class Utility
    {
        public static void InitializeArray(out int[] arr)
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

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void WriteArrayToConsole(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString());
                if (i < arr.Length - 1)
                    Console.Write(",");
            }
            Console.WriteLine();
        }

        public static void WritePerformance(TimeSpan ts, long elapsedTicks)
        {
            Console.WriteLine($"Total seconds: {ts.TotalSeconds}");
            Console.WriteLine($"Total milliseconds: {ts.TotalMilliseconds}");
            Console.WriteLine("ELAPSED TICKS " + elapsedTicks);
        }
    }
}
