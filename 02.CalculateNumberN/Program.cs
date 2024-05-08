using System;

Console.WriteLine("Enter a positive integer N:");
int N;
if (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
{
    Console.WriteLine("Invalid input. Please enter a positive integer.");
    return;
}

int sum = 0;
for (int i = 1; i <= N; i++)
{
    sum += i;
}

Console.WriteLine($"The sum of all numbers from 1 to {N} is: {sum}");
