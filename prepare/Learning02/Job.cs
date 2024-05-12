using System;
using System.Data; // for System.Data

public class Job
{
    // attributes of a job (like jobtitle, company, start year, and end year)
    // responbilities
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // behaviors
    // ex. Software Engineer (Microsoft) 2019-2022
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}