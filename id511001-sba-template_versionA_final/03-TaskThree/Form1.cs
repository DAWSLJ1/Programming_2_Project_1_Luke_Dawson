namespace TaskThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // DO NOT MODIFY THIS CODE
        private List<double> GenerateRandomCircumference()
        {
            Random random = new Random();
            List<double> circumf = new List<double>();

            while (circumf.Count < 15)
            {
                int radius = random.Next(1, 40);//over 200 when calculated.
                double circumference = 2 * Math.PI * radius;
                if (circumference >= 1 && circumference <= 200)
                {
                    circumf.Add(Math.Round(circumference,2));
                }
            }

            return circumf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Write task 3, step 1 here
            List<double> circle = GenerateRandomCircumference();
            // Write task 3, step 2 here
            List<double> small = new List<double>();
            List<double> medium = new List<double>();
            List<double> large = new List<double>();

            foreach (double circ in circle)
            {
                if (circ >= 1 && circ <= 60)
                {
                    small.Add(circ);
                }
                else if (circ >= 60 && circ <= 120)
                {
                    medium.Add(circ);
                }
                else
                {
                    large.Add(circ);
                }
            }
            // Write task 3, step 3 here
            label1.Text = "Small circle (1–60): " + string.Join(", ", small);
            label2.Text = "Medium circle (over 60–120): " + string.Join(", ", medium);
            label3.Text = "Large circle (over 120–200): " + string.Join(", ", large);

            // Write task 3, step 4 here
            label1.ForeColor = Color.Purple;
            label2.ForeColor = Color.Teal;
            label3.ForeColor = Color.Orange;
        }

        
    }
}
