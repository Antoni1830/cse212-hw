﻿using System;
using System.Collections.Generic;

public static class DisplaySums
{
    public static void Run()
    {
        DisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        // Output: pairs that sum to 10

        Console.WriteLine("------------");

        DisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]);
        // Output: pairs that sum to 10

        Console.WriteLine("------------");

        DisplaySumPairs([5, 11, 2, -4, 6, 8, -1]);
        // Output: pairs that sum to 10
    }

    /// <summary>
    /// Display pairs of numbers (no duplicates should be displayed) that sum to
    /// 10 using a set in O(n) time. We are assuming that there are no duplicates
    /// in the list.
    /// </summary>
    private static void DisplaySumPairs(int[] numbers)
    {
        var seen = new HashSet<int>();

        foreach (int number in numbers)
        {
            int complement = 10 - number;

            if (seen.Contains(complement))
            {
                Console.WriteLine($"{number} {complement}");
            }

            // Always add the current number AFTER checking to avoid self-matches
            seen.Add(number);
        }
    }
}