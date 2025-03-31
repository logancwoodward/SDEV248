using System;

class AveragingProgram
{
    static void Main()
    {
        double total = 0;
        int count = 3;

        for (int i = 1; i <= count; i++)
        {
            Console.Write($"Enter number {i}: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                total += number;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
                i--; // Retry the same iteration
            }
        }

        double average = total / count;
        Console.WriteLine($"The average is: {average}");
    }
}