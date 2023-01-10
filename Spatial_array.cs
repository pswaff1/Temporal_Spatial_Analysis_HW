/*
 * Spatial_Analysis.cs
 * 
 * This is a program designed to explore the concept of Spatial Analysis. The program generates three arrays of arbitrary length,
 * then it sorts them with the bubble sort, insertion sort, and quicksort algorithms respectively. The program also keeps track of
 * the Ticks each algorithm takes to sort their arrays, thus giving us a general ballpark idea of the algorithm's processing time.
 * 
 * NCU.edu
 * School of Business & Technology Management
 * TIM-6110
 * 
 * Author: Patrick Swafford
 * Date: 05 January 2023
 * 
 */

using System;
using System.Data;

class Spatial_Analysis
{
    // A method to generate an integer array of arbitrary length where each element is in the range of 1 and 10,000

    public static int[] Generate_Array(int n)
    {
        // Exits the program if an invalid array size is entered
        if (n < 0)
        {
            Environment.Exit(-1);
        }

        // Create a new instance of the random class
        Random random = new Random();

        // Create an array of the specified size
        int[] arrary = new int[n];

        // Assign each element of the array with a random value between 1 and 10,000
        for (int i = 0; i < n; i++)
        {
            arrary[i] = random.Next() % 10000 + 1;
        }

        // Returns the newly populated array
        return arrary;
    }

    public static void Main(string[] args)
    {
        // Get the starting Ticks
        long startTime = DateTime.Now.Ticks;

        // Define array size and generate new random integer array of that size
        int n = 100000;
        int[] rand_array = Generate_Array(n);

        // Define an integer array of size n to hold the number of occurances of each element's value and initialize elements to 0
        int[] occurrance_count = new int [n+1];
        Array.Fill(occurrance_count, 0);

        // Populate both the occurrence count array and the top ten array
        foreach (int element in rand_array)
        {
            // Increment the occurrence count
            occurrance_count[element] += 1;
        }

        // Print the Algorithm information
        Console.WriteLine("Spatial and Temporal analysis of the integer array method of tracking occurences");
        // Print the header information
        Console.WriteLine("Number: Count");

        // Use LINQ to order the dictionary by value in descending order and take the top 10
        var topTenWithIndex = occurrance_count
            .Select((x, i) => Tuple.Create(i, x))
            .OrderByDescending(x => x.Item2)
            .Take(10)
            .ToList();

        // Print the Key-Value pairs
        foreach (var item in topTenWithIndex)
        {
            Console.WriteLine("{0, 6}:  {1}", item.Item1, item.Item2);
        }

        // Get the memory use
        long MemoryUseArray = System.GC.GetTotalMemory(false);

        // Get the run-time
        long endTime = DateTime.Now.Ticks;

        // Print out the results
        Console.WriteLine("This program used {0} Bytes of memory and took {1} Ticks of time", MemoryUseArray, endTime - startTime);
    }
}