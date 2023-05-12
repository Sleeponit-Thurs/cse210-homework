public class Entry
{
    public string _quote;
    public string _entry;
    public string _date;

    public List<Entry> entries = new List<Entry>();
    public string Record()
    {
        Console.WriteLine("What would you like to name the Journal File? (Do not include the extension)");
        string name = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter($"{name}.txt", true))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry);
            }
            return name;
        }
    }

}