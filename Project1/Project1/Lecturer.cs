using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public enum EPosition
    {
        Lecturer = 0,
        Senior_Lecturer = 1,
        Principal_Lecturer = 2,
        Associate_Professor = 3,
        Professor = 4
    }
    public enum ESalary
    {
        Lecturer_Salary = 85000,
        Senior_Lecturer_Salary = 100000,
        Principal_Lecturer_Salary = 115000,
        Associate_Professor_Salary = 130000,
        Professor_Salary = 145000
    }
    public class Lecturer : Person
    {
        private Course Course;
        private EPosition Position;
        private ESalary Salary;

        public Lecturer(Course course, int iD, string firstName, string lastName, ESalary salary, EPosition position) : base(iD, firstName, lastName)
        {
            this.Course = course;
            this.Position = position;
            this.Salary = salary;
        }

        public override string DisplayDetail()
        {
            return base.DisplayDetail() + $"{Course}" + $"{Salary}" + $"{Position}";
        }


    }
}
