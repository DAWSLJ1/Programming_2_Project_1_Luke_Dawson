using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Course
    {
        private Department department;
        private string Code;
        private string Name;
        private string Description;
        private int Credits;
        private int Fees;

        public Course(Department department, string code, string name, string description, int credits, int fees)
        {
            this.department = department;
            Code = code;
            Name = name;
            Description = description;
            Credits = credits;
            Fees = fees;
        }

        public Department Department { get => department; set => department = value; }
        public string Code1 { get => Code; set => Code = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Description1 { get => Description; set => Description = value; }
        public int Credits1 { get => Credits; set => Credits = value; }
        public int Fees1 { get => Fees; set => Fees = value; }
    }
}
