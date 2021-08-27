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


        
        [TestMethod]
        public void TestJobToStringMethod()
        {
            Employer employer = new Employer("ACME");
            Employer emptyEmployer = new Employer("");
            Location location = new Location("Desert");
            Location emptyLocation = new Location("");
            PositionType position = new PositionType("Quality Control");
            PositionType emptyPosition = new PositionType("");
            CoreCompetency competency = new CoreCompetency("Persistence");
            CoreCompetency emptyCompetency = new CoreCompetency("");
          

            Job job3 = new Job("Product Tester", employer, location, position, competency);
            Job job4 = new Job("ProductTester", emptyEmployer, emptyLocation, emptyPosition, emptyCompetency);

            string test_print1 = "\nID: " + job3.Id + "\nName: " + job3.Name + "\nEmployer Name: " + job3.EmployerName.Value + "\nLocation: " + job3.EmployerLocation.Value + "\nPosition Type: " + job3.JobType.Value + "\nCore Competency: " + job3.JobCoreCompetency.Value + "\n";
            string test_print2 = "\nID: " + job4.Id + "\nName: " + job4.Name + "\nEmployer Name: " + job4.EmployerName.Value + "\nLocation: " + job4.EmployerLocation.Value + "\nPosition Type: " + job4.JobType.Value + "\nCore Competency: " + job4.JobCoreCompetency.Value + "\n";

            Assert.AreEqual(job3.ToString(), test_print1);
            Assert.AreEqual(job4.ToString(), test_print2);
        }
        
    }
}