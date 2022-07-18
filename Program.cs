using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7,9,11,13,14,15,16,20,30};
            int number = 130;
            int start = 0;
            int end = array.Length;
            int count = 0;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (number == array[mid])
                {
                    Console.WriteLine($"{number} is find at index: " + mid);
                    break;
                }
                else if (number < array[mid])
                {
                    end = mid - 1;
                }
                else if (number > array[mid])
                {
                    start = mid + 1;
                }
                if (end > start)
                {
                    count++;
                break;
                 }
                
                
            }
            if (count == 1)
            {
                Console.WriteLine("Number is not present");
            }

        }
    }
}
