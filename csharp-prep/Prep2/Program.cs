using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage grade did you get? ");
        string valueInText = Console.ReadLine();
        int gradePercent = int.Parse(valueInText);
        char gradeLetter;
        if (gradePercent >= 90) {
            gradeLetter = 'A';
            Console.WriteLine($"You got an {gradeLetter}.");
        }
        else if (gradePercent < 90 && gradePercent >= 80) {
            gradeLetter = 'B';
            Console.WriteLine($"You got a {gradeLetter}.");
        }
        else if (gradePercent < 80 && gradePercent >= 70) {
            gradeLetter = 'C';
            Console.WriteLine($"You got a {gradeLetter}.");
        }
        else if (gradePercent < 70 && gradePercent >= 60) {
            gradeLetter = 'D';
            Console.WriteLine($"You got a {gradeLetter}.");
        }
        else if (gradePercent < 60) {
            gradeLetter = 'F';
            Console.WriteLine($"You got an {gradeLetter}.");
        }
        else {
            Console.WriteLine("Unsure");
        }
        if (gradePercent >= 70) {
            Console.WriteLine("Congratulations, you have passed.");
        }
        else {
            Console.WriteLine("Unfortunately, you did not pass. Maybe next time.");
        }
    }
}