namespace TaskTwo
{
    public partial class Form1 : Form
    {
        private List<Transport> transportation;

        public Form1()
        {
            InitializeComponent();

            transportation = new List<Transport>
            {
                new MotorBike("Harley-Davidson", "Road Glide", 22.7),
                new MotorVehicle("Chevrolet", "Camaro ZL1", 72),
                new MotorBike("Ducati", "Panigale V4", 16),
                new MotorVehicle("Ford", "Mustang Shelby GT500", 60),
                new MotorBike("BMW", "R1250 GS Adventure", 30),
                new MotorVehicle("Dodge", "Challenger Hellcat", 70)
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Write task 2, step 8 here
            dataGridView1.Columns.Add("make", "Make");
            dataGridView1.Columns.Add("model", "Model");
            dataGridView1.Columns.Add("litre", "Litre");

            // Write task 2, step 9 here
            foreach (Transport transportation in transportation)
            {
                dataGridView1.Rows.Add(transportation);
            }

            // DO NOT MODIFY THIS CODE
            int rowHeight = dataGridView1.RowTemplate.Height;
            int headerHeight = dataGridView1.ColumnHeadersHeight;
            dataGridView1.Height = headerHeight + (rowHeight * (transportation.Count + 1));

            // Write task 2, step 10 here

            double count = transportation.Where(transportation => transportation.litre >= 25).Count();
        }
    }
}
