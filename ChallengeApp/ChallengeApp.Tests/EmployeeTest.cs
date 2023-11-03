using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {   
        [Test]
        public void CollectFiveGrades_ShouldReturnCorrectResultSum()
        {
            // arrange
            var employee = new Employee("Pawe³", "Paw³owski");
            employee.AddGrade(0x5);
            employee.AddGrade(0x7);
            employee.AddGrade(-0x7);
            employee.AddGrade(-0xa);
            employee.AddGrade(0b111);

            // act
            var result = employee.GetGrade();

            //assert
            Assert.AreEqual(2, result);
        }
    }
}