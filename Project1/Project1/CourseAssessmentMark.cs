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
        public CourseAssessmentMark()
        {
            InitializeComponent();
        }
        public enum EPosition
        {
            Lecturer = 0,
            Senior_Lecturer = 1,
            Principal_Lecturer = 2,
            Associate_Professor = 3,
            Professor = 4
        }
        public enum ESalary
        {
            Lecturer_Salary = 85000,
            Senior_Lecturer_Salary = 100000,
            Principal_Lecturer_Salary = 115000,
            Associate_Professor_Salary = 130000,
            Professor_Salary = 145000
        }
        public class Learners
        {
            private int ID;
            private string name;
            private int scores;

            public Learners(int ID, string name, int scores)
            {
                this.ID = ID;
                this.name = name;
                this.scores = scores;
            }

            public string Name { get => name; }
            public int iD { get => ID; }
            public int Scores { get => scores; }

            // A CSV line representing this contact, matching the format it was read from
            public string ToCsvLine() => $"{ID},{name},{scores}";
        }
        public static List<Learners> LoadContacts(string filePath)
        {
            List<Learners> contacts = new List<Learners>();
            string[] lines = File.ReadAllLines(filePath);

            return contacts;
        }
    }
}
