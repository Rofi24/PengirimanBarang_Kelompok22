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
    public partial class Grid : Form
    {
        public Grid()
        {
            InitializeComponent();
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pengirimanBarangDataSet.Paket' table. You can move, or remove it, as needed.
            this.paketTableAdapter.Fill(this.pengirimanBarangDataSet.Paket);
            // TODO: This line of code loads data into the 'pengirimanBarangDataSet.Pengiriman' table. You can move, or remove it, as needed.
            this.pengirimanTableAdapter.Fill(this.pengirimanBarangDataSet.Pengiriman);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myForm2 = new Form1();
            myForm2.Show();
        }
    }
}
