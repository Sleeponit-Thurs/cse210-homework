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
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Sum()/numbers.Count()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest number is: {numbers.Min()}");
        numbers.Sort();
        foreach (float number in numbers)
        {
            Console.WriteLine(number);
        }
        

    }
}