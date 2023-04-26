using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        int guess = 0;
        string guessConvert = "";
        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicnumber = randomGenerator.Next(1, 100);
            Console.Write("Try to guess the magic number! ");
            do
            {
               guessConvert = Console.ReadLine();
               guess = int.Parse(guessConvert);
               if (guess > magicnumber)
               {
                Console.WriteLine("Lower");
               }
               else if (guess < magicnumber)
               {
                Console.WriteLine("Higher");
               }
            } while (guess != magicnumber);
            Console.Write("Would you like to play again? yes/no ");
            playAgain = Console.ReadLine();
                if (playAgain == "yes")
                {
                    Console.WriteLine("Perfect! Let's go again!");
                }
                else if (playAgain== "no")
                {
                    Console.WriteLine("Thanks for playing!");
                }
        }
       
    }
}