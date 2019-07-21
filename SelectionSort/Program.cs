using System;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        public const string DataToProcess = "0,6,6,9,3,2,4,56,23,24,12";
        static void Main(string[] args)
        {
            Console.WriteLine("SELECTION SORT");
            Console.WriteLine("Reading data into List..." + DataToProcess);
            var intArray = DataToProcess.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            //var finished = false;
            for(int i = 0; i < intArray.Length; i++)
            {
                var tmp = intArray[i];
                for(int j = i+1; j < intArray.Length; j++)
                {
                    if (intArray[j] < intArray[i])
                    {
                        intArray[i] = intArray[j];
                        intArray[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Sorted array is" + DataToProcess);
            PrintArray(intArray);
        }


        public static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
