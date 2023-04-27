using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobName = "Sales Associate";
        job1._jobCompany = "Tokyo Nissan";
        job1._jobLocation = "Tokyo Japan";
        job1._jobStart = 2017;
        job1._jobEnd = 2019;

        Job job2 = new Job();
        job2._jobName = "Marketing Intern";
        job2._jobCompany = "Google";
        job2._jobLocation = "Tokyo Japan";
        job2._jobStart = 2019;
        job2._jobEnd = 2020;

        Resume myresume = new Resume();
        myresume._name = "Eren Yager";

        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();
    }
}