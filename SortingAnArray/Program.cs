using System;
using System.Linq;

namespace SortingAnArray
{
    
    class Program
    {
        public const string DataToProcess = "0,1,2,0,0,1,1,2,1,0,2,2,2,2,1,2,0,1,1,2,2";
        static void Main(string[] args)
        {
            Console.WriteLine("INSERTION SORT");
            Console.WriteLine("Rading data into List..." + DataToProcess);
            var intArray = DataToProcess.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            for (int i = 0; i < intArray.Count(); i++)
            {
                /*storing current element whose left side is checked for its 
                         correct position .*/

                int temp = intArray[i];
                int j = i;

                
                // now check all the elements after the current (temp) element and swap if it is smaller
                // The first elemet in intArray therefore will change as you loop over the elements to
                // the right of the current (temp) eement
                while (j > 0 && temp < intArray[j - 1])
                {

                    // moving the left side element to one position forward.
                    intArray[j] = intArray[j - 1];
                    j = j - 1;

                }
                // moving current element to its  correct position.
                intArray[j] = temp;
            }

            foreach (var item in intArray)
            {
                Console.Write(item.ToString());
            }
        }
    }
}
