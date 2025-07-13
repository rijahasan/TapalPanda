using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Customers
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerInfoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerInfoDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customerInfoDataSet.Customers);

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.customerInfoDataSet.Customers);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            customersBindingNavigatorSaveItem.PerformClick();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {

            bindingNavigatorAddNewItem.PerformClick();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            Items items = new Items();
            items.ShowDialog();

       
        }

        private void CustomerInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
