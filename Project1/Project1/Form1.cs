namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
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
        public class students
        {
            private int ID;
            private string name;
            private int scores;

            public students(int ID, string name, int scores)
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
        public static List<students> LoadContacts(string filePath)
        {
            List<students> contacts = new List<students>();
            string[] lines = File.ReadAllLines(filePath);

            // Skip the header row (index 0), and turn every other row into a Contact
            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');
                contacts.Add(new students(fields[0], fields[1], fields[2]));
            }

            return contacts;
        }
    }
}
