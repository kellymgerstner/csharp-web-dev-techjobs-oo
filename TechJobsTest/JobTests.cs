using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }

        [TestMethod]
        public void TestConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType position = new PositionType("Quality Control");
            CoreCompetency competency = new CoreCompetency("Persistence");
            Job job3 = new Job("Product Tester", employer, location, position, competency);
            
            Assert.AreEqual(job3.Name, "Product Tester"); 
            Assert.AreEqual(job3.EmployerName.Value, employer.Value); 
            Assert.AreEqual(job3.EmployerLocation.Value, location.Value);
            Assert.AreEqual(job3.JobType.Value, position.Value);
            Assert.AreEqual(job3.JobCoreCompetency.Value, competency.Value);
        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            TechJobsOO.Job job1 = new TechJobsOO.Job();
            TechJobsOO.Job job2 = new TechJobsOO.Job();

            Assert.AreNotEqual(job1.Id, job2.Id);

        }


        /*
        [TestMethod]
        public void TestJobToStringMethod()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType position = new PositionType("Quality Control");
            CoreCompetency competency = new CoreCompetency("Persistence");
            Job job3 = new Job("Product Tester", employer, location, position, competency);
            Job job4 = new Job("Product Tester", employer, location, position, null);
            
            Assert.AreEqual(job3.ToString(), "\n ID: " + job3.Id + "\n Name: " + job3.Name + "\n Employer: " + job3.EmployerName.Value + "\n Location: " + job3.EmployerLocation.Value + "\n Position Type: " + job3.JobType.Value + "\n Core Competency: " + job3.JobCoreCompetency.Value + "\n");
            Assert.AreEqual(job3.ToString(), "\n ID: " + job3.Id + "\n Name: " + job3.Name + "\n Employer: " + job3.EmployerName.Value + "\n Location: " + job3.EmployerLocation.Value + "\n Position Type: " + job3.JobType.Value + "\n Core Competency: Data not available \n");
        }
        */
    }
}