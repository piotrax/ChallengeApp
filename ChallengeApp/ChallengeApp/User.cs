using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public List<int> Score = new List<int>();

        public User(string name)
        {
            this.Login = name;
        }
        public User(string name, string password)
        {
            this.Login = name;
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
