﻿using System;


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
            string jobId = "\nID: " + this.Id;
            string jobName = "\nName: " + this.Name;
            string employerName = "\nEmployer Name: " + this.EmployerName.Value;
            string jobLocation = "\nLocation: " + this.EmployerLocation.Value;
            string jobType = "\nPosition Type: " + this.JobType.Value;
            string jobCoreCompetency = "\nCore Competency: " + this.JobCoreCompetency.Value;

            if (jobName == "" || jobName == null)
            {
                return "Data Not Available";
            }

            if (employerName == "" || employerName == null)
            {
                return "Data Not Available";
            }

            if (jobLocation == "" || jobLocation == null)
            {
                return "Data Not Available";
            }

            if (jobType == "" || jobType == null)
            {
                return "Data Not Available";
            }

            if (jobCoreCompetency == "" || jobCoreCompetency == null)
            {
                return "Data Not Available";
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
