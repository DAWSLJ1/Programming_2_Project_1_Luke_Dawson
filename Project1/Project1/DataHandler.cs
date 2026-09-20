using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class DataHandler
    {

        /// <summary>
        /// Reads the "learner.txt" file and applies the format to align with each variable for each learner
        /// Some variables may be converted from string to match it's ideal format
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="learners"></param>
        /// <param name="courses"></param>
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
        /// <summary>
        /// Reads the "lecturer.txt" file and applies the format to align with each variable for each lecturer
        /// Some variables may be converted from string to match it's ideal format
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="lecturers"></param>
        /// <param name="courses"></param>
        public static void ReadFromLecFile(string filePath, List<Lecturer> lecturers, List<Course> courses)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] lecturerDetails = line.Split(',');
                int id = int.Parse(lecturerDetails[0]);
                string firstName = lecturerDetails[1];
                string lastName = lecturerDetails[2];
                EPosition position = (EPosition)(int.Parse(lecturerDetails[3]));
                ESalary salary = (ESalary)(int.Parse(lecturerDetails[4]));
                Course course = courses[int.Parse(lecturerDetails[5])];

                Lecturer lecturer = new Lecturer(course, id, firstName, lastName, salary, position);
                lecturers.Add(lecturer);

            }

        }
        /// <summary>
        /// Rewrites "learner.txt" file so that it display all learners, including additonally added ones in the correct format as the previous input using StreamWriter
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="learners"></param>
        /// <param name="courses"></param>
        public static void WriteToLearnFile(
        string fileName,
        List<Learner> learners,
        List<Course> courses)
        {
            List<string> lines = new List<string>();
            using (StreamWriter sr = new StreamWriter(fileName, false))
            {

                foreach (Learner learner in learners)
                {
                    CourseAssessmentMarks assessmentMarks =
                        learner.assessmentMarks;

                    int courseIndex = courses.IndexOf(
                        assessmentMarks.Course);

                    string marks = string.Join(",", assessmentMarks.GetAllMarks());

                    string line =
                        learner.ID + "," + learner.FirstName + "," + learner.LastName + "," + courseIndex + "," + marks;
                    lines.Add(line);
                }

                sr.WriteLine(fileName, lines);
            }
        }
    }
}

