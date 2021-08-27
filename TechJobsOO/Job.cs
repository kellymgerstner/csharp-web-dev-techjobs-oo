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

        // TODO: Add the two necessary constructors.
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



        //TODO: Code ToString() method
        public override string ToString()
        {
            Job job = new Job();
            string blankLine = "\n";
            string jobId = "ID: " + this.Id + "\n";
            string jobName = "Name: " + this.Name + "\n";
            string employerName = "Employer Name: " + this.EmployerName.Value + "\n";
            string jobLocation = "Location: " + this.EmployerLocation.Value + "\n";
            string jobType = "Position Type: " + this.JobType.Value + "\n";
            string jobCoreCompetency = "Core Competency: " + this.JobCoreCompetency.Value + "\n";

            return blankLine + jobId + jobName + employerName + jobLocation + jobType + jobCoreCompetency;

                   
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
