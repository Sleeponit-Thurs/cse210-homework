using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float numberAdd = 1;
        Console.WriteLine("Enter a list of numbers. Type zero to stop.");
        while (numberAdd != 0)
        {
            //Accepts input until 0 is given
            Console.Write("Enter a number: ");
            string numberConvert = Console.ReadLine();
            numberAdd = float.Parse(numberConvert);
            numbers.Append(numberAdd);
        }
        float numbersSum = numbers.AsQueryable().Sum();
    }
}