﻿using System;
using System.Collections.Generic;

public static class DisplaySumsSolution
{
    public static void Run()
    {
        DisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        // Expected pairs:
        // 6 4
        // 7 3
        // 8 2
        // 9 1

        Console.WriteLine("------------");

        DisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]);
        // Expected pairs:
        // 10 0
        // 15 -5
        // 20 -10

        Console.WriteLine("------------");

        DisplaySumPairs([5, 11, 2, -4, 6, 8, -1]);
        // Expected pairs:
        // 8 2
        // -1 11
    }

    /// <summary>
    /// Display pairs of numbers that sum to 10 using a HashSet for O(n) time.
    /// Assumes no duplicates in the input list.
    /// </summary>
    private static void DisplaySumPairs(int[] numbers)
    {
        var seen = new HashSet<int>();

        foreach (var num in numbers)
        {
            int complement = 10 - num;
            if (seen.Contains(complement))
            {
                Console.WriteLine($"{num} {complement}");
            }
            seen.Add(num);
        }
    }
}