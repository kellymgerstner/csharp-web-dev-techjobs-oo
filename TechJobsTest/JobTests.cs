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
            TechJobsOO.Job test_job = new TechJobsOO.Job("Product Tester", "ACME", "Desert", "QualityControl", "Persistence");

        }



    }
}
