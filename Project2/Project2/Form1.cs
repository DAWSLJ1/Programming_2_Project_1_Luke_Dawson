namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string temp = "";
            int score = 0;
            label1.Text = "Money Tree";
            label1.Font = new Font("Arial", 10, FontStyle.Bold);
            label2.Text = ($"Playing for: ${score}");
            label2.Font = new Font("Arial", 8, FontStyle.Bold);
            //button1.Text = Question;
            //button2.Text = Question;
            //button3.Text = Question;
            //button4.Text = Question;
            //textBox2.Text = Question;
            button5.Text = "50/50";
            button6.Text = "Ask Audience";
            button7.Text = "Phone A Friend";
            button8.Text = "Change Question";
            textBox1.Text = "$1,000,000 \r\n$500,000 \r\n$250,000 \r\n$125,000 \r\n$64,000 \r\n$32,000 – Bank level \r\n$16,000 \r\n$8,000 \r\n$4,000 \r\n$2,000 \r\n$1,000 – Bank level \r\n$500 \r\n$300 \r\n$200 \r\n$100 ";
            button9.Text = "Continue";
            button10.Text = "Walk Away";
            label3.Text = ($"Difficulty:  {selectedDifficulty}");
            label3.Font = new Font("Arial", 8, FontStyle.Bold);
            label4.Text = ($"Player: {temp}");
            label5.Text = ($"Level {temp}/15");
            label6.Text = ($"Phone a Friend: {temp}");
            label7.Text = ($"");
            label7.Font = new Font("Arial", 9, FontStyle.Bold);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.BackColor = Color.White;
            label8.Text = ($"Category: {selectedCategrory}");
            label8.Font = new Font("Arial", 8, FontStyle.Bold);


        }

        public Form1(string category) : this()
        {
            selectedCategrory = category;
        }

        private string selectedCategrory = "";
        private string selectedDifficulty = "";


        private void button9_Click(object sender, EventArgs e)
        {
            label7.Text = ($"Correct! Winnings: $");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }


}

