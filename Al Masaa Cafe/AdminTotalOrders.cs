using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Al_Masaa_Cafe.BL;

namespace Al_Masaa_Cafe
{
    public partial class AdminTotalOrders : Form
    {
        public AdminTotalOrders()
        {
            InitializeComponent();
            dataGridView1.DataSource = AdminBL.orders;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            adminForm f = new adminForm();
            f.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
