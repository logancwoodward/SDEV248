using System;

class MultiplyingProgram
{
    static float Multiply(float num1, float num2, float num3)
    {
        return num1 * num2 * num3;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        float num3 = float.Parse(Console.ReadLine());

        float result = Multiply(num1, num2, num3);
        Console.WriteLine($"The product is: {result}");
    }
}