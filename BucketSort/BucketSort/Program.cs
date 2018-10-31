﻿using System;
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
            for (int i = 0; i < buckets.Length; i++) { // initialize all of the lists
                buckets[i] = new List<int>();
            }

            double max = arr.Max();
            int divider = Math.Ceiling((max + 1.0)/buckets.Length);

            for (int j = 0; j < arr.Length; j++) {
                int index = Math.Floor(arr[j]/divider);
                buckets[index].Add(arr[j]);
            }
        }

        static void Main(string[] args)
        {
            //Beginning of the user input section, takes the user input into an array while trimming extra space of the end
            Console.WriteLine("Please enter numbers seperated by spaces: ");
            string input = Console.ReadLine().Trim();
            string[] numbers = input.Split(' ');

            int num = 0;
            int[] arr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++) {
                bool ret = int.TryParse(numbers[i].Trim(), out num);
                if (!ret) { //Isn't a number, unable to parse it, so then it just skips it
                    Console.WriteLine("Can not parse: " + numbers[i] + " Skipping...");
                    continue;
                }
                arr[i] = num;
            }

            Console.Write("Unsorted: ");
            printArray(arr); // Prints out the unsorted array
            
            bucketSort(ref arr); //Sorts the array using a bucket sort 
            Console.Write("Sorted: ");
            printArray(arr); // Prints out sorted array
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
