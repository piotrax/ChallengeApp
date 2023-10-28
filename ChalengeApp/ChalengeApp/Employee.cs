using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age {get; set; }
        public List<int> Score = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public void AddScore(int score)
        {
            this.Score.Add(score);
        }
    }
}
