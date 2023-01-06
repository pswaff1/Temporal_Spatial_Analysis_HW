/*
 * Temporal_Analysis.cs
 * 
 * This is a program designed to explore the concept of Temporal Analysis. The program generates three arrays of arbitrary length,
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

class Temporal
{
    // Generates an array of random unsorted integers
    // @param size - the size of the array to generate
    // @return an array of random unsorted integers
    public static int[] GenerateArray(int size)
    {
        // Ends the program if the size is not a valid size
        if (size < 0)
        {
            Environment.Exit(0);
        }

        // Create a new instance of the Random class
        Random random = new Random();

        // Create an array of the specified size
        int[] array = new int[size];

        // Fill the array with random integers
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next();
        }

        // Return the array
        return array;
    }

    public static void BubbleSort(int[] array)
    {
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }

    public static void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int value = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > value)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = value;
        }
    }

    public static long measure_ticks(int[] array, string sort_type)
    {
        long start_time = DateTime.Now.Ticks;

        // Sort the array
        if (sort_type == "Bubblesort")
        {
            BubbleSort(array);
        }
        else if (sort_type == "Insertionsort")
        {
            InsertionSort(array);
        }
        else if (sort_type == "Quicksort")
        {
            Array.Sort(array);
        }
        else
        {
            return -1;
        }

        long end_time = DateTime.Now.Ticks;

        return end_time - start_time;
    }

    
}


