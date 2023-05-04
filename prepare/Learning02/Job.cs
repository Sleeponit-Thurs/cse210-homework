public class Job
{
    string _company;
    string _jobTitle;
    string _startYear;
    string _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}->{_endYear}");
    }
}