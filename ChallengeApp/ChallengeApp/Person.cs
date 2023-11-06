namespace ChallengeApp
{
    public abstract class Person
    {
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public string Gender { get; protected set; }

        protected Person()
        {
        }

        protected Person(string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

    }
}
