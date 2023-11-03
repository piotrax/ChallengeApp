using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {   
        [Test]
        public void Employee_tests_Min_Max_Average()
        {
            // arrange
            var employee = new Employee("Pawe³", "Paw³owski");
            employee.AddGrade(0x5);
            employee.AddGrade(0x7);
            employee.AddGrade(-0x5);
            employee.AddGrade(-0xa);
            employee.AddGrade(0b111);

            // act
            var result = employee.GetGrade();
            var stats = employee.GetStatistics();

            //assert
            Assert.AreEqual(7, stats.Max);
            Assert.Greater(11, stats.Min);
            Assert.AreEqual(0, stats.Average);
        }
    }
}