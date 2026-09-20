using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class CourseAssessmentMarks
    {
        public Course Course { get; set; }

        public List<int> AssessmentMarks { get; set; }

        public CourseAssessmentMarks(Course course, List<int> assessmentMarks)
        {
            this.Course = course;
            this.AssessmentMarks = assessmentMarks;
        }

        /// <summary>
        /// Returns all marks for every learner
        /// </summary>
        /// <returns></returns>
        public List<int> GetAllMarks()
        {
            return AssessmentMarks;
        }

        /// <summary>
        /// Creates a list that displays the grade of each test for each learner
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllGrades()
        {
            List<string> grades = new List<string>();

            foreach (int mark in AssessmentMarks)
            {
                grades.Add(GetGrade(mark));
            }

            return grades;
        }

        /// <summary>
        /// Returns the mark with the highest value
        /// </summary>
        /// <returns></returns>
        public int GetHighestMark()
        {
            return AssessmentMarks.Max();
        }

        /// <summary>
        /// Returns the mark with the lowest value
        /// </summary>
        /// <returns></returns>
        public int GetLowestMark()
        {
            return AssessmentMarks.Min();
        }

        /// <summary>
        /// Returns certain marks if the amount of marks is below 50
        /// </summary>
        /// <returns></returns>
        public List<int> GetFailMarks()
        {
            List<int> failMarks = new List<int>();

            foreach (int mark in AssessmentMarks)
            {
                if (mark < 50)
                {
                    failMarks.Add(mark);
                }
            }

            return failMarks;
        }

        /// <summary>
        /// Averages the amount of marks across all learners
        /// </summary>
        /// <returns></returns>
        public double GetAverageMark()
        {
            return AssessmentMarks.Average();
        }

        /// <summary>
        /// Assigns a grade based on the average of all marks
        /// </summary>
        /// <returns></returns>
        public string GetAverageGrade()
        {
            double average = GetAverageMark();

            return GetGrade((int)Math.Round(average));
        }
        /// <summary>
        /// Assigns grade based on total amount of marks from a test
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>

        public string GetGrade(int mark)
        {
            if (mark >= 90)
            {
                return "A+";
            }
            else if (mark >= 85)
            {
                return "A";
            }
            else if (mark >= 80)
            {
                return "A-";
            }
            else if (mark >= 75)
            {
                return "B+";
            }
            else if (mark >= 70)
            {
                return "B";
            }
            else if (mark >= 65)
            {
                return "B-";
            }
            else if (mark >= 60)
            {
                return "C+";
            }
            else if (mark >= 55)
            {
                return "C";
            }
            else if (mark >= 50)
            {
                return "C-";
            }
            else
            {
                return "Fail";
            }
        }
    }
}
