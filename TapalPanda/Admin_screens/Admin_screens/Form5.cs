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
    public partial class Form5 : Form
    {
        const string constr = @"Data Source=DESKTOP-2SMU5SO\SPARTA;Initial Catalog=TapalPanda;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();



            string sql = "select * from orders where OrderReceivedTime IS NULL";
            cm = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cm.Dispose();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 checkout = new Form1();
            checkout.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            dataGridView1.DataSource = null;

            string Name = textBox1.Text;
            string ID = txt1.Text;
            string sql;
            if ((Name != null || Name != "") && (ID == null || ID == ""))
                sql = "select * from Orders where OrderID = '" + Name + "'";
            else if ((Name == null || Name == "") && (ID != null || ID != ""))
                sql = "select * from Orders where CustomerID = '" + ID + "'";
            else if ((Name != null || Name != "") && (ID != null || ID != ""))
                sql = "select * from Orders where CustomerID = '" + ID + "' and OrderID = '" + Name + "'";
            else
                sql = "select * from Orders";
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

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            textBox1.Clear();

            dataGridView1.DataSource = null;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
