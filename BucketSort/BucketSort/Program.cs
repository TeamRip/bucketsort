using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class Program
    {

        public static void bucketSort(ref int[] arr) 
        {
            List<int>[] buckets = new List<int>[arr.Length];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers seperated by spaces: ");
            string input = Console.ReadLine().Trim();
            string[] numbers = input.Split(' ');

            int[] arr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++) {
                int num;
                bool ret = int.TryParse(numbers[i].Trim(), out num);
                if (!ret) {
                    continue;
                }
                arr[i] = num;
            }
            Console.Write("unsorted: ");
            printArray(arr);
            
            bucketSort(ref arr);

            Console.WriteLine("sorted: ");
            printArray(arr);
        }

        // This is the function that will print the array. 
        public static void printArray(int[] x)
        {
            //runs through a for loop to see how long the array is, when it gets to the last variable it starts.
            for (int i = 0; i < x.Length; i++) 
            {
                //Writes the array
                Console.Write("[" + x[i] + "] ");
            }
            //puts a space after the array
            Console.WriteLine(" ");
        }
    }
}
