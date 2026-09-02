using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public static class Seeder
    {
        private static List<Institution> institutions = new List<Institution>();
        private static List<Department> departments = new List<Department>();
        private static List<Course> courses = new List<Course>();

        public static List<Institution> SeedInstitutions()
        {
            institutions.Add(new Institution("Otago Polytechnic", "Otago", "New Zealand"));
            institutions.Add(new Institution("University of Canterbury", "Christchurch", "New Zealand"));
            institutions.Add(new Institution("University of Auckland", "Auckland", "New Zealand"));
            return institutions;
        }

        public static List<Department> SeedDepartments()
        {
            departments.Add(new Department(institutions[0], "Information Technology"));
            departments.Add(new Department(institutions[1], "Business"));
            departments.Add(new Department(institutions[2], "Mathematics"));
            return departments;
        }

        public static List<Course> SeedCourses()
        {
            courses.Add(new Course(departments[0], "ID511001", "Programming 2", "Advanced programming concepts", 15, 3500));
            courses.Add(new Course(departments[1], "ID511002", "Business 1", "Introduction to Business", 15, 3800));
            courses.Add(new Course(departments[2], "ID511001", "Mathematics 3", "Algebra", 15, 2800));
            return courses;
        }
    }
}
