using System;

Console.WriteLine("Welcome to the Console Calculator App!");

while (true)
{
    Console.WriteLine("\nPlease select an operation:");
    Console.WriteLine("1. Addition (+)");
    Console.WriteLine("2. Subtraction (-)");
    Console.WriteLine("3. Multiplication (*)");
    Console.WriteLine("4. Division (/)");
    Console.WriteLine("5. Exit");

    Console.Write("Enter your choice (1-5): ");
    int choice;
    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        continue;
    }

    if (choice == 5)
    {
        Console.WriteLine("Exiting the program...");
        break;
    }

    Console.Write("Enter the first number: ");
    double num1;
    if (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Invalid number format. Please enter a valid number.");
        continue;
    }

    Console.Write("Enter the second number: ");
    double num2;
    if (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Invalid number format. Please enter a valid number.");
        continue;
    }

    double result = 0;
    string operation = "";

    switch (choice)
    {
        case 1:
            result = num1 + num2;
            operation = "+";
            break;
        case 2:
            result = num1 - num2;
            operation = "-";
            break;
        case 3:
            result = num1 * num2;
            operation = "*";
            break;
        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                continue;
            }
            result = num1 / num2;
            operation = "/";
            break;
    }

    Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
}
