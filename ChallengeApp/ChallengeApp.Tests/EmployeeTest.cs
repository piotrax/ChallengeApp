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
            employee.AddGrade("5");
            employee.AddGrade("7");
            employee.AddGrade("-5");
            employee.AddGrade("-2");
            employee.AddGrade("3");
            employee.AddGrade("B");

            // act
            var stats = employee.GetStatistics();

            //assert
            Assert.AreEqual(80, stats.Max);
            Assert.AreEqual(3, stats.Min);
            Assert.AreEqual(Math.Round(23.75, 2), Math.Round(stats.Average, 2));
        }
    }
}