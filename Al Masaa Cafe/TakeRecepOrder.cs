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
    public partial class TakeRecepOrder : Form
    {
        private static int Sum;
        private static int idx = 0;

        // GETTER AND SETTERS...................
        public static int Sum1 { get => Sum; set => Sum = value; }
        public TakeRecepOrder()
        {
            InitializeComponent();
            CustomerDL.loadfromfile();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            for (int i = 0; i < 15; i++)
            {
                //Checking Product In Parralel Array.............
                if (name == CustomerDL.Products[i])
                {
                    //Showing Price To to text Box................
                    int pric = CustomerDL.Prices[i];
                    textBox3.Text = pric.ToString();
                    //Giving index of price of specific product chosen to store in list................
                    idx = i;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string ID = textBox2.Text;
            int length = ID.Length;
            if (ID.All(char.IsDigit))
            {
                if (length != 13)
                {
                    MessageBox.Show("Invalid CNIC!!! ");
                    TakeRecepOrder f = new TakeRecepOrder();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    //DialogueBox For Conformation..................
                    DialogResult result = MessageBox.Show("Are You Sure Want To Order....??", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        //Storing Inputs..................
                        string order = comboBox1.Text;
                        int price = CustomerDL.Prices[idx];
                        // Creating object & adding it to list.................
                        CustomerBL data = new CustomerBL(user, ID, order, price);
                        CustomerDL.Orders.Add(data);
                        CustomerDL.SpecificOrder.Add(data);
                        Sum1 = Sum1 + price;
                        //Message to show order is placed................
                        MessageBox.Show("Successfully Ordered....", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //Rolling back to CustomerForm.................
                        ReceptionistForm f = new ReceptionistForm();
                        f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input!!! only Put Numeric Numbers in CNIC.....");
                TakeRecepOrder f = new TakeRecepOrder();
                f.Show();
                this.Hide();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ReceptionistForm f = new ReceptionistForm();
            f.Show();
            this.Hide();
        }
    }
}
