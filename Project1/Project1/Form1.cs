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
            
         // Reads learner and lecturer data from the text files.
            DataHandler.ReadFromLearnFile(
                "learners.txt",
                Learners,
                Seeder.Courses);

            DataHandler.ReadFromLecturerFile(
                "lecturers.txt",
                Lecturers,
                Seeder.Courses);
        }

        /// Clears existing grid columns and displays a list in the DataGridView.
        private void DisplayData<T>(List<T> data)
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = data;
        }

        }

        private void button14_Click(object sender, EventArgs e)
        {
        //Closes application
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //Pulls Course, Department & Institution data from Seeder Class
             List<CourseDisplay> courseDetails = new List<CourseDisplay>();

            foreach (Course course in Seeder.Courses)
            {
                courseDetails.Add(new CourseDisplay
                {
                    Code = course.Code,
                    Name = course.Name,
                    Description = course.Description,
                    Credits = course.Credits,
                    Fees = course.Fees,
                    Institution = course.Department.Institution.Name,
                    Region = course.Department.Institution.Region,
                    Country = course.Department.Institution.Country,
                    Department = course.Department.Name
                });
            }

            DisplayData(courseDetails);
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataHandler.ReadFromLearnFile("learners.txt", "lecturers.txt");
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
