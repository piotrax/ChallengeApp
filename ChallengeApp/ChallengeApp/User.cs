using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public List<int> Score = new List<int>();

        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public void AddScore(int score)
        {
            this.Score.Add(score);
        }
        public int Result()
        {
            return this.Score.Sum();
        }

    }
}
