using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
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
                string finishedEntry = entry1.FormatEntry(entry1._quote, entry1._date, entry1._entry );
                Journal journal = new Journal();
                journal._entries.Add(finishedEntry);
                journal.Record();
                
            }
            else if (choice == 2)
            {
                Journal journal = new Journal();
                journal.ReadEntry();
            }
            else if (choice == 3)
            {
                Environment.Exit(1);
            }
        }


        
    }
}