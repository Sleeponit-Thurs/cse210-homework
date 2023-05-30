public class Scripture
{   Random random = new Random();
    public int _index;
    public string _reference;
    public string _fullText;
    public List<Word> _words = new List<Word>();


    public Scripture()
    {
        _index = random.Next(0);
    }
    public void DisplayScripture()
    {
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            if (word._hidden == false)
            {
                Console.Write(word._word);
                Console.Write(" ");
            }
            else
            {
                int letterCount = word._word.Length;
                int underscoreCount = 0;
                while (underscoreCount != letterCount)
                {
                    Console.Write("_");
                    underscoreCount += 1;
                }
                Console.Write(" ");

            }
        }
    }
}