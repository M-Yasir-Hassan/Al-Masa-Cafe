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
    public partial class ShowOrderedItems : Form
    {
        public ShowOrderedItems()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ShowOrderedItems_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerDL.SpecificOrder;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            CustomerForm f = new CustomerForm();
            f.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
