using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture memorization program!");
        Console.WriteLine("Hit enter to continue or type quit to quit!");
        string userResponse = Console.ReadLine();
        userResponse = userResponse.ToLower();
        while (userResponse != "quit")
        {
            Scripture scripture1 = new Scripture();
            Reference reference1 = new Reference();
            scripture1._fullText = reference1._referenceText[scripture1._index];
            scripture1._reference = reference1._referenceReference[scripture1._index];
            List <string> wordEntryList = reference1.CompileReferenceWordList(scripture1._fullText);
            foreach (string wordEntry in wordEntryList)
            {
                Word word = new Word();
                word._word = wordEntry;
                scripture1._words.Add(word);
            }
            int hiddenNumberCount = 0;
            List<int> hideChoices = new List<int>();
            int hideChoice;
            do
            {
                Random random = new Random();
                do
                {
                    hideChoice = random.Next(0, scripture1._words.Count());
                } while (hideChoices.Contains(hideChoice));
                hideChoices.Add(hideChoice);
                scripture1.DisplayScripture();
                scripture1._words[hideChoice]._hidden = true;
                hiddenNumberCount += 1;
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
            } while (hiddenNumberCount != wordEntryList.Count());
            scripture1.DisplayScripture();
            Console.ReadLine();
            Console.WriteLine("Congrats on memorizing the scripture!");
            Console.WriteLine("Welcome to the Scripture memorization program!");
            Console.WriteLine("Hit enter to continue or type quit to quit!");
            userResponse = Console.ReadLine();
            userResponse = userResponse.ToLower();
        }
        if (userResponse == "quit")
        {
            Environment.Exit(1);
        }
        
    }
}