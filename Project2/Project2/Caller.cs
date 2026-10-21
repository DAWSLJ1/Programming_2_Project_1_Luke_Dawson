using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Caller
    {
        private string name;
        private string job;
        private string weakness;
        private string strength;

        public Caller(string name, string job, string weakness, string strength)
        {
            this.name = name;
            this.job = job;
            this.weakness = weakness;
            this.strength = strength;
        }

        public string Name { get => name; set => name = value; }
        public string Job { get => job; set => job = value; }
        public string Weakness { get => weakness; set => weakness = value; }
        public string Strength { get => strength; set => strength = value; }
    }
}
