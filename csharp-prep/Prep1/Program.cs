using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("What is your Last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {firstName}, {lastName}.");
    }
}