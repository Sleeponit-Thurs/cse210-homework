public class Reference 
{
    public List<string> _referenceText = new List<string> {"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
     " "};
    public List<string> _referenceReference = new List<string>{"1 Nephi 3:7",
    ""};

    public List<string> CompileReferenceWordList(string words)
    {
        List<string> individualWords = new List<string>(words.Split(' '));
        return individualWords;   
    }
}