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
    public partial class OrderByName : Form
    {
        private static string name;
        public OrderByName()
        {
            InitializeComponent();
        }

        public static string Name1 { get => name; set => name = value; }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Name1 = textBox1.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            adminForm f = new adminForm();
            f.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Admin2Result f = new Admin2Result();
            f.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
