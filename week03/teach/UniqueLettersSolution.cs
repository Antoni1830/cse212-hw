﻿using System;
using System.Collections.Generic;

public static class UniqueLettersSolution
{
    public static void Run()
    {
        var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True - all unique
        Console.WriteLine(AreUniqueLetters(test1));
        Console.WriteLine(AreUniqueLettersAlternate(test1));

        var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False - 'a' repeated
        Console.WriteLine(AreUniqueLetters(test2));
        Console.WriteLine(AreUniqueLettersAlternate(test2));

        var test3 = ""; // Expect True - empty string has no duplicates
        Console.WriteLine(AreUniqueLetters(test3));
        Console.WriteLine(AreUniqueLettersAlternate(test3));
    }

    /// <summary>
    /// Uses a HashSet to track letters. Returns false on first duplicate.
    /// Time complexity: O(n)
    /// </summary>
    private static bool AreUniqueLetters(string text)
    {
        var found = new HashSet<char>();
        foreach (var letter in text)
        {
            if (found.Contains(letter))
                return false;
            found.Add(letter);
        }
        return true;
    }

    /// <summary>
    /// Alternative solution: build a HashSet from the string and compare sizes.
    /// Time complexity: O(n)
    /// </summary>
    private static bool AreUniqueLettersAlternate(string text)
    {
        var unique = new HashSet<char>(text);
        return unique.Count == text.Length;
    }
}