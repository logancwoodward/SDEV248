using System;
using System.Collections.Generic;

class ExamScoresStoring
{
    static void Main()
    {
        // Store the exam scores
        List<int> examScores = new List<int> { 40, 80, 50, 75, 60, 55 };

        Console.WriteLine("Exam Scores:");
        foreach (int score in examScores)
        {
            Console.WriteLine(score);
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}