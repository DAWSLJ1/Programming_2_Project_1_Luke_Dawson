using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class CourseAssessmentMark : Form
    {
        public Course Course { get; set; }

        public List<int> AssessmentMarks { get; set; }

        public CourseAssessmentMark(Course course, List<int> assessmentMarks)
        {
            this.Course = course;
            this.AssessmentMarks = assessmentMarks;
        }

        // Returns every assessment mark.
        public List<int> GetAllMarks()
        {
            return AssessmentMarks;
        }

        // Returns a grade for every assessment mark.
        public List<string> GetAllGrades()
        {
            List<string> grades = new List<string>();

            foreach (int mark in AssessmentMarks)
            {
                grades.Add(GetGrade(mark));
            }

            return grades;
        }

        public int GetHighestMark()
        {
            return AssessmentMarks.Max();
        }

        public int GetLowestMark()
        {
            return AssessmentMarks.Min();
        }

        // Returns all marks if below 50.
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

        public double GetAverageMark()
        {
            return AssessmentMarks.Average();
        }

        // Finds the grade based on the average mark.
        public string GetAverageGrade()
        {
            double average = GetAverageMark();

            return GetGrade((int)Math.Round(average));
        }

        // Update these ranges to match the assignment's grade table.
        private string GetGrade(int mark)
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
