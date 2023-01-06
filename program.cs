class Program
{
    // The main function
    static void Main(string[] args)
    {
        long bubble_10000_ticks, bubble_50_ticks;
        long insertion_10000_ticks, insertion_50_ticks;
        long quick_10000_ticks, quick_50_ticks;

        int[] array;
        int n;



        Console.WriteLine("Bubblesort, InsertionSort, and QuickSort, n = 10,000");
        n = 10000;

        // Bubblesort n = 10000
        array = GenerateArray(n);
        bubble_10000_ticks = measure_ticks(array, "Bubblesort");
        Console.WriteLine("With n = 10,000, Bubblesort took " + bubble_10000_ticks + " ticks, or " + bubble_10000_ticks / 10 + " microseconds");

        // Insertionsort n = 10000
        array = GenerateArray(n);
        insertion_10000_ticks = measure_ticks(array, "Insertionsort");
        Console.WriteLine("WIth n = 10,000, Insertionsort took " + insertion_10000_ticks + " ticks, or " + insertion_10000_ticks / 10 + " microseconds");

        // Quicksort (via the built-in Array.Sort algorithm) n = 10000
        array = GenerateArray(n);
        quick_10000_ticks = measure_ticks(array, "Quicksort");
        Console.WriteLine("With n = 10,000, Quicksort took " + quick_10000_ticks + " ticks, or " + quick_10000_ticks / 10 + " microseconds");

        Console.WriteLine("\nBubblesort, InsertionSort, and QuickSort, n = 50");
        n = 50;

        // Bubblesort n = 50
        array = GenerateArray(n);
        bubble_50_ticks = measure_ticks(array, "Bubblesort");
        Console.WriteLine("With n = 50, Bubblesort took " + bubble_50_ticks + " ticks, or " + bubble_50_ticks / 10 + " microseconds");

        // Insertionsort n = 50
        array = GenerateArray(n);
        insertion_50_ticks = measure_ticks(array, "Insertionsort");
        Console.WriteLine("WIth n = 50, Insertionsort took " + insertion_50_ticks + " ticks, or " + insertion_50_ticks / 10 + " microseconds");

        // Quicksort (via the built-in Array.Sort algorithm) n = 50
        array = GenerateArray(n);
        quick_50_ticks = measure_ticks(array, "Quicksort");
        Console.WriteLine("With n = 50, Quicksort took " + quick_50_ticks + " ticks, or " + quick_50_ticks / 10 + " microseconds");

    }
}