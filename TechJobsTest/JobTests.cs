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

            Assert.IsTrue(test_job2.Id == test_job1.Id + 1);
        }


        /*[TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            TechJobsOO.Job test_job = new TechJobsOO.Job();
            
            Assert.AreEqual(test_job.Name, "Product Tester");
            
        }*/


        [TestMethod]
        public void TestJobsForQuality()
        {
            TechJobsOO.Job test_job1 =new TechJobsOO.Job();
            TechJobsOO.Job test_job2 = new TechJobsOO.Job();

            Assert.AreNotEqual(test_job1.Id, test_job2.Id);

        }



    }
}
