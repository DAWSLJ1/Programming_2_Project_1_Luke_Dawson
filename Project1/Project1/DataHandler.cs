using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class DataHandler
    {

        public static void ReadFromLearnFile(string filePath, List<Learner> learners, List<Course> courses)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] learnerDetails = line.Split(',');
                int id = int.Parse(learnerDetails[0]);
                string firstName = learnerDetails[1];
                string lastName = learnerDetails[2];
                int courseNum = int.Parse(learnerDetails[3]);

                List<int> marks = new List<int>()
        {
            Convert.ToInt32(learnerDetails[4]),
            Convert.ToInt32(learnerDetails[5]),
            Convert.ToInt32(learnerDetails[6]),
            Convert.ToInt32(learnerDetails[7]),
            Convert.ToInt32(learnerDetails[8])
        };

                CourseAssessmentMarks Marks = new CourseAssessmentMarks(courses[courseNum], marks);
                Learner learner = new Learner(Marks, id, firstName, lastName);
                learners.Add(learner);
            }
        }
        public static void ReadFromLecFile(string filePath, List<Lecturer> lecturer, List<Course> courses, List<EPosition> positions, List<ESalary> salaries)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] lecturerDetails = line.Split(',');
                int id = int.Parse(lecturerDetails[0]);
                string firstName = lecturerDetails[1];
                string lastName = lecturerDetails[2];
                int position = int.Parse(lecturerDetails[3]);
                int salary = int.Parse(lecturerDetails[4]);
                string course = lecturerDetails[5];

            }

        }
    }
}

