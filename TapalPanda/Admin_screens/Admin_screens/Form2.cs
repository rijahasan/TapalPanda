using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_screens
{
    public partial class Form2 : Form
    {
        const string constr = @"Data Source=DESKTOP-2SMU5SO\SPARTA;Initial Catalog=TapalPanda;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            dataGridView1.DataSource = null;


            string Name = textBox1.Text;
            string ID = txt1.Text;
            string sql;
            if ((Name != null) && (txt1.Text == null))
                sql = "select * from customer where Name = '" + Name + "'";
            else if ((Name == null || Name == "") && txt1.Text != null)
                sql = "select * from customer where customerid = '" + ID + "'";
            else if ((Name != null || Name != "") && txt1.Text != null)
                sql = "select * from customer where customerid = '" + ID + "' and Name = '" + Name + "' ";
            else
                sql = "select * from customer";
            cm = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            cm.Dispose();
                con.Close();

                if (dataGridView1.RowCount == 0)
                {
                    string message = "No Data Found";
                    string title = "Error";
                    MessageBox.Show(message, title);
                }

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            txt1.Clear();
            textBox1.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 checkout = new Form1();
            checkout.ShowDialog();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
