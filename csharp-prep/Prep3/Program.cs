using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 101);

        while (true) {
            Console.WriteLine("What is your guess?");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);

            if (guess == number) {
                Console.WriteLine("You got it!");
                break;
            }
            else if (guess > number) {
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("Higher");
            }
        }
    }
}