using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Department
    {
        private Institution Institution { get; set; }
        public string Name { get => name; set => name = value; }

        private string name;

        public Department(Institution institution, string name)
        {
            Institution = institution;
            this.name = name;
        }
    }
}

