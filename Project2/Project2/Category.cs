using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            label1.Font = new Font("Arial", 14, FontStyle.Bold);
            label1.Text = "Choose Your Category";
            button1.Text = "Art";
            button2.Text = "Computers";
            button3.Text = "Gen-Knowledge";
            button4.Text = "History";
            button5.Text = "Music";
            button6.Text = "Sports";
        }

    }
}
