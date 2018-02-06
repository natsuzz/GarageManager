using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandencenterJWM.Customers.Forms
{
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text) || !string.IsNullOrWhiteSpace(textBox3.Text))
            {
               var dialogresult = MessageBox.Show("De klant is nog niet toegevoegd, weet je zeker dat je wilt afsluiten?", "Warning", MessageBoxButtons.YesNoCancel);
                if (dialogresult == DialogResult.No || dialogresult == DialogResult.Cancel)
                    return;
                else if (dialogresult == DialogResult.Yes)
                    Close();
            }
        }
    }
}
