using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {   
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void CollectFiveScores_ShouldReturnCorrectResultSum()
        {
            // arrange
            var employee = new Employee("Pawe³", "Paw³owski", 44);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(-7);
            employee.AddScore(-5);
            employee.AddScore(1);

            // act
            var result = employee.GetScore();

            //assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CollectNegativeAndPositiveScores_ShouldReturnCorrectResultSum()
        {
            // arrange
            var employee = new Employee("Pawe³", "Paw³owski", 44);
            employee.AddScore(3);
            employee.AddScore(9);
            employee.AddScore(2);
            employee.AddScore(-5);
            employee.AddScore(-9);

            // act
            var result = employee.GetScore();

            //assert
            Assert.AreEqual(0, result);
        }
    }
}