using System;

class Program
{
    static void Main(string[] args)
    {
        Address allAddress = new Address("123 Name St.", "Real Town", "ID", "US");
        Lecture newLecture = new Lecture("John Doe", 56, "How to go insane writing C# code", "Placeholder Text", "1-2-23", "12:00", allAddress);
        Reception newReception = new Reception("jdoe@email.com", "Big Event Reception", "This is a reception", "3-2-21", "6:00", allAddress);
        Outdoor newOutdoor = new Outdoor("Painfully Hot", "Outdoor Event", "This event will be outside, unfortunately", "4-5-26", "8:00", allAddress);

        Console.WriteLine($"{newLecture.GetStandard()}\n{newLecture.GetShortDescription()}\n{newLecture.GetFull()}\n{newReception.GetStandard()}\n{newReception.GetShortDescription()}\n{newReception.GetFull()}\n{newOutdoor.GetStandard()}\n{newOutdoor.GetShortDescription()}\n{newOutdoor.GetFull()}");
    }
}