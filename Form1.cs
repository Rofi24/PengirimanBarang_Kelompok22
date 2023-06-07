using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grid myForm2 = new Grid();
            myForm2.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            binding myForm3 = new binding();
            myForm3.ShowDialog();
            this.Show();
        }
    }
}
