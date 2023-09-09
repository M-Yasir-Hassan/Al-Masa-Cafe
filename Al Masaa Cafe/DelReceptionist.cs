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
    public partial class DelReceptionist : Form
    {
        public static string name;
        public static string pwd;
        public DelReceptionist()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            name=textBox1.Text;
            pwd = textBox2.Text;
            DialogResult result=MessageBox.Show("Are You Sure Want To Del Receptionist???", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                AdminDL.delReceptionist();
                MessageBox.Show("Congrats!!! Successfully Deleted Record....", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(DialogResult.No == result)
            {
                adminForm f = new adminForm();
                f.Show();
                this.Hide();
            }
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            adminForm f = new adminForm(); ;
            f.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
