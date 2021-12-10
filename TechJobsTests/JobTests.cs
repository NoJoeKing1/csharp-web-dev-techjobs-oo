using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsFalse(testJob1.Id == testJob2.Id);
            Assert.AreEqual(testJob2.Id - testJob1.Id, 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", testJob1.Name);
            Assert.AreEqual("ACME", testJob1.EmployerName.ToString());
            Assert.AreEqual("Desert", testJob1.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", testJob1.JobType.ToString());
            Assert.AreEqual("Persistence", testJob1.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreNotEqual(testJob2, testJob1);
        }

        [TestMethod]
        public void TestJobsToStringMethod()
        {
            Job testJob1 = new Job("Name", new Employer("Employer"), new Location("Location"), new PositionType("Position"), new CoreCompetency("Core competency"));
            Job testJob2 = new Job("", new Employer("Employer"), new Location("Location"), new PositionType("Position"), new CoreCompetency("Core competency"));
            Job testJob3 = new Job("Name", new Employer(""), new Location("Location"), new PositionType("Position"), new CoreCompetency("Core competency"));
            Job testJob4 = new Job("Name", new Employer("Employer"), new Location(""), new PositionType("Position"), new CoreCompetency("Core competency"));
            Job testJob5 = new Job("Name", new Employer("Employer"), new Location("Location"), new PositionType(""), new CoreCompetency("Core competency"));
            Job testJob6 = new Job("Name", new Employer("Employer"), new Location("Location"), new PositionType("Position"), new CoreCompetency(""));
            Job testJob7 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual("ID: __4__\nName: __Name__\nEmployer: __Employer__\nLocation: __Location__\nPosition: __Position__\nCore Competency: __Core competency__\n", testJob1.ToString());
            Assert.AreEqual("ID: __5__\nName: __Data not available__\nEmployer: __Employer__\nLocation: __Location__\nPosition: __Position__\nCore Competency: __Core competency__\n", testJob2.ToString());
            Assert.AreEqual("ID: __6__\nName: __Name__\nEmployer: __Data not available__\nLocation: __Location__\nPosition: __Position__\nCore Competency: __Core competency__\n", testJob3.ToString());
            Assert.AreEqual("ID: __7__\nName: __Name__\nEmployer: __Employer__\nLocation: __Data not available__\nPosition: __Position__\nCore Competency: __Core competency__\n", testJob4.ToString());
            Assert.AreEqual("ID: __8__\nName: __Name__\nEmployer: __Employer__\nLocation: __Location__\nPosition: __Data not available__\nCore Competency: __Core competency__\n", testJob5.ToString());
            Assert.AreEqual("ID: __9__\nName: __Name__\nEmployer: __Employer__\nLocation: __Location__\nPosition: __Position__\nCore Competency: __Data not available__\n", testJob6.ToString());
            Assert.AreEqual("OOPS! This job does not seem to exist\n", testJob7.ToString());

        }
    }
}
