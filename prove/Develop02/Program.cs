using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = menu.Display();
        string quote = promptGenerator.Generate(choice);
        Console.WriteLine(quote);

        if (choice == 1)
        {
            Entry entry1 = new Entry();
            entry1._quote = quote;
            entry1._date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            entry1._entry = Console.ReadLine();
            entry1.entries.Add(entry1);
            entry1.Record();
            

        }


        
    }
}