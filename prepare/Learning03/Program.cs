using System;
using System.Data.Common;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Fraction b = new Fraction(7);
        Fraction c = new Fraction(2, 3);
        Fraction d = new Fraction(8, 9);
        string aString = a.GetFractionString();
        double aDecimal = a.GetDecimalValue();
        string bString = b.GetFractionString();
        double bDecimal = b.GetDecimalValue();
        string cString = c.GetFractionString();
        double cDecimal = c.GetDecimalValue();
        string dString = d.GetFractionString();
        double dDecimal = d.GetDecimalValue();
        Console.WriteLine($"{aString}\n{aDecimal}\n{bString}\n{bDecimal}\n{cString}\n{cDecimal}\n{dString}\n{dDecimal}");
        Fraction randFraction = new Fraction();
        Random random = new Random();
        for (int i = 1; i < 21; i++)
        {
            randFraction.SetTop(random.Next(0,13));
            randFraction.SetBottom(random.Next(0,13));
            Console.WriteLine($"Fraction {i}: string: {randFraction.GetFractionString()} Number: {randFraction.GetDecimalValue()}");
        }
    }
}