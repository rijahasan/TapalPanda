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
    public partial class Form3 : Form
    {
        const string constr = @"Data Source=DESKTOP-2SMU5SO\SPARTA;Initial Catalog=TapalPanda;Integrated Security=True";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                using (TapalPandaEntities db = new TapalPandaEntities())
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
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Item obj = cbo.SelectedItem as Item;
            if (obj != null)
            {
                txt1.Text = obj.ItemID.ToString();
                txt2.Text = obj.ItemName;
                txt3.Text = obj.UnitPrice.ToString();
                txt4.Text = obj.UnitsinStick.ToString();
                txt5.Text = obj.VendorID.ToString();


            }
        }

        private void checker_CheckedChanged(object sender, EventArgs e)
        {
            if (checker.Checked)
            {
                cbo.Enabled = false;
                txt1.Text = "";
                txt1.Enabled = false;
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                joinusbutt.Enabled = true;
            }
            else
            {
                cbo.Enabled = true;
                txt1.Enabled = true;
                joinusbutt.Enabled = false;
            }
        }

        private void joinusbutt_Click(object sender, EventArgs e)
        {
            con.Open();

            if (joinusbutt.Enabled == true)
            {
                string Name = txt2.Text;
                int Price = Convert.ToInt32(  txt3.Text);
                int Unitinstock = Convert.ToInt32( txt4.Text);
                int VendorID =Convert.ToInt32( txt5.Text);
              
                string sql = "Insert into items (ItemName, UnitPrice, UnitsinStick, VendorId) values ('" + Name + "','" + Price + "','" + Unitinstock+ "', '" + VendorID + " ')";
                cm = new SqlCommand(sql, con);

                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                string message = "Your Data was added successfully";
                string title = "Confirmation";
                MessageBox.Show(message, title);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 checkout = new Form1();
            checkout.ShowDialog();
        }
    }
}

