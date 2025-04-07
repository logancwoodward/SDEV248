using System;
using System.Collections.Generic;

class SortExamScores
{
    static void Main()
    {
        // Store the exam scores
        List<int> examScores = new List<int> { 40, 80, 50, 75, 60, 55 };

        // Sort the scores
        examScores.Sort();

        Console.WriteLine("Sorted Exam Scores (Lowest to Highest):");
        foreach (int score in examScores)
        {
            Console.WriteLine(score);
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}