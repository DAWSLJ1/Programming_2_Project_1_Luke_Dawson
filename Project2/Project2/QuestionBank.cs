using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public static class QuestionBank
    {
        public static List<Question> AllQuestions = new List<Question>();



        public static List<Question> AllQuestions1 { get => AllQuestions; set => AllQuestions = value; }

        public static List<Question> GetCategory(string category, string difficulty)
        {
            return AllQuestions.Where(n => n.Category == category && n.Difficulty == difficulty).ToList();
        }
    }
}
