public class PromptGenerator
{
    public string Generate(int choice)
    {
        List<string> Quotes = new List<string> { "You can do it","Epic","Great","Awesome","Nice"};

        if (choice == 1)
        {
            Random random = new Random();
            int index = random.Next(0, 5);
            Console.WriteLine("Here is some inspiration for your entry!");
            return Quotes[index];
        }
        else
        {
            return null;
        }
    }
}