using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_screens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void joinusbutt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Hakuna" && textBox2.Text == "Matata")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                string message = "Login Successful";
                string title = "Login";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Wrong User ID or Password";
                string title = "Login";
                MessageBox.Show(message, title);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 checkout = new Form4();
            checkout.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 checkout = new Form2();
            checkout.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 checkout = new Form3();
            checkout.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 checkout = new Form5();
            checkout.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
