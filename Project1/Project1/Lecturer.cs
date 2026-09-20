using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// Creates an enum for each position's ID value
    /// </summary>
    public enum EPosition
    {
        Lecturer = 0,
        Senior_Lecturer = 1,
        Principal_Lecturer = 2,
        Associate_Professor = 3,
        Professor = 4
    }
    /// <summary>
    /// Creates an enum for each position's salary
    /// </summary>
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

        public Course Course1 { get => Course; set => Course = value; }
        public EPosition Position1 { get => Position; set => Position = value; }
        public ESalary Salary1 { get => Salary; set => Salary = value; }

        public override string DisplayDetail()
        {
            return base.DisplayDetail() + $"{Course}" + $"{Salary}" + $"{Position}";
        }


    }
}
