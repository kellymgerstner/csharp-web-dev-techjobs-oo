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

        Job test_job1;
        Job test_job2;
        Employer test_employer;
        Location test_location;
        PositionType test_positionType;
        CoreCompetency coreCompetency;
        Job test_job3;
        [TestInitialize]
        public void CreateTestJobs()
        {
            TechJobsOO.Job test_job1 = new TechJobsOO.Job();
            TechJobsOO.Job test_job2 = new TechJobsOO.Job();
            TechJobsOO.Employer test_employer = new TechJobsOO.Employer("ACME");
            TechJobsOO.Location test_location = new TechJobsOO.Location("Desert");
            TechJobsOO.PositionType test_positionType = new TechJobsOO.PositionType("Quality Control");
            TechJobsOO.CoreCompetency coreCompetency = new TechJobsOO.CoreCompetency("Persistence");
            TechJobsOO.Job test_job3 = new TechJobsOO.Job("Product Tester", test_employer, test_location, test_positionType, coreCompetency);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            TechJobsOO.Job test_job1 = new TechJobsOO.Job();
            TechJobsOO.Job test_job2 = new TechJobsOO.Job();
            Assert.IsTrue(test_job2.Id == test_job1.Id + 1);
        }




        /*Employer test_employer;
        [TestInitialize]
        public void CreateTestEmployer()
        {
            TechJobsOO.Employer test_employer = new TechJobsOO.Employer("ACME");
        }

        Location test_location;
        [TestInitialize]
        public void CreateTestLocation()
        {
            TechJobsOO.Location test_location = new TechJobsOO.Location("Desert");
        }

        PositionType test_positionType;
        [TestInitialize]
        public void CreateTestPositionType()
        {
            TechJobsOO.PositionType test_positionType = new TechJobsOO.PositionType("Quality Control");
        }

        CoreCompetency coreCompetency;
        [TestInitialize]
        public void CreateTestCoreCompetency()
        {
            TechJobsOO.CoreCompetency coreCompetency = new TechJobsOO.CoreCompetency("Persistence");
        }

        Job test_job3;
        [TestInitialize]
        public void CreateTestJobWithParameters()
        {
            TechJobsOO.Job test_job3 = new TechJobsOO.Job("Product Tester", test_employer, test_location, test_positionType, coreCompetency);
        }*/
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(test_job3.Name, "Product Tester");
            Assert.AreEqual(test_job3.EmployerName, test_employer);
            //Assert.AreEqual(test_job3.EmployerLocation, "Location");
        }


        [TestMethod]
        public void TestJobsForQuality()
        {
            TechJobsOO.Job test_job1 =new TechJobsOO.Job();
            TechJobsOO.Job test_job2 = new TechJobsOO.Job();

            Assert.AreNotEqual(test_job1.Id, test_job2.Id);

        }



    }
}
