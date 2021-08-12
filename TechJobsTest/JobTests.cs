using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10);
        }

        
        [TestMethod]
        public void TestSettingJobId()
        {
            TechJobsOO.Job test_job1 = new TechJobsOO.Job();
            TechJobsOO.Job test_job2 = new TechJobsOO.Job();

            Assert.IsFalse(test_job1 == test_job2);        
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            TechJobsOO.Employer test_employer= new TechJobsOO.Employer("ACME");
            TechJobsOO.Location test_location = new TechJobsOO.Location("Desert");
            TechJobsOO.PositionType test_positionType = new TechJobsOO.PositionType("Quality Control");
            TechJobsOO.CoreCompetency test_coreCompetency = new TechJobsOO.CoreCompetency("Persistence");
            
            TechJobsOO.Job test_job = new TechJobsOO.Job("Product Tester", test_employer, test_location, test_positionType, test_coreCompetency);
            
            Assert.AreEqual("Product Tester", test_job.Name);
            //Assert.AreEqual("ACME", test_job.EmployerName);
            //Assert.AreEqual("Desert", test_job.EmployerLocation);
            //Assert.AreEqual("QualityControl", test_job.JobType);
            //Assert.AreEqual("Persistence", test_job.JobCoreCompetency);

        }



    }
}
