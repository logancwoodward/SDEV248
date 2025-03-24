using System;

class WeightClass
{
    static void Main()
    {
        Console.Write("Enter the weight of the boxer in pounds: ");
        if (double.TryParse(Console.ReadLine(), out double weight))
        {
            string classification = GetWeightClass(weight);
            Console.WriteLine($"The boxer is classified as: {classification}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }

    static string GetWeightClass(double weight)
    {
        if (weight > 190) return "Heavyweight";
        if (weight > 175) return "Cruiserweight";
        if (weight > 168) return "Light Heavyweight";
        if (weight > 160) return "Super Middleweight";
        if (weight > 154) return "Middleweight";
        if (weight > 147) return "Junior Middleweight";
        if (weight > 140) return "Welterweight";
        return "Junior Welterweight";
    }
}
