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
    public partial class Items : Form
    {
        const string constr = @"Data Source=DESKTOP-2SMU5SO\SPARTA;Initial Catalog=TapalPanda;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Items()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataTable table = new DataTable();
        private void Items_Load(object sender, EventArgs e)
        {
            try
            {
                using (ItemEntities db = new ItemEntities())
                {
                    cbo.DataSource = db.Items.ToList();
                    cbo.ValueMember = "ItemID";
                    cbo.DisplayMember = "ItemName";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Unit Price", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Total", typeof(int));



            dataGridView1.DataSource = table;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt1.Text, txt2.Text, txt3.Text, txt4.Text);
            dataGridView1.DataSource = table;
            //txt1.Clear();
            //txt2.Clear();
            //txt3.Clear();
            //txt4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //i commented this out since form1 doesnt exist anymore 
            //this.Hide();
            //Form1 checkout = new Form1(table);
            //checkout.ShowDialog();
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (ItemEntities db = new ItemEntities())
            //{
            //    cbo.DataSource = db.Items.ToList();
            //    cbo.ValueMember = "ItemID";
            //    cbo.DisplayMember = "ItemName";
            //}
            Cursor.Current = Cursors.WaitCursor;
            Item obj = cbo.SelectedItem as Item;
            if (obj != null)
            {
                txt1.Text = obj.ItemName;
                txt2.Text = obj.UnitPrice.ToString();
                //txt3.Text = obj.Contact;
                //txt4.Text = obj.Email;

            }
            if (txt3 != null)
            {
                int a = Convert.ToInt32(txt3.Text);
                int b = Convert.ToInt32(txt2.Text);
                int c = a * b;
                txt4.Text = c.ToString();
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(RowIndex);
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
