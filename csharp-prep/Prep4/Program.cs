using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true) {
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            if (num == 0) {
                break;
            } 
            else {
                numbers.Add(num);
            }
        }

        double sum = 0;
        int max = 0;

        foreach (int number in numbers) {
            sum += number;

            if (number > max) {
                max = number;
            }
        }
        double average = sum / numbers.Count;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
    }
}