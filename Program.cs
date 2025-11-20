using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : double.NaN,
            _ => double.NaN
        };

        Console.WriteLine($"Result: {result}");
    }
}
