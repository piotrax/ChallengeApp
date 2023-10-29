namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ValueTypeTest()
        {
            int number1 = 1;
            int number2 = 1;
            string tekst1 = "coś tam pasterze";
            string tekst2 = "coś tam pasterze";

            Assert.AreEqual(number1, number2);
            Assert.AreEqual(tekst1, tekst2);
        }

        [Test]
        public void CompareToUserObjects()
        {
            // arrange
            var user1 = GetUser("Peter");
            var user2 = GetUser("Peter");

            // act

            //assert
            Assert.AreEqual(user1.Login, user2.Login);

        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
