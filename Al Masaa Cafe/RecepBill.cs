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
    public partial class RecepBill : Form
    {
        public RecepBill()
        {
            InitializeComponent();
            int sum = TakeRecepOrder.Sum1;
            textBox1.Text = sum.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ReceptionistForm f = new ReceptionistForm();
            f.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
