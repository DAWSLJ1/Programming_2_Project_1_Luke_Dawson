using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Seeder
    {
        private static List<Institution> institutions = new List<Institution>();
        private static List<Departments> departments = new List<Departments>();
        private static List<Course> course = new List<Course>();
        public static List<Institution> SeedInstitution()
        {

            return new List<Institution>() {
               Institution.Add((new Institution("University of Otago, Dunedin, New Zealand")),
                new Institution("University of Auckland, Auckland, New Zealand"),
                new Institution("University of Canterbury, Christchurch, New Zealand")
            };
        }

        public static List<Departments> SeedDepartments()
        {
            return new List<Departments>() {
                new Departments("University of Otago, Dunedin, New Zealand"),
                new Departments("University of Auckland, Auckland, New Zealand"),
                new Departments("University of Canterbury, Christchurch, New Zealand")
            };
        }
        public static List<Course> SeedCourses()
        {
            return new List<Course>()
            {
                new Course("University of Otago, Dunedin, New Zealand"),
                new Course("University of Auckland, Auckland, New Zealand"),
                new Course("University of Canterbury, Christchurch, New Zealand")
            };
        }
    } 
}
