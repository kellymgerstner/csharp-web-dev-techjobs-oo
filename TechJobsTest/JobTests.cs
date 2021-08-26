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
            
            Assert.AreEqual(job3.Name, "Product Tester"); //passes
            Assert.AreEqual(job3.EmployerName, employer.Value); //fails
            Assert.AreEqual(job3.EmployerLocation, location.Value);//fails
            Assert.AreEqual(job3.JobType, position.Value);//fails
            Assert.AreEqual(job3.JobCoreCompetency, "Persistence");//fails
        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            TechJobsOO.Job test_job1 = new TechJobsOO.Job();
            TechJobsOO.Job test_job2 = new TechJobsOO.Job();

            Assert.AreNotEqual(test_job1.Id, test_job2.Id);

        }
    }
}