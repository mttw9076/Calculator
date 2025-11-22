using System;

class Program
{
    static void Main()
    {
        while(true)
        {
        Console.WriteLine("Type 'exit' to quit or press Enter to continue.");
        string? input = Console.ReadLine();
        if (input == null)
            {
                 Console.WriteLine("Brak danych wejściowych!");
                    return;
        }
        if(input.ToLower() == "exit")
            break;
        
        Console.WriteLine("Simple Calculator");
        Console.Write("Enter first number: ");
         if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Nieprawidłowa liczba!");
                continue;
            }

        Console.Write("Enter operator (+, -, *, /): ");
        string? op = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(op))
            {
                Console.WriteLine("Brak operatora!");
                continue;
            }

        Console.Write("Enter second number: ");
          if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Nieprawidłowa liczba!");
                continue;
            }

        double result = op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : double.NaN,
            _ => double.NaN
        };
        if(double.IsNaN(result))
        {
            Console.WriteLine("Nie można dzielić przez zero lub nieprawidłowy operator.");
        }
        else    
        Console.WriteLine($"Result: {result}");

        }


        

    }
}
