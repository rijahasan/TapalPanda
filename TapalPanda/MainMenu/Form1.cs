using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //pls Allah make it work for rija too
            Admin_screens.Form1 frm1 = new Admin_screens.Form1();
            DialogResult selectButton = frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers.Customer frm2 = new Customers.Customer();
            DialogResult selectButton = frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            project_db.Form1 frm3 = new project_db.Form1();
            DialogResult selectButton = frm3.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
