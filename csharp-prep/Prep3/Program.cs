using System;
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int target = randomGenerator.Next(1,100);
        int guess = target + 1;
        while (guess != target)
        {
            Console.Write("What is your guess (1-100)? ");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess > target)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < target)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}