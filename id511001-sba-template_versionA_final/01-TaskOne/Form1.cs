namespace TaskOne
{
    public partial class Form1 : Form
    {
        private List<RebelAlliance> rebels;

        public Form1()
        {
            InitializeComponent();

            rebels = new List<RebelAlliance>
            {
                new RebelAlliance("Luke", "Skywalker", 5),
                new RebelAlliance("Leia", "Organa", 7),
                new RebelAlliance("Han", "Solo", 5),
                new RebelAlliance("Mon", "Mothma", 7),
                new RebelAlliance("Cassian", "Andor", 5),
                new RebelAlliance("Jyn", "Erso", 1),
                new RebelAlliance("Hera", "Syndulla", 7),
                new RebelAlliance("Ahsoka", "Tano", 3)
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Write task 1, step 4 here
            List<RebelAlliance> rebelAlliances = rebels.Where(r => r.LastName.StartsWith("S")).ToList();
            
            listBox1.Items.Clear();

            // Write task 1, step 5 here
            foreach(RebelAlliance rebel in rebelAlliances)
            {
                listBox1.Items.Add($"{rebel.FirstName} {rebel.LastName}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Write task 1, step 6 here
            List<RebelAlliance> rebelAlliances = rebels.Where(r => r.YearsInRebellion <= 5 && r.YearsInRebellion >= 3).ToList();

            listBox2.Items.Clear();

            // Write task 1, step 7 here
            foreach (RebelAlliance rebel in rebelAlliances)
            {
                listBox2.Items.Add($"{rebel.FirstName} {rebel.LastName} {rebel.YearsInRebellion}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Write task 1, step 8 here
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
