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
using Al_Masaa_Cafe.DL;

namespace Al_Masaa_Cafe
{
    public partial class AdminAddRecep : Form
    {
        public AdminAddRecep()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pwd = textBox2.Text;
            string role = comboBox1.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Are you sure to Register???", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                MuserBL obj = new MuserBL(name, pwd, role);
                MuserDL.addintolist(obj);
                MessageBox.Show("Successfully Registered!!!!!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                adminForm f = new adminForm();
                f.Show();
                this.Hide();
            }
        }
    }
}
