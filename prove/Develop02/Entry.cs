public class Entry
{
    public string _quote;
    public string _entry;
    public string _date;

    public string FormatEntry(string _quote, string _entry, string _date)
    {
        string formattedEntry  = ($"{_quote}\n{_entry}\n{_date}\n-");
        return formattedEntry;
    }

}