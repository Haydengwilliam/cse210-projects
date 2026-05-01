using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        int newNumber = 1;
        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            newNumber = int.Parse(input);
            userNumbers.Add(newNumber);
        }
        userNumbers.Remove(0);
        int userSum = userNumbers.Sum();
        double userAvg = userNumbers.Average();
        int userLarge = userNumbers.Max();
        Console.WriteLine($"Sum: {userSum}\nAverage: {userAvg}\nLargest number: {userLarge}");
    }
}