using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Al_Masaa_Cafe.DL;

namespace Al_Masaa_Cafe
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TakeOrder f = new TakeOrder();
            f.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            CustomerDL.storeintofile();
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            CustomerDL.SpecificOrder.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ShowOrderedItems f = new ShowOrderedItems();
            f.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CustomerBill f = new CustomerBill();
            f.Show();
            this.Hide();
        }
    }
}
