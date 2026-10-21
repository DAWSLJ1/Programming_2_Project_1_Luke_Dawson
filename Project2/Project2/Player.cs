using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Player
    {
        private string name;
        private int age;
        private string hobbies;
        private string job;

        public Player(string name, int age, string hobbies, string job)
        {
            this.name = name;
            this.age = age;
            this.hobbies = hobbies;
            this.job = job;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Hobbies { get => hobbies; set => hobbies = value; }
        public string Job { get => job; set => job = value; }
    }
}
