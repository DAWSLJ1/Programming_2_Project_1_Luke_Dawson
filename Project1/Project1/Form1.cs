namespace Project1
{
    public partial class Form1 : Form
    {
        public List<Learner> Learners = new();
        public List<Lecturer> Lecturers = new();
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


        private void AddLearnerClick(object sender, EventArgs e)
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
