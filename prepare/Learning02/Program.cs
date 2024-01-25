using System;

class Program
{
    static void Main(string[] args)
    {
        //Instantiate job1 under the Job class.
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        //Instantiate job2 under the Job class.
        Job job2 = new Job();
        job2._company = "Best Buy";
        job2._jobTitle = "Sales Cleark";
        job2._startYear = 2022;
        job2._endYear = 2023;

    

        //Instantiate myResume under the Resume class.
        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Call the DisplayResume method to display myResume.
        myResume.DisplayResume();


    }
}