using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Learner : Person
    {
            
        private CourseAssessmentMarks courseAssessmentMarks;

        public Learner(CourseAssessmentMarks Marks, int iD, string firstName, string lastName) : base(iD,firstName,lastName)
        {
            this.courseAssessmentMarks = Marks;
        }

        public override string DisplayDetail()
        {
            return base.DisplayDetail() + $"{courseAssessmentMarks.Course}";
        }

    }
}
