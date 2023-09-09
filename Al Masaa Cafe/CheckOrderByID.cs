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
    public partial class CheckOrderByID : Form
    {
        private static string id;
        public CheckOrderByID()
        {
            InitializeComponent();
        }

        public static string Id { get => id; set => id = value; }

        private void Button1_Click(object sender, EventArgs e)
        {
            adminForm f = new adminForm();
            f.Show();
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            id = textBox1.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int leng = id.Length;
            if (id.All(char.IsDigit))
            {
                if (leng != 13)
                {
                    MessageBox.Show("Invalid CNIC.......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CheckOrderByID f = new CheckOrderByID();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    Admin1Result f = new Admin1Result();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid CNIC....Only Use Numeric Digits.......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CheckOrderByID f = new CheckOrderByID();
                f.Show();
                this.Hide();
            }
        }
    }
}
