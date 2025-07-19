﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n======================\nUnique Letters\n======================");
        UniqueLetters.Run();

        Console.WriteLine("\n======================\nDisplay Sums\n======================");
        DisplaySums.Run();

        Console.WriteLine("\n======================\nBasketball\n======================");
        Basketball.Run();

        // Solution versions for comparison
        Console.WriteLine("\n======================\nUnique Letters Solution\n======================");
        UniqueLettersSolution.Run();

        Console.WriteLine("\n======================\nDisplay Sums Solution\n======================");
        DisplaySumsSolution.Run();

        Console.WriteLine("\n======================\nBasketball Solution\n======================");
        BasketballSolution.Run();
    }
}