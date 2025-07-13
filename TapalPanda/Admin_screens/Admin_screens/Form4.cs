using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_screens
{
    public partial class Form4 : Form
    {
        const string constr = @"Data Source=DESKTOP-2SMU5SO\SPARTA;Initial Catalog=TapalPanda;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

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


            
                string sql = "select * from orders where OrderReceivedTime IS NULL";
                cm = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cm.Dispose();
                con.Close();

                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1.Rows[e.RowIndex].Cells["Order ID"].Value.ToString();
            
        }
    }
}
