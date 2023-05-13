public class PromptGenerator
{
    public string Generate(int choice)
    {
        List<string> Quotes = new List<string> 
        { "What was the most impactful thing that happened to you today?",
        "If you could improve on thing about yourself... What would it be? (Be kind).",
        "How did you see the hand of God in your life today?",
        "How did you bless someone else today?",
        "What action meant the most to you today?"};

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