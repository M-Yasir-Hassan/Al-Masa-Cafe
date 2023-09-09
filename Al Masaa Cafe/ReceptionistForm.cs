using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Masaa_Cafe
{
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TakeRecepOrder f = new TakeRecepOrder();
            f.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RecepBill f = new RecepBill();
            f.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CustomerHistory f = new CustomerHistory();
            f.Show();
            this.Hide();
        }
    }
}
