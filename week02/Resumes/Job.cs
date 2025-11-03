using System;

// Class Job
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        this._jobTitle = jobTitle;
        this._startYear = startYear;
        this._endYear = endYear;
        this._company = company;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }

}