using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BandencenterJWM.Customers.Forms;

namespace BandencenterJWM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "http://imgur.com/vyhKLoK.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnKlanten_Click(object sender, EventArgs e)
        {
            Klanten klantenform = new Klanten();
            klantenform.Show();
        }

        private void btnFactuur_Click(object sender, EventArgs e)
        {
            Factuur factuurform = new Factuur();
            factuurform.Show();
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            AddCustomers customer = new AddCustomers();
            customer.Show();
        }
    }
}
