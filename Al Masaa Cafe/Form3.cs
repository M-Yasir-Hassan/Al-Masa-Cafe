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
using Al_Masaa_Cafe.BL;

namespace Al_Masaa_Cafe
{
    public partial class Form3 : Form
    {
        public static string user;
        public Form3()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
             user = textBox1.Text;
            string pass = textBox2.Text;
            MuserBL obj = new MuserBL(user, pass);
            string role=MuserDL.CheckRole(obj);
            if(role =="Admin")
            {
                MessageBox.Show("Welcome Admin...","Note",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                adminForm f = new adminForm();
                f.Show();
                this.Hide();
            }
            else if(role== "Receptionist")
            {
                MessageBox.Show("Welcome Receptionist...", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReceptionistForm f = new ReceptionistForm();
                f.Show();
                this.Hide();
            }
            else if(role == "Customer")
            {
                MessageBox.Show("Welcome Customer...", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CustomerForm f = new CustomerForm();
                f.Show();
                this.Hide();
            }
            else if(role=="NA")
            {
                DialogResult result=MessageBox.Show("Invalid Input...", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if(DialogResult.OK == result)
                {
                    Form3 f = new Form3();
                    f.Show();
                    this.Hide();
                }
                if(DialogResult.Cancel == result)
                {
                    Form1 f= new Form1();
                    f.Show();
                    this.Hide();
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
