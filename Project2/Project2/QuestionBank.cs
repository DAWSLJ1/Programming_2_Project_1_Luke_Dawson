using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class QuestionBank
    {
        private List<Question> AllQuestions;

        public QuestionBank(List<Question> allQuestions)
        {
            this.AllQuestions = allQuestions;
        }

        internal List<Question> AllQuestions1 { get => AllQuestions; set => AllQuestions = value; }

        public List<Question> GetCategory(string category, string difficulty)
        {
            return AllQuestions.Where(n => n.Category == category && n.Difficulty == difficulty).ToList();
        }
    }
}
