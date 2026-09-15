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
        private string Codes;
        private string Names;
        private string Descriptions;
        private int Creditss;
        private int Fee;

        public Course(Department department, string code, string name, string description, int credits, int fees)
        {
            this.department = department;
            Codes = code;
            Names = name;
            Descriptions = description;
            Creditss = credits;
            Fee = fees;
        }

        public string Name { get => Names; set => Names = value; }
        public string Department { get => department.Name; set => department.Name = value; }
        public string Institution { get => department.Institution.Name; set => department.Institution.Name = value; }
        public string Region { get => department.Institution.Region; set => department.Institution.Region = value; }
        public string Country { get => department.Institution.Country; set => department.Institution.Country = value; }
        public string Code { get => Codes; set => Codes = value; }
        public string Description { get => Descriptions; set => Descriptions = value; }
        public int Credits { get => Creditss; set => Creditss = value; }
        public int Fees { get => Fee; set => Fee = value; }
    }
}
