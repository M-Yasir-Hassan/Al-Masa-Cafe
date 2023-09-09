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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            AdminDL.loadfromfile();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckOrderByID f = new CheckOrderByID();
            f.Show();
            this.Hide();
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

        private void Button2_Click(object sender, EventArgs e)
        {
            OrderByName f = new OrderByName();
            f.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AdminTotalOrders F = new AdminTotalOrders();
            F.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AdminAddRecep f = new AdminAddRecep();
            f.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DelReceptionist f = new DelReceptionist();
            f.Show();
            this.Hide();
        }
    }
}
