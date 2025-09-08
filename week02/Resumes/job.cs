

using System;




    public class Job
    {
        public string _jobTitle;
        public string _jobCompany;
        public string _jobStartYear;
        public string _jobEndYear;


        public void DisplayJobInfo()
        {
            Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_jobStartYear}-{_jobEndYear}");

        }









    }
