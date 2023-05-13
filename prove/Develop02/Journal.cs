public class Journal
{
    public List<string> _entries = new List<string>();

    public void Record()
    {
        Console.WriteLine("What would you like to name the Journal File? (Do not include the extension)");
        string name = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter($"{name}.txt", true))
        {
            foreach (string entry in _entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void ReadEntry()
    {
        Console.WriteLine("What is the name of the Journal File? (Do not include the extension)");
        string name = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{name}.txt");

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}