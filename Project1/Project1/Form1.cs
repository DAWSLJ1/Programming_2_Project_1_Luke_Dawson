namespace Project1
{
    public partial class Form1 : Form
    {
        public List<Learner> Learners = new();
        public List<Lecturer> Lecturers = new();
        /// <summary>
        /// Assigns names of all buttons & labels
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Manually changes text for each button
            button1.Text = "1. Display Course Details";
            button2.Text = "2. Display All Marks";
            button3.Text = "3. Display All Grades";
            button4.Text = "4. Display Highest Marks";
            button5.Text = "5. Display Lowest Marks";
            button6.Text = "6. Display All Fail Marks";
            button7.Text = "7. Display Average Marks";
            button8.Text = "8. Display Average Grades";
            button9.Text = "9. Display Lecturer Details";
            button10.Text = "10. Add a Learner";
            button11.Text = "11. Add a Lecturer";
            button12.Text = "12. Remove a Lecturer";
            button13.Text = "\tCalculations";
            button14.Text = "\tExit";
            label1.Text = "Course Assessment Manager";
            label1.Font = new Font("Arial", 14, FontStyle.Bold);
            //Calls each list of the Seeder class
            Seeder.SeedInstitutions();
            Seeder.SeedDepartments();
            Seeder.SeedCourses();
            DataHandler.ReadFromLearnFile("learners.txt", Learners, Seeder.Courses);
            DataHandler.ReadFromLecFile("lecturers.txt", Lecturers, Seeder.Courses);
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            //Closes application
            Environment.Exit(0);
        }

        private void DisplayCouseClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Seeder.Courses;
        }

        /// <summary>
        /// Displays all marks across all learners in the text file by displaying all learners information & converting the marks into a listed string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DisplayMarksClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Learners.Select(n => new
                {
                ID = n.ID,
                First_Name = n.FirstName,
                Last_Name = n.LastName,
                Course_Code = n.assessmentMarks.Course.Code,
                Course_Name = n.assessmentMarks.Course.Name,
                Marks = string.Join(",", n.assessmentMarks.GetAllMarks())
            }).ToList();
        }

        /// <summary>
        /// Displays the grades of all the learners by refering to a method in CourseAssessmentMarks which gives a lettered grade based on the amount of marks a learner has on a select test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DisplayGradesClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Learners.Select(n => new
            {
                ID = n.ID,
                First_Name = n.FirstName,
                Last_Name = n.LastName,
                Course_Code = n.assessmentMarks.Course.Code,
                Course_Name = n.assessmentMarks.Course.Name,
                Marks = string.Join(",", n.assessmentMarks.GetAllGrades())
            }).ToList();
        }

        /// <summary>
        /// Displays the highest mark of all the given marks for each learner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DisplayHighMarkClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Learners.Select(n => new
            {
                ID = n.ID,
                First_Name = n.FirstName,
                Last_Name = n.LastName,
                Course_Code = n.assessmentMarks.Course.Code,
                Course_Name = n.assessmentMarks.Course.Name,
                Marks = string.Join(",", n.assessmentMarks.GetHighestMark())
            }).ToList();
        }

        /// <summary>
        /// Displays the lowest mark of all the given marks for each learner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DisplayLowMarkClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Learners.Select(n => new
            {
                ID = n.ID,
                First_Name = n.FirstName,
                Last_Name = n.LastName,
                Course_Code = n.assessmentMarks.Course.Code,
                Course_Name = n.assessmentMarks.Course.Name,
                Marks = string.Join(",", n.assessmentMarks.GetLowestMark())
            }).ToList();
        }

        /// <summary>
        /// Displays all the marks that are classed as a failing mark, (Any mark that is under 50), for each learner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DisplayFailMarkClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Learners.Select(n => new
            {
                ID = n.ID,
                First_Name = n.FirstName,
                Last_Name = n.LastName,
                Course_Code = n.assessmentMarks.Course.Code,
                Course_Name = n.assessmentMarks.Course.Name,
                Marks = string.Join(",", n.assessmentMarks.GetFailMarks())
            }).ToList();
        }

        /// <summary>
        /// Displays the average mark amount for all learners
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DisplayAvgMarkClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Learners.Select(n => new
            {
                ID = n.ID,
                First_Name = n.FirstName,
                Last_Name = n.LastName,
                Course_Code = n.assessmentMarks.Course.Code,
                Course_Name = n.assessmentMarks.Course.Name,
                Marks = string.Join(",", n.assessmentMarks.GetAverageMark())
            }).ToList();
        }

        /// <summary>
        /// Displays the average grade for all learners
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DisplayAvgGradeClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Learners.Select(n => new
            {
                ID = n.ID,
                First_Name = n.FirstName,
                Last_Name = n.LastName,
                Course_Code = n.assessmentMarks.Course.Code,
                Course_Name = n.assessmentMarks.Course.Name,
                Marks = string.Join(",", n.assessmentMarks.GetAverageGrade())
            }).ToList();
        }

        /// <summary>
        /// Displays all information about each lecturer in the text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void DisplayLecturerClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = Lecturers.Select(n => new
            {
                ID = n.ID,
                first_name = n.FirstName,
                last_name = n.LastName,
                Position = n.Position1.ToString(),
                Salary = ((int)n.Salary1).ToString("C"),
                Institution = n.Course1.Institution,
                Region = n.Course1.Region,
                Country = n.Course1.Country,
                Department = n.Course1.Department,
                Course_Code = n.Course1.Code,
                Course_Name = n.Course1.Name
            }).ToList();
        }

        /// <summary>
        /// Method for any invalid input for name, if input is left empty
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        
        private bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            foreach (char character in name) {
                if (!char.IsLetter(character) && !char.IsLetter(' '))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Adds 1 to each added learners ID number
        /// </summary>
        /// <returns></returns>
        
        private int GetNextLearnerId()
        {
            return Learners.Count + 1;
        }
        
        /// <summary>
        /// Displays menu for adding an additional learner to the database
        /// Displayed in 5 different message boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void AddLearnerClick(object sender, EventArgs e)
        {
        string firstName = Microsoft.VisualBasic.Interaction.InputBox(
        "Enter the learner's first name:",
        "Add Learner");

        if (!IsValidName(firstName))
        {
            MessageBox.Show(
            "First name cannot be empty and can only contain letters, spaces, hyphens, or apostrophes.",
            "Invalid First Name",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);

        return;
        }

        string lastName = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter the learner's last name:", "Add Learner");

        if (!IsValidName(lastName))
        {
        MessageBox.Show(
            "Last name cannot be empty and can only contain letters, spaces, hyphens, or apostrophes.",
            "Invalid Last Name",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);

        return;
        }

        string courseNumberText = Microsoft.VisualBasic.Interaction.InputBox(
        "Enter the course number:" +
        Environment.NewLine +
        Environment.NewLine, "Add Learner");

        if (!int.TryParse(courseNumberText, out int courseNumber) ||
        courseNumber < 1 ||
        courseNumber > Seeder.Courses.Count)
        {
        MessageBox.Show(
            "Enter a valid course number.",
            "Invalid Course",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);

        return;
        }

        Course selectedCourse = Seeder.Courses[courseNumber - 1];

        List<int> learnerMarks = new List<int>();

        for (int markNumber = 1; markNumber <= 5; markNumber++)
        {
        string markText = Microsoft.VisualBasic.Interaction.InputBox(
            "Enter assessment mark " + markNumber +
            " of 5 (between 0 and 100):",
            "Add Learner");

        if (!int.TryParse(markText, out int mark) ||
            mark < 0 ||
            mark > 100)
        {
            MessageBox.Show(
                "Assessment marks must be whole numbers from 0 to 100.",
                "Invalid Assessment Mark",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        learnerMarks.Add(mark);
        }

        int newId = GetNextLearnerId();

        CourseAssessmentMarks assessmentMarks =
            new CourseAssessmentMarks(
                selectedCourse,
                learnerMarks);

        Learner newLearner = new Learner(
            assessmentMarks,
            newId,
            firstName.Trim(),
            lastName.Trim());

        Learners.Add(newLearner);

        DataHandler.WriteToLearnFile(
            "learners.txt", Learners, Seeder.Courses);

        MessageBox.Show(
            "Learner added successfully." +
            Environment.NewLine +
            "Learner ID: " + newId,
            "Learner Added",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        // Loads all learners to display changed grid
        DisplayMarksClick(sender, e);
            }

        private void button11_Click(object sender, EventArgs e)
        {
            //No attempt
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //No attempt
        }

        /// <summary>
        /// Displays menu for displaying calculations for certain aspects of the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void CalcClick(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Select choice of Calculation" + Environment.NewLine + Environment.NewLine + "1. Average marks and grades for each institution" + Environment.NewLine + "2. Average salary of all lecturers" + Environment.NewLine + "3. Total fees collected for each course" + Environment.NewLine + "4. Completion Rate of all Courses", "Calculations");
            if (result == "1")
            {
                DisplayInstAvgResults();
            }
            else if (result == "2")
            {
                DisplayAvgLecSal();
            }
            else if (result == "3")
            {
                TotalFee();
            }
            else if (result == "4")
            {
                CompleteRate();
            }
            else if (!string.IsNullOrWhiteSpace(result))
            {
                MessageBox.Show("Enter valid option", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Displays the completion rate of each course, consisting of the amount of learners in each course and how many passed
        /// </summary>
        
        private void CompleteRate()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Seeder.Courses.Select(course => new
            {
                Course_Code = course.Code,
                Couse_Name = course.Name,
                Number_Of_Learners = Learners.Count(learner => learner.assessmentMarks.Course == course),
                Learner_Completed = Learners.Count(learner => learner.assessmentMarks.Course == course && learner.assessmentMarks.GetAllGrades().Count == 5 && learner.assessmentMarks.GetAllMarks().All(mark => mark >= 50)),
                Completed_Rate = GetCompleteRate(course).ToString("0.00") + "%"
            }).ToList();
            }

        /// <summary>
        /// creates int value based on how many learners have inputs for all 5 marks and checks if all are over 50 marks
        /// Then divides the amount by the total amount of learners in that certain course
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        
        private double GetCompleteRate(Course course)
        {
            int learnerAmount = Learners.Count(learner => learner.assessmentMarks.Course == course);
            //Checking to see if all marks are there and if all are above 50 marks for each test
            int completeLearnerAmount = Learners.Count(learner => learner.assessmentMarks.Course == course && learner.assessmentMarks.GetAllMarks().Count == 5 && learner.assessmentMarks.GetAllMarks().All(mark => mark >= 50));
            return (double)completeLearnerAmount / learnerAmount * 100;
        }

        /// <summary>
        /// Displays the amount of learners in each course, the cost of how much each course is, and then multiplies them to get the total amount spent on each course
        /// </summary>
        
        private void TotalFee()
        {
            List<object> feeResults = new List<object>();
            foreach (Course course in Seeder.Courses)
            {
                int learnerCount = Learners.Count(learner => learner.assessmentMarks.Course == course);
                int totalfees = learnerCount * course.Fees;
                feeResults.Add(new
                {
                    Course_Code = course.Code,
                    Course_Name = course.Name,
                    Number_Of_Learners = learnerCount,
                    Course_Fee = course.Fees.ToString("C"),
                    Total_Fees = totalfees.ToString("C")
                });
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = feeResults;
        }

        /// <summary>
        /// Displays average salary by taking all the salaries of all lecturers and averaging the total
        /// </summary>
        
        private void DisplayAvgLecSal()
        {
            double averageSalary = Lecturers.Average(lecturer => (int)lecturer.Salary1);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new[]
            {
                new
                {
                    Lecturer_Count = Lecturers.Count, Avg_Lec_Salary = averageSalary.ToString("C")
                }
            };
        }

        /// <summary>
        /// Displays the average marks and grades across each institution
        /// </summary>
        
        private void DisplayInstAvgResults()
        {
            dataGridView1.DataSource = null;
            var institutionResults = Learners.GroupBy(learner => learner.assessmentMarks.Course.Institution).Select(group => new
            {
                Institution_Name = group.Key,
                Learner_Count = group.Count(),
                Average_Marks = group.SelectMany(learner => learner.assessmentMarks.GetAllMarks()).Average().ToString("0.00"),
                Average_Grade = GetGradeFromMark(group.SelectMany(learner => learner.assessmentMarks.GetAllMarks()).Average())
            }).ToList();

            dataGridView1.DataSource = institutionResults;
        }

        /// <summary>
        /// Assigns an average grade based on the average of each learners marks
        /// </summary>
        /// <param name="avgMark"></param>
        /// <returns></returns>
        
        private string GetGradeFromMark(double avgMark)
        {
            if (avgMark >= 90)
            {
                return "A+";
            }
            else if (avgMark >= 85)
            {
                return "A";
            }
            else if (avgMark >= 80)
            {
                return "A-";
            }
            else if (avgMark >= 75)
            {
                return "B+";
            }
            else if (avgMark >= 70)
            {
                return "B";
            }
            else if (avgMark >= 65)
            {
                return "B-";
            }
            else if (avgMark >= 60)
            {
                return "C+";
            }
            else if (avgMark >= 55)
            {
                return "C";
            }
            else if (avgMark >= 50)
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
