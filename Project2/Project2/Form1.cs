namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Who Wants To Be A Millionaire";
            label1.Font = new Font("Arial", 17, FontStyle.Bold);
            button1.Text = "Play";
            button2.Text = "Exit";
        }

        private void ExitClick(object sender, EventArgs e)
        {
            //Closes application
            Environment.Exit(0);
        }
    }
}
