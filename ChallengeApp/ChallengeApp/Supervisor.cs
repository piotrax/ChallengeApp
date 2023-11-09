using System.Security.Cryptography.X509Certificates;
using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public List<float> grades = new List<float>();
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }
        public Supervisor(string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        public void AddGrade(string grade)
        {
            Dictionary<string, int> mapGrades = new Dictionary<string, int>()
            {
                {"6", 100}, {"-6", 95}, {"6-", 95}, {"+5", 85}, {"5+", 85}, {"5", 80},
                {"-5", 75}, {"5-", 75}, {"+4", 65}, {"4+", 65}, {"4", 60}, {"-4", 55},
                {"4-", 55}, {"+3", 45}, {"3+", 45}, {"3", 40}, {"3-", 35}, {"-3", 35},
                {"2+", 25}, {"+2", 25}, {"2", 20}, {"-2", 15}, {"2-", 15}, {"+1",  5},
                {"1+",  5}, {"1",   0}
            };

            try
            {
                grades.Add(mapGrades[grade]);
            }

            catch (Exception e)
            {
                throw new Exception($"Input error! {e.Message}");
            }

        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }
        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }
        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
