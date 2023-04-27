using System;

public class Job
{
    public string _jobName;
    public string _jobCompany;
    public string _jobLocation;
    public int _jobStart;
    public int _jobEnd;


    public void Display()
        {
            Console.WriteLine($"{_jobName}, {_jobCompany}, {_jobLocation}, {_jobStart} - {_jobEnd}.");
        }

}