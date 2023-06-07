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
    public partial class binding : Form
    {
        public binding()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void binding_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pengirimanBarangDataSet.Paket' table. You can move, or remove it, as needed.
            this.paketTableAdapter.Fill(this.pengirimanBarangDataSet.Paket);
            // TODO: This line of code loads data into the 'pengirimanBarangDataSet.Penerima' table. You can move, or remove it, as needed.
            this.penerimaTableAdapter.Fill(this.pengirimanBarangDataSet.Penerima);
            // TODO: This line of code loads data into the 'pengirimanBarangDataSet.Pengiriman' table. You can move, or remove it, as needed.
            this.pengirimanTableAdapter.Fill(this.pengirimanBarangDataSet.Pengiriman);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
