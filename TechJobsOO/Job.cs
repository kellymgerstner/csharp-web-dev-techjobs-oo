using System;


namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId ++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        public override string ToString()
        {
            string jobId = "\nID: " + this.Id;
            string jobName = "\nName: " + this.Name;
            string employerName = "\nEmployer Name: " + this.EmployerName.Value;
            string jobLocation = "\nLocation: " + this.EmployerLocation.Value;
            string jobType = "\nPosition Type: " + this.JobType.Value;
            string jobCoreCompetency = "\nCore Competency: " + this.JobCoreCompetency.Value;
            string dataNotAvailable = "Data not available";

            if (jobName == "" || jobName == null)
            {
                this.Name = dataNotAvailable;
            }

            if (employerName == "" || employerName == null)
            {
                this.EmployerName.Value = "Data not available";
            }

            if (jobLocation == "" || jobLocation == null)
            {
                this.EmployerLocation.Value = dataNotAvailable;
            }

            if (jobType == "" || jobType == null)
            {
                this.JobType.Value = dataNotAvailable;
            }

            if (jobCoreCompetency == "" || jobCoreCompetency == null)
            {
                this.JobCoreCompetency.Value = dataNotAvailable;
            }


            return jobId + jobName + employerName + jobLocation + jobType + jobCoreCompetency + "\n";

                   
        }


        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
