using System;

class Program
{
    static void Main(string[] args)
    {
        int birthYear;
        DisplayMessage();
        string username = promptUserName();
        int favNumber = PromptUserNumber();
        PromptUserBirthYear(out birthYear);
        int squaredNumber = SquareNumber(favNumber);
        DisplayResult(username, squaredNumber, birthYear);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string promptUserName()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int inputNumber)
    {
        int squaredNumber = inputNumber * inputNumber;
        return squaredNumber;
    }

    static void DisplayResult(string username, int squaredNumber, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        Console.WriteLine($"{username}, the square of your number is {squaredNumber}.\n{username}, you will turn/have turned {currentYear-birthYear} this year.");
    }
}