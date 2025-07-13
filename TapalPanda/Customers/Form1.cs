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

namespace Customers
{
    public partial class Form1 : Form
    {
        const string constr = @"Data Source=DESKTOP-2PI6OM3\DARKYBOI;Initial Catalog=TapalPanda;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form1(DataTable table)
        {
            InitializeComponent();
            dataGridView1.DataSource = table;

            int colsum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                colsum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            textBox7.Text = Convert.ToString(colsum);


            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (DeliveryEntities db = new DeliveryEntities())
                {
                    cbo.DataSource = db.DeliveryAreas.ToList();
                    cbo.ValueMember = "DeliveryAreaID";
                    cbo.DisplayMember = "DeliveryArea1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
               
            }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string message = "Your Order was placed successfully";
            string title = "Confirmation";
            MessageBox.Show(message, title);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Customer obj = cbo.SelectedItem as Customer;
            con.Open();

            
            Console.WriteLine(cbo.Text);

            string sql = "select deliverycharges from deliveryarea where deliveryareaid = @DeliveryArea";

            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@DeliveryArea", cbo.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
           // textBox18.Text = Convert.ToString(dt.Rows[0].ItemArray[0]);
            con.Close();



            int grandtotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                grandtotal += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }

            textBox4.Text = Convert.ToString(grandtotal);




        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
