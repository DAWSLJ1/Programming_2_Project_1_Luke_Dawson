using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Question
    {

        private string type;
        private string difficulty;
        private string category;
        private string question;
        private string correct;
        private string[] incorrect;

        public Question(string type, string difficulty, string category, string question, string correct, string[] incorrect)
        {
            this.type = type;
            this.difficulty = difficulty;
            this.category = category;
            this.question = question;
            this.correct = correct;
            this.incorrect = incorrect;
        }

        public string Type { get => type; set => type = value; }
        public string Difficulty { get => difficulty; set => difficulty = value; }
        public string Category { get => category; set => category = value; }
        public string Question1 { get => question; set => question = value; }
        public string Correct { get => correct; set => correct = value; }
        public string[] Incorrect { get => incorrect; set => incorrect = value; }
    }
}
