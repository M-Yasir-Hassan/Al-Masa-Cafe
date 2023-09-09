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
    public partial class CustomerHistory : Form
    {
        public CustomerHistory()
        {
            InitializeComponent();
            dataGridView1.DataSource = CustomerDL.Orders;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
