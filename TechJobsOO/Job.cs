using System;
using System.Collections.Generic;
using System.Reflection;

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
            nextId++;
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
            if(Name == "" && EmployerName.ToString() == "" && EmployerLocation.ToString() == "" && JobType.ToString() == "" && JobCoreCompetency.ToString() == "")
            {
                return "OOPS! This job does not seem to exist\n";
            }
            
            

            return $"ID: __{Id}__\nName: __{(Name == "" ? "Data not available" : Name)}__\nEmployer: __{(EmployerName.ToString() == "" ? "Data not available" : EmployerName.ToString())}__\nLocation: __{(EmployerLocation.ToString() == "" ? "Data not available" : EmployerLocation.ToString())}__\nPosition: __{(JobType.ToString() == "" ? "Data not available" : JobType.ToString())}__\nCore Competency: __{(JobCoreCompetency.ToString() == "" ? "Data not available" : JobCoreCompetency.ToString())}__\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }
        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
