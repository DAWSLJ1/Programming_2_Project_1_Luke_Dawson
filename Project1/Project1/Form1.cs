namespace Project1
{
    public partial class Form1 : Form
    {
        public List<Learner> Learners = new();
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
            //Calls each list of the Seeder class
            Seeder.SeedInstitutions();
            Seeder.SeedDepartments();
            Seeder.SeedCourses();
            DataHandler.ReadFromLearnFile("learners.txt", Learners, Seeder.Courses);
        }

        private void RefreshDataGrid(int columnCount)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.ColumnCount = columnCount;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //Closes application
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Seeder.Courses;
            //RefreshDataGrid(9);
            //dataGridView1.Columns[0].HeaderText = "Code";
            //dataGridView1.Columns[1].HeaderText = "Name";
            //dataGridView1.Columns[2].HeaderText = "Description";
            //dataGridView1.Columns[3].HeaderText = "Credits";
            //dataGridView1.Columns[4].HeaderText = "Fees";
            //dataGridView1.Columns[5].HeaderText = "Institution";
            //dataGridView1.Columns[6].HeaderText = "Region";
            //dataGridView1.Columns[7].HeaderText = "Country";
            //dataGridView1.Columns[8].HeaderText = "Department";
            //foreach (Course course in Seeder.Courses)
            //{
            //    //Make an array of strings containing the display data
            //    string[] tempRow = { $"{course.Code}", $"{course.Name}", $"{course.Description}", $"{course.Credits}", $"${course.Fees}", $"{course.Department.Institution.Name}", $"{course.Department.Institution.Region}", $"{course.Department.Institution.Country}", $"{course.Department.Name}" };
            //    //Then add the array to the grid as a row
            //    dataGridView1.Rows.Add(tempRow);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RefreshDataGrid(6);

            //dataGridView1.Columns[0].HeaderText = "ID";
            //dataGridView1.Columns[1].HeaderText = "First Name";
            //dataGridView1.Columns[2].HeaderText = "Last Name";
            //dataGridView1.Columns[3].HeaderText = "Course Code";
            //dataGridView1.Columns[4].HeaderText = "Course Name";
            //dataGridView1.Columns[5].HeaderText = "Assessment Marks";

            //foreach (Learner learner in Learners)
            //{
            //    CourseAssessmentMarks courseAssessmentMark =
            //        learner.assessmentMarks;

            //    Course course = courseAssessmentMark.Course;

            //    // Turns the List<int> of marks into one display string,
            //    string marks = string.Join(
            //     ", ",
            //        courseAssessmentMark.GetAllMarks());

            //    // Make an array of strings containing the display data.
            //    string[] tempRow =
            //    {
            //$"{learner.ID}",
            //$"{learner.FirstName}",
            //$"{learner.LastName}",
            //$"{course.Code}",
            //$"{course.Name}",
            ////$"{learner.assessmentMarks.GetAllMarks()"
            //};

            //    // Add the array to the DataGridView as a row.
            //    //dataGridView1.Rows.Add(tempRow);
            //}
            dataGridView1.DataSource = Learners.Select(n => new
                {
                    first_name = n.FirstName,
                    last_name = n.LastName,
                    ID = n.ID,
                    Marks = string.Join(",", n.assessmentMarks.GetAllMarks())
            }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
